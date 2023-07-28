using DSharpPlus.Entities;
using DSharpPlus;
using DSharpPlus.SlashCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASVPack.Models;
using ASVBot.Data;
using SavegameToolkit;
using System.Text.Unicode;
using System.IO;
using NLog.LayoutRenderers.Wrappers;
using System.Drawing;
using System.Reflection.PortableExecutable;
using Microsoft.VisualBasic.FileIO;

namespace ASVBot.Commands
{
    public class PlayerCommands: ApplicationCommandModule
    {
        IContentContainer arkPack;
        IDiscordPlayerManager playerManager;
        List<IClassMap> classMaps;
        
        ContentContainerGraphics graphicsContainer;
        IResponseDataFormatter dataFormatter;


        public PlayerCommands(IContentContainer arkPack, IDiscordPlayerManager discordPlayerManager,  List<IClassMap> classMap, ContentContainerGraphics graphicsContainer, IResponseDataFormatter dataFormatter)
        {
            this.arkPack = arkPack;
            this.playerManager = discordPlayerManager;
            this.classMaps = classMap;
            this.graphicsContainer = graphicsContainer;
            this.dataFormatter = dataFormatter;
        }


        public override Task<bool> BeforeSlashExecutionAsync(InteractionContext ctx)
        {
            var discordUser = playerManager.GetPlayers().FirstOrDefault(d => d.DiscordUsername.ToLower() == ctx.Member.Username.ToLower());
            if (discordUser == null || !discordUser.IsVerified)
            {
                ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent("Command unavailable until user-link has been verified."));
                return Task.FromResult(false);
            }

            if (!arkPack.IsLoaded())
            {
                ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent("No ARK currently loaded. Please try again later."));
                return Task.FromResult(false);
            }

            return base.BeforeSlashExecutionAsync(ctx);
        }


        [SlashCommand("asv-server-summary", "Displays an overview summary of the loaded map data.")]
        public async Task GetSummary(InteractionContext ctx)
        {



            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);

            StringBuilder sb = new StringBuilder();

            var tameCount = arkPack.Tribes.SelectMany(x => x.Tames).Count();
            var playerCount = arkPack.Tribes.SelectMany(x => x.Players).Count();
            var structureCount = arkPack.Tribes.SelectMany(x => x.Structures).Count();

            sb.AppendLine($"**{arkPack.LoadedMap.MapName}**");
            sb.AppendLine($"\tWilds: {arkPack.WildCreatures.Count()}");
            sb.AppendLine($"\tTribes: {arkPack.Tribes.Count()}");
            sb.AppendLine($"\tPlayers: {playerCount}");
            sb.AppendLine($"\tStructures: {structureCount}");
            sb.AppendLine($"\tTames: {tameCount}");
            sb.AppendLine($"\tTimestamp: {arkPack.GameSaveTime.ToString()}");

            var responseString = sb.ToString();

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent(responseString));
        }


        [SlashCommand("asv-maptime", "Return the map name and timestamp when game was last saved.")]
        public async Task GetMapTimestamp(InteractionContext ctx)
        {
            string responseString = $"**{arkPack.LoadedMap.MapName}** ({arkPack.GameSaveTime.ToString()})";


            await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent(responseString));


        }

        [SlashCommand("asv-creaturelist", "View list of creature types available on this ARK.")]
        public async Task GetCreatureTypes (InteractionContext ctx)
        {
            if (!arkPack.IsLoaded())
            {
                await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent("No ARK currently loaded. Please try again later."));
                return;
            }

            var discordUser = playerManager.GetPlayers().FirstOrDefault(d => d.DiscordUsername.ToLower() == ctx.Member.Username.ToLower());

            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);

            string responseHeader = "Class Name,Friendly Name";
            List<string> responseLines = new List<string>();

            var unknownWildCreatures = arkPack.WildCreatures.Where(w => !classMaps.Any(c => c.ClassName.ToLower() == w.ClassName.ToLower())).GroupBy(g=>g.ClassName).Select(s=>new ClassMap() { ClassName = s.Key, FriendlyName=s.Key }).ToList();
            if(unknownWildCreatures!=null && unknownWildCreatures.Count > 0)
            {
                classMaps.AddRange(unknownWildCreatures);
            }
            var unknownTamedCreatures = arkPack.Tribes.SelectMany(t=>t.Tames.Where(c => !classMaps.Any(m=>m.ClassName.ToLower() == c.ClassName.ToLower()))).GroupBy(g => g.ClassName).Select(s => new ClassMap() { ClassName = s.Key, FriendlyName = s.Key }).ToList();
            if (unknownTamedCreatures != null && unknownTamedCreatures.Count > 0)
            {
                classMaps.AddRange(unknownTamedCreatures);
            }

            foreach(var cm in classMaps.OrderBy(o => o.ClassName))
            {
                responseLines.Add($"{cm.ClassName},{cm.FriendlyName}");
            }

            var responseString = dataFormatter.FormatResponseTable(responseHeader,responseLines);
            var tmpFilename = Path.GetTempFileName();
            File.WriteAllText(tmpFilename, responseString);

            FileStream fileStream = new FileStream(tmpFilename, FileMode.Open, FileAccess.Read);

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent($"<@{ctx.Member.Id}> - Here's the list of creatures on this ARK.").AddFile("CreatureList.txt", fileStream).AddMention(new UserMention(ctx.Member)));

            fileStream.Close();
            fileStream.Dispose();
            File.Delete(tmpFilename);

        }

        

        [SlashCommand("asv-wild-summary", "View summary of wild creatures available on this ARK.")]
        public async Task GetWildSummary(InteractionContext ctx)
        {
            var discordUser = playerManager.GetPlayers().FirstOrDefault(d => d.DiscordUsername.ToLower() == ctx.Member.Username.ToLower());

            //await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent($"@{ctx.Member.DisplayName} - Building wild summary report, please wait.."));
            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);

            float fromLat = 50;
            float fromLon = 50;
            float fromRadius = 100;

         
            if (discordUser != null)
            {
                fromRadius = discordUser.MaxRadius;

                var arkPlayerId = discordUser.ArkPlayerId;
                if (arkPlayerId != 0)
                {

                    var arkPlayer = arkPack.Tribes.SelectMany(x => x.Players.Where(p => p.Id == arkPlayerId)).FirstOrDefault();
                    if (arkPlayer != null)
                    {
                        if (arkPlayer.Longitude.HasValue)
                        {
                            fromLat = arkPlayer.Latitude.GetValueOrDefault(50);
                            fromLon = arkPlayer.Longitude.GetValueOrDefault(50);


                        }
                    }
                }

            }



            var responseString = GetWildSummary(fromLat, fromLon, fromRadius);
            var tmpFilename = Path.GetTempFileName();
            File.WriteAllText(tmpFilename, responseString);
            
            FileStream fileStream = new FileStream(tmpFilename,FileMode.Open, FileAccess.Read);



            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent($"<@{ctx.Member.Id}> - Here's the wild summary showing creatures within a radius of {fromRadius} from {fromLat.ToString("f1")}/{fromLon.ToString("f1")}.").AddFile("WildSummary.txt",fileStream).AddMention(new UserMention(ctx.Member)));

            fileStream.Close();
            fileStream.Dispose();
            File.Delete(tmpFilename);

        }
        

        [SlashCommand("asv-wild-detail", "Show details of selected wild creature types nearby.")]
        public async Task GetWildDetail(InteractionContext ctx, [Option("class_name", "Creature Type")]string selectedClass)
        {
            var discordUser = playerManager.GetPlayers().FirstOrDefault(d => d.DiscordUsername.ToLower() == ctx.Member.Username.ToLower());


            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);

            var arkPlayer = arkPack.Tribes.SelectMany(t=>t.Players.Where(p=>p.Id == discordUser.ArkPlayerId)).FirstOrDefault();
            if (arkPlayer == null)
            {

                return;
            }

            if(selectedClass.Trim().Length == 0)
            {

                return;
            }

            float fromLat = arkPlayer.Latitude.GetValueOrDefault(0);
            float fromLon = arkPlayer.Longitude.GetValueOrDefault(0);
            float fromRadius = discordUser.MaxRadius;

            var hasMatches = arkPack.WildCreatures.Any(c => c.ClassName.ToLower().Contains(selectedClass.ToLower()));
            if (!hasMatches)
            {
                await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent($"<@{ctx.Member.Id}> - There were no matches for the selected creature type(s) within a radius of {fromRadius} from {fromLat.ToString("f1")}/{fromLon.ToString("f1")}.").AddMention(new UserMention(ctx.Member)));

                return;
            }

            var wildDetails = arkPack.WildCreatures
                .Where(w =>
                            (
                                (Math.Abs(w.Latitude.GetValueOrDefault(0) - fromLat) <= fromRadius) 
                                && (Math.Abs(w.Longitude.GetValueOrDefault(0) - fromLon) <= fromRadius)
                            )
                            && w.ClassName.ToLower().Contains(selectedClass.ToLower()))
                .OrderBy(o=>o.ClassName).ThenByDescending(o=>o.BaseLevel).ToList();

            
            if(wildDetails== null || wildDetails.Count == 0)
            {
                await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent($"<@{ctx.Member.Id}> - There were no matches for the selected creature type(s) within a radius of {fromRadius} from {fromLat.ToString("f1")}/{fromLon.ToString("f1")}.").AddMention(new UserMention(ctx.Member)));
                return;
            }

            StringBuilder sbHeader = new StringBuilder();
            sbHeader.Append("Creature,Gender,Level");
            if (discordUser.ResultLocation)
            {
                sbHeader.Append(",Lat,Lon");
            }
            if (discordUser.ResultStats)
            {
                sbHeader.Append(",HP,Stam,Melee,Weight,Speed,Food,Oxy,Craft");
            }
            List<string> lineItems = new List<string>();

            foreach(var wild in wildDetails)
            {
                StringBuilder sbLine = new StringBuilder();

                string creatureType = wild.ClassName;
                var cMap = classMaps.FirstOrDefault(c => c.ClassName.ToLower() == wild.ClassName.ToLower());
                if (cMap != null) creatureType = cMap.FriendlyName;


                sbLine.Append($"{creatureType},{wild.Gender},{wild.BaseLevel}");

                if (discordUser.ResultLocation)
                {
                    sbLine.Append($",{wild.Latitude.GetValueOrDefault(0).ToString("f1")},{wild.Longitude.GetValueOrDefault(0).ToString("f1")}");
                }
                if (discordUser.ResultStats)
                {
                    sbLine.Append($",{wild.BaseStats[0]}");
                    sbLine.Append($",{wild.BaseStats[1]}");
                    sbLine.Append($",{wild.BaseStats[8]}");
                    sbLine.Append($",{wild.BaseStats[7]}");
                    sbLine.Append($",{wild.BaseStats[9]}");
                    sbLine.Append($",{wild.BaseStats[4]}");
                    sbLine.Append($",{wild.BaseStats[3]}");
                    sbLine.Append($",{wild.BaseStats[11]}");
                }

                lineItems.Add(sbLine.ToString());
            }

            var responseString = dataFormatter.FormatResponseTable(sbHeader.ToString(),lineItems);

            var tmpFilename = Path.GetTempFileName();
            File.WriteAllText(tmpFilename, responseString);
            FileStream fileStream = new FileStream(tmpFilename, FileMode.Open, FileAccess.Read);

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent($"<@{ctx.Member.Id}> - Here's the report showing selected creature type(s) within a radius of {fromRadius} from {fromLat.ToString("f1")}/{fromLon.ToString("f1")}.").AddFile("WildDetails.txt", fileStream).AddMention(new UserMention(ctx.Member)));

            fileStream.Close();
            fileStream.Dispose();
            File.Delete(tmpFilename);

        }
        
        [SlashCommand("asv-wild-map", "Show map of selected wild creature types nearby.")]
        public async Task GetWildMapImage(InteractionContext ctx, [Option("class_name", "Creature Type")] string creatureType)
        {

            var discordUser = playerManager.GetPlayers().FirstOrDefault(d => d.DiscordUsername.ToLower() == ctx.Member.Username.ToLower());

            if (!discordUser.MarkedMaps)
            {
                await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent("Your account does not have permission to receive map images."));
                return;
            }

            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);

            var discordPlayer = playerManager.GetPlayers().FirstOrDefault(p => p.DiscordUsername.ToLower() == ctx.Member.Username.ToLower());
            if (discordPlayer == null)
            {


                return;
            }

            var arkPlayer = arkPack.Tribes.SelectMany(t => t.Players.Where(p => p.Id == discordPlayer.ArkPlayerId)).FirstOrDefault();
            if (arkPlayer == null)
            {

                return;
            }

            if (creatureType.Trim().Length == 0)
            {

                return;
            }

            float fromLat = arkPlayer.Latitude.GetValueOrDefault(0);
            float fromLon = arkPlayer.Longitude.GetValueOrDefault(0);
            float fromRadius = discordPlayer.MaxRadius;

            var mapImage = graphicsContainer.GetMapImageWild(creatureType, fromLat,fromLon, fromRadius);


            string tmpFilename = Path.GetTempFileName();
            mapImage.Save(tmpFilename,System.Drawing.Imaging.ImageFormat.Jpeg);
            FileStream fileStream = new FileStream(tmpFilename, FileMode.Open, FileAccess.Read);

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent($"<@{ctx.Member.Id}> - Here's the map showing selected creature type(s) within a radius of {fromRadius} from {fromLat.ToString("f1")}/{fromLon.ToString("f1")}.").AddFile("WildDetails.jpg", fileStream).AddMention(new UserMention(ctx.Member)));

            fileStream.Close();
            fileStream.Dispose();
            File.Delete(tmpFilename);
        }

        //asv-my-tames
        [SlashCommand("asv-my-tames", "Show list of your tames and where they are.")]
        public async Task GetMyTames(InteractionContext ctx,[Option("creatureType", "Type of creature(s) to limit the results to (Optional)")] string creatureType = "")
        {


            var discordUser = playerManager.GetPlayers().FirstOrDefault(d => d.DiscordUsername.ToLower() == ctx.Member.Username.ToLower());



            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);

            var responseHeader = "Creature,Name,Gender,Base,Level,Lat,Lon,HP0,Stam0,Melee0,Weight0,Speed0,Food0,Oxy0,Craft0,HP1,Stam1,Melee1,Weight1,Speed1,Food1,Oxy1,Craft1,Wandering,Mating,Neutered";
            List<string> responseLines = new List<string>();

            var tribeTames = arkPack.Tribes.Where(t => t.Players.Any(p => p.Id == discordUser.ArkPlayerId)).SelectMany(s => s.Tames).Where(t=>t.ClassName.ToLower().Contains(creatureType.ToLower())).ToList();
            if (tribeTames != null && tribeTames.Count > 0)
            {
                //Creature,Name,Gender,Base,Level,Lat,Lon,
                //HP0,Stam0,Melee0,Weight0,Speed0,Food0,Oxy0,Craft0,HP1,Stam1,Melee1,Weight1,Speed1,Food1,Oxy1,Craft1,
                //Wandering,Mating,Neutered
                foreach(var tame in tribeTames.OrderBy(t=>t.ClassName).ThenByDescending(t=>t.Level))
                {
                    StringBuilder responseLineData = new StringBuilder();

                    var creatureTypeName = tame.ClassName;
                    var cm = classMaps.FirstOrDefault(c => c.ClassName.ToLower() == tame.ClassName.ToLower());
                    if (cm != null) creatureTypeName = cm.FriendlyName;

                    responseLineData.Append($"{creatureTypeName}");
                    responseLineData.Append($",{tame.Name}");
                    responseLineData.Append($",{tame.Gender}");
                    responseLineData.Append($",{tame.BaseLevel}");
                    responseLineData.Append($",{tame.Level}");
                    responseLineData.Append($",{tame.Latitude.GetValueOrDefault(0).ToString("f1")}");
                    responseLineData.Append($",{tame.Longitude.GetValueOrDefault(0).ToString("f1")}");

                    responseLineData.Append($",{tame.BaseStats[0]}");
                    responseLineData.Append($",{tame.BaseStats[1]}");
                    responseLineData.Append($",{tame.BaseStats[8]}");
                    responseLineData.Append($",{tame.BaseStats[7]}");
                    responseLineData.Append($",{tame.BaseStats[9]}");
                    responseLineData.Append($",{tame.BaseStats[4]}");
                    responseLineData.Append($",{tame.BaseStats[3]}");
                    responseLineData.Append($",{tame.BaseStats[11]}");

                    responseLineData.Append($",{tame.TamedStats[0]}");
                    responseLineData.Append($",{tame.TamedStats[1]}");
                    responseLineData.Append($",{tame.TamedStats[8]}");
                    responseLineData.Append($",{tame.TamedStats[7]}");
                    responseLineData.Append($",{tame.TamedStats[9]}");
                    responseLineData.Append($",{tame.TamedStats[4]}");
                    responseLineData.Append($",{tame.TamedStats[3]}");
                    responseLineData.Append($",{tame.TamedStats[11]}");

                    responseLineData.Append($",{tame.IsWandering}");
                    responseLineData.Append($",{tame.IsMating}");
                    responseLineData.Append($",{tame.IsNeutered}");

                    responseLines.Add(responseLineData.ToString());

                }

            }
            else
            {
                //no tames
                await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent($"<@{ctx.Member.Id}> - You don't seem to have any tames on this server.").AddMention(new UserMention(ctx.Member)));
                return;
            }

            var responseString = dataFormatter.FormatResponseTable(responseHeader, responseLines);

            var tmpFilename = Path.GetTempFileName();
            File.WriteAllText(tmpFilename, responseString);
            FileStream fileStream = new FileStream(tmpFilename, FileMode.Open, FileAccess.Read);

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent($"<@{ctx.Member.Id}> - Here's the report showing your tames for the selected creature type(s).").AddFile("TameDetails.txt", fileStream).AddMention(new UserMention(ctx.Member)));

            fileStream.Close();
            fileStream.Dispose();
            File.Delete(tmpFilename);


        }

        [SlashCommand("asv-my-tames-map", "Show map of your tames with markers of where they are.")]
        public async Task GetMyTamesMap(InteractionContext ctx, [Option("creatureType","Type of creature(s) to limit the results to (Optional)")]string creatureType = "")
        {


            var discordUser = playerManager.GetPlayers().FirstOrDefault(d => d.DiscordUsername.ToLower() == ctx.Member.Username.ToLower());


            if (!discordUser.MarkedMaps)
            {
                await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent("Your account does not have permission to receive map images."));
                return;
            }


            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);

            var mapImage = graphicsContainer.GetMapImageTamed(discordUser.ArkPlayerId,creatureType);


            string tmpFilename = Path.GetTempFileName();
            mapImage.Save(tmpFilename, System.Drawing.Imaging.ImageFormat.Jpeg);
            FileStream fileStream = new FileStream(tmpFilename, FileMode.Open, FileAccess.Read);

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent($"<@{ctx.Member.Id}> - Here's the map showing tame locations.").AddFile("Tames.jpg", fileStream).AddMention(new UserMention(ctx.Member)));

            fileStream.Close();
            fileStream.Dispose();
            File.Delete(tmpFilename);

        }

        [SlashCommand("asv-my-structures", "Show list of your structures and where they are.")]
        public async Task GetMyStructures(InteractionContext ctx, [Option("structureType", "Type of structure to search.")]string structureType = "")
        {
            var discordUser = playerManager.GetPlayers().FirstOrDefault(d => d.DiscordUsername.ToLower() == ctx.Member.Username.ToLower());

            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);


            var responseHeader = "Structure,Lat,Lon,Inventory,Locked";
            List<string> responseLines = new List<string>();

            var tribeStructures = arkPack.Tribes.Where(t => t.Players.Any(p => p.Id == discordUser.ArkPlayerId)).SelectMany(s => s.Structures).Where(t => t.ClassName.ToLower().Contains(structureType.ToLower())).ToList();
            if (tribeStructures != null && tribeStructures.Count > 0)
            {
             
                foreach (var structure in tribeStructures.OrderBy(t => t.ClassName))
                {
                    StringBuilder responseLineData = new StringBuilder();

                    var structureTypeName = structure.ClassName;
                    var cm = classMaps.FirstOrDefault(c => c.ClassName.ToLower() == structure.ClassName.ToLower());
                    if (cm != null) structureTypeName = cm.FriendlyName;

                    responseLineData.Append($"{structureTypeName}");
                    responseLineData.Append($",{structure.Latitude.GetValueOrDefault(0).ToString("f1")}");
                    responseLineData.Append($",{structure.Longitude.GetValueOrDefault(0).ToString("f1")}");
                    responseLineData.Append($",{(structure.Inventory!=null && structure.Inventory.Items!=null && structure.Inventory.Items.Count > 0)}");
                    responseLineData.Append($",{structure.IsLocked}");

                    responseLines.Add(responseLineData.ToString());

                }

            }
            else
            {
                //no tames
                await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent($"<@{ctx.Member.Id}> - You don't seem to have any structures on this server.").AddMention(new UserMention(ctx.Member)));
                return;
            }

            var responseString = dataFormatter.FormatResponseTable(responseHeader, responseLines);

            var tmpFilename = Path.GetTempFileName();
            File.WriteAllText(tmpFilename, responseString);
            FileStream fileStream = new FileStream(tmpFilename, FileMode.Open, FileAccess.Read);

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent($"<@{ctx.Member.Id}> - Here's the report showing your structures for the selected type(s).").AddFile("StructureDetails.txt", fileStream).AddMention(new UserMention(ctx.Member)));

            fileStream.Close();
            fileStream.Dispose();
            File.Delete(tmpFilename);


        }


        [SlashCommand("asv-my-structures-map", "Show map of your structures and where they are.")]
        public async Task GetMyStructuresMap(InteractionContext ctx, [Option("structureType", "Type of structure to search.")] string structureFilter = "")
        {


            var discordUser = playerManager.GetPlayers().FirstOrDefault(d => d.DiscordUsername.ToLower() == ctx.Member.Username.ToLower());


            if (!discordUser.MarkedMaps)
            {
                await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent("Your account does not have permission to receive map images."));
                return;
            }


            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);

            var mapImage = graphicsContainer.GetMapImageStructures(discordUser.ArkPlayerId, structureFilter);
            if (mapImage != null)
            {

            }
            string tmpFilename = Path.GetTempFileName();
            mapImage.Save(tmpFilename, System.Drawing.Imaging.ImageFormat.Jpeg);
            FileStream fileStream = new FileStream(tmpFilename, FileMode.Open, FileAccess.Read);

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent($"<@{ctx.Member.Id}> - Here's the map showing tame locations.").AddFile("Tames.jpg", fileStream).AddMention(new UserMention(ctx.Member)));

            fileStream.Close();
            fileStream.Dispose();
            File.Delete(tmpFilename);

        }

        [SlashCommand("asv-my-items", "Show list of your items and where they are.")]
        public async Task GetMyItems(InteractionContext ctx, [Option("searchTerm", "Search by item type.")]string itemFilter = "")
        {

            var discordUser = playerManager.GetPlayers().FirstOrDefault(d => d.DiscordUsername.ToLower() == ctx.Member.Username.ToLower());


            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);


            var responseHeader = "Storage,Lat,Lon,Item,Rating,Count";

            List<string> responseLines = new List<string>();

            var tribeStructures = arkPack.Tribes
                                            .Where(t => t.Players.Any(p => p.Id == discordUser.ArkPlayerId))
                                            .SelectMany(s => s.Structures)
                                            .Where(t =>
                                                        (t.Inventory != null && t.Inventory.Items != null && t.Inventory.Items.LongCount(i=> !i.IsEngram &! i.IsBlueprint && i.ClassName.ToLower().Contains(itemFilter))> 0)
                                            ).ToList();



            List<Tuple<string, string, string, string, float, int>> itemList = new List<Tuple<string, string, string, string, float, int>>();


            if (tribeStructures != null && tribeStructures.Count > 0)
            {
                foreach (var tribeStructure in tribeStructures)
                {
                    string containerType = "Structure - ";
                    string containerName = tribeStructure.ClassName;
                    var classMap = classMaps.FirstOrDefault(c => c.ClassName.ToLower() == tribeStructure.ClassName.ToLower());
                    if (classMap != null) containerName = classMap.FriendlyName;

                    containerType = string.Concat(containerType, containerName);

                    var groupedItems = tribeStructure.Inventory.Items.Where(i=> i.ClassName.ToLower().Contains(itemFilter)).GroupBy(g => new { ClassName = g.ClassName, Rating = g.Rating.GetValueOrDefault(0) }).Select(i => new { ClassName = i.Key.ClassName, Rating = i.Key.Rating, Count = i.Sum(s=>s.Quantity) }).ToList();
                    foreach(var itemCountPair in groupedItems)
                    {
                        string itemName = itemCountPair.ClassName;
                        var itemClassMap = classMaps.FirstOrDefault(c=>c.ClassName.ToLower() == itemCountPair.ClassName.ToLower());
                        if(itemClassMap!=null) itemName = itemClassMap.FriendlyName;

                        //Container, Lat, Lon, Item, Rating, Count 
                        itemList.Add(new Tuple<string,string,string,string,float,int>(containerType, 
                                    tribeStructure.Latitude.GetValueOrDefault(0).ToString("f1"),
                                    tribeStructure.Longitude.GetValueOrDefault(0).ToString("f1"),
                                    itemName,
                                    itemCountPair.Rating,
                                    itemCountPair.Count
                                    ));




                    }

                }
            }



            var tribePlayers = arkPack.Tribes
                                            .Where(t => t.Players.Any(p => p.Id == discordUser.ArkPlayerId))
                                            .SelectMany(s => s.Players)
                                            .Where(t =>
                                                        (t.Inventory != null && t.Inventory.Items != null && t.Inventory.Items.LongCount(i => !i.IsEngram & !i.IsBlueprint && i.ClassName.ToLower().Contains(itemFilter)) > 0)
                                            ).ToList();


            if (tribePlayers != null && tribePlayers.Count > 0)
            {
                foreach (var tribePlayer in tribePlayers)
                {
                    string containerType = "Player - ";
                    string containerName = tribePlayer.CharacterName;                   
                    containerType = string.Concat(containerType, containerName);

                    var groupedItems = tribePlayer.Inventory.Items.Where(i=> i.ClassName.ToLower().Contains(itemFilter)).GroupBy(g => new { ClassName = g.ClassName, Rating = g.Rating.GetValueOrDefault(0) }).Select(i => new { ClassName = i.Key.ClassName, Rating = i.Key.Rating, Count = i.Sum(s=>s.Quantity) }).ToList();
                    foreach (var itemCountPair in groupedItems)
                    {
                        string itemName = itemCountPair.ClassName;
                        var itemClassMap = classMaps.FirstOrDefault(c => c.ClassName.ToLower() == itemCountPair.ClassName.ToLower());
                        if (itemClassMap != null) itemName = itemClassMap.FriendlyName;

                        //Container, Lat, Lon, Item, Rating, Count 
                        itemList.Add(new Tuple<string,string,string,string,float,int>(containerType,
                                    tribePlayer.Latitude.GetValueOrDefault(0).ToString("f1"),
                                    tribePlayer.Longitude.GetValueOrDefault(0).ToString("f1"),
                                    itemName,
                                    itemCountPair.Rating,
                                    itemCountPair.Count
                                    ));




                    }

                }
            }

            if(itemList.Count ==0)
            {
                //no items matching search
                await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent($"<@{ctx.Member.Id}> - You don't seem to have any items that match your query.").AddMention(new UserMention(ctx.Member)));
                return;
            }


            foreach (var itemMatch in itemList.OrderBy(o => o.Item1).ThenBy(o => o.Item4))
            {
                string itemString = itemMatch.Item1;
                itemString = string.Concat(itemString, ",", itemMatch.Item2);
                itemString = string.Concat(itemString, ",", itemMatch.Item3);
                itemString = string.Concat(itemString, ",", itemMatch.Item4);
                itemString = string.Concat(itemString, ",", itemMatch.Item5);
                itemString = string.Concat(itemString, ",", itemMatch.Item6);
                responseLines.Add(itemString);
            }

            var responseString = dataFormatter.FormatResponseTable(responseHeader, responseLines);

            var tmpFilename = Path.GetTempFileName();
            File.WriteAllText(tmpFilename, responseString);
            FileStream fileStream = new FileStream(tmpFilename, FileMode.Open, FileAccess.Read);

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent($"<@{ctx.Member.Id}> - Here's the report showing your items for the selected type(s).").AddFile("ItemDetails.txt", fileStream).AddMention(new UserMention(ctx.Member)));

            fileStream.Close();
            fileStream.Dispose();
            File.Delete(tmpFilename);

        }

        [SlashCommand("asv-my-items-map", "Show list of your items and where they are.")]
        public async Task GetMyItemsMap(InteractionContext ctx, [Option("searchItem", "Search by item type.")] string itemFilter = "")
        {


            var discordUser = playerManager.GetPlayers().FirstOrDefault(d => d.DiscordUsername.ToLower() == ctx.Member.Username.ToLower());


            if (!discordUser.MarkedMaps)
            {
                await ctx.CreateResponseAsync(InteractionResponseType.ChannelMessageWithSource, new DiscordInteractionResponseBuilder().WithContent("Your account does not have permission to receive map images."));
                return;
            }


            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);

            var mapImage = graphicsContainer.GetMapImageItems(discordUser.ArkPlayerId, itemFilter);
            string tmpFilename = Path.GetTempFileName();
            mapImage.Save(tmpFilename, System.Drawing.Imaging.ImageFormat.Jpeg);
            FileStream fileStream = new FileStream(tmpFilename, FileMode.Open, FileAccess.Read);

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent($"<@{ctx.Member.Id}> - Here's the map showing matching item locations.").AddFile("Items.jpg", fileStream).AddMention(new UserMention(ctx.Member)));

            fileStream.Close();
            fileStream.Dispose();
            File.Delete(tmpFilename);


        }


        private string GetWildSummary(float fromLat, float fromLon, float fromRadius)
        {
     

            var wildSummary = arkPack.WildCreatures
                .Where(w => ((Math.Abs(w.Latitude.GetValueOrDefault(0) - fromLat) <= fromRadius) && (Math.Abs(w.Longitude.GetValueOrDefault(0) - fromLon) <= fromRadius)))
                .GroupBy(c => c.ClassName)
                .Select(g => new { ClassName = g.Key, Name = classMaps.Count(d => d.ClassName == g.Key) == 0 ? g.Key : classMaps.Where(d => d.ClassName == g.Key).First().FriendlyName, Count = g.Count(), Min = g.Min(l => l.BaseLevel), Max = g.Max(l => l.BaseLevel) })
                .OrderBy(o => o.Name);

            var summaryMin = wildSummary.Min(s => s.Min);
            var summaryMax = wildSummary.Max(s => s.Max);

            List<string> lineData = new List<string>();


            lineData.Add($"[All Wild],{wildSummary.Sum(s => s.Count)},{summaryMin},{summaryMax}");

            foreach (var summary in wildSummary)
            {
                lineData.Add($"{summary.Name},{summary.Count},{summary.Min},{summary.Max}");



            }

            
            string responseString = dataFormatter.FormatResponseTable("Creature,Count,Min,Max", lineData);

            return responseString;
        }


    }
}
