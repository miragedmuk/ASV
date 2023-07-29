using ASVPack.Models;
using DSharpPlus.Entities;
using DSharpPlus;
using DSharpPlus.SlashCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ASVPack;
using SavegameToolkit;
using ASVBot.Data;
using System.Reflection.PortableExecutable;
using DSharpPlus.SlashCommands.Attributes;
using ASVBot.Config;
using SavegameToolkitAdditions.IndexMappings;
using System.Diagnostics;

namespace ASVBot.Commands
{
    [SlashCommandGroup("asv-admin", "Admin commands", false)]
    public class AdminCommands : ApplicationCommandModule
    {
        IContentContainer arkPack;
        IDiscordPlayerManager playerManager;
        BotConfig botConfig;
        IResponseDataFormatter dataFormatter;
        List<IClassMap> classMaps;
        public AdminCommands(IContentContainer arkPack, IDiscordPlayerManager playerMan, BotConfig config, IResponseDataFormatter responseFormatter, List<IClassMap> objectMap)
        {
            this.arkPack = arkPack;
            this.playerManager = playerMan;
            this.botConfig = config;
            this.dataFormatter = responseFormatter;
            this.classMaps = objectMap;
        }



        [SlashCommand("list-users", "List discord users of ASVBot.")]
        public async Task GetUsers(InteractionContext ctx, [Option("unverified", "Show only unverified users.")] bool onlyUnverified)
        {
            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);

            string reportHeader = "User,Ark Id,Ark Name,Max Radius,Location,Stats,Maps";
            List<string> reportLines = new List<string>();

            foreach (var botUser in playerManager.GetPlayers().OrderBy(o => o.DiscordUsername))
            {
                if (onlyUnverified && botUser.IsVerified)
                {
                    //ignore
                }
                else
                {
                    reportLines.Add($"{botUser.DiscordUsername},{botUser.ArkPlayerId},{botUser.ArkCharacterName},{botUser.MaxRadius},{botUser.ResultLocation},{botUser.ResultStats},{botUser.MarkedMaps}");
                }
            }

            string responseString = dataFormatter.FormatResponseTable(reportHeader, reportLines);

            var tmpFilename = Path.GetTempFileName();
            File.WriteAllText(tmpFilename, responseString);
            FileStream fileStream = new FileStream(tmpFilename, FileMode.Open, FileAccess.Read);

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("").AddFile("asvbot-users.txt", fileStream));



        }


        [SlashCommand("verify-user", "Verify a user request to link to an ARK character.")]
        public async Task VerifyUser(InteractionContext ctx, [Option("discordUsername", "Discord user to verify")] string discordUsername, [Option("userRadius", "Max radius to scan around player location.")] double radius, [Option("showLoc", "Include location data in responses.")] bool showLoc, [Option("showStats", "Show creature statistics in responses.")] bool showStats, [Option("allowMaps", "Allow user to request map images with markers of creature locations.")] bool allowMaps)
        {
            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);

            string responseString = $"No discord user link request found matching: {discordUsername}";

            var discordPlayerLink = playerManager.GetPlayers().FirstOrDefault(d => d.DiscordUsername.ToLower() == discordUsername.ToLower());
            if (discordPlayerLink != null)
            {
                discordPlayerLink.IsVerified = true;
                discordPlayerLink.MaxRadius = (float)radius;
                discordPlayerLink.ResultLocation = showLoc;
                discordPlayerLink.ResultStats = showStats;
                discordPlayerLink.MarkedMaps = allowMaps;
                responseString = $"Account link verified: {discordUsername} now linked with {discordPlayerLink.ArkCharacterName} ({discordPlayerLink.ArkPlayerId})";
            }

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent(responseString));

        }

        [SlashCommand("add-user", "Add and auto-verify a user link to an ARK character.")]
        public async Task AddUser(InteractionContext ctx, [Option("discordUsername", "Discord user to assign")] string discordUsername, [Option("arkPlayerId", "ARK playerId to link this discord user to.")] long arkPlayerId, [Option("userRadius", "Max radius to scan around player location.")] double radius = 100, [Option("showLoc", "Include location data in responses.")] bool showLoc = true, [Option("showStats", "Show creature statistics in responses.")] bool showStats = true, [Option("allowMaps", "Allow user to request map images with markers of creature locations.")] bool allowMaps = true)
        {
            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);

            string responseString = $"No discord user link request found matching: {discordUsername}";

            var discordPlayerLink = playerManager.GetPlayers().FirstOrDefault(d => d.DiscordUsername.ToLower() == discordUsername.ToLower());
            if (discordPlayerLink != null)
            {
                discordPlayerLink.IsVerified = true;
                discordPlayerLink.ArkPlayerId = arkPlayerId;
                discordPlayerLink.MaxRadius = (float)radius;
                discordPlayerLink.ResultLocation = showLoc;
                discordPlayerLink.ResultStats = showStats;
                discordPlayerLink.MarkedMaps = allowMaps;
                responseString = $"Account linked and verified: {discordUsername} now linked with {discordPlayerLink.ArkCharacterName} ({discordPlayerLink.ArkPlayerId})";
            }
            else
            {
                var arkPlayer = arkPack.Tribes.SelectMany(t => t.Players.Where(p => p.Id == arkPlayerId)).FirstOrDefault();

                if (arkPlayer == null)
                {
                    responseString = "Unable to find ARK player matching provided Id.";
                    await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent(responseString));
                    return;

                }
                var discordPlayer = new DiscordPlayer()
                {
                    DiscordUsername = discordUsername,
                    ArkCharacterName = arkPlayer.CharacterName,
                    ArkPlayerId = arkPlayerId,
                    MarkedMaps = allowMaps,
                    ResultLocation = showLoc,
                    ResultStats = showStats,
                    MaxRadius = (float)radius,
                    IsVerified = true
                };
                playerManager.GetPlayers().Add(discordPlayer);
                responseString = $"Account linked and verified: {discordUsername} now linked with {discordPlayer.ArkCharacterName} ({discordPlayer.ArkPlayerId})";
            }

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent(responseString));

        }


        [SlashCommand("remove-user", "Remove user from any pending request and deny lists.")]
        public async Task RemoveUser(InteractionContext ctx, [Option("discordUsername", "Discord user to verify")] string discordUsername)
        {
            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);

            string responseString = $"Account link request removed: {discordUsername})";

            playerManager.RemovePlayer(discordUsername);

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent(responseString));

        }


        [SlashCommand("deny-user", "Reject any user request to link to an ARK character and deny and future requests.")]
        public async Task DenyUser(InteractionContext ctx, [Option("discordUsername", "Discord user to deny")] string discordUsername)
        {
            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);

            string responseString = $"Account link denied: {discordUsername})";
            playerManager.DenyPlayer(discordUsername);

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent(responseString));

        }



        [SlashCommand("save", "Commit any data changes since last save.")]
        public async Task SavePlayers(InteractionContext ctx)
        {
            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);
            playerManager.Save();
            botConfig.Save();
            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("Bot data saved."));
        }

        [SlashCommand("ark-load", "Load ARK save game data.")]
        public async Task Load(InteractionContext ctx, [Option("arkSaveFile", ".ark filename to load.")] string arkFilename, [Option("arkClusterFolder", "Cluster folder (optional)")] string clusterFolder = "")
        {

            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);
            string responseString = string.Empty;

            arkPack = new ContentContainer();
            arkPack.LoadSaveGame(arkFilename, string.Empty, clusterFolder);
            botConfig.ArkSaveFile = arkFilename;
            botConfig.ArkClusterFolder = clusterFolder;
            botConfig.Save();

            responseString = $"Map loaded: {arkPack.LoadedMap.MapName} ({arkPack.GameSaveTime.ToString()})";

            //Some time consuming task like a database call or a complex operation
            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent(responseString));
        }

        [SlashCommand("ark-reload-interval", "Interval in minutes to check game save and re-load if timestamp changed (0 to disable auto-reload).")]
        public async Task SetReloadInterval(InteractionContext ctx, [Option("intervalMins", "Minutes between each check for any game save changes.")] long minutes = 5)
        {
            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);
            botConfig.AutoReloadTimeMinutes = (int)minutes;
            botConfig.Save();
            string responseString = $"Re-load check interval now set to {minutes} mins.";
            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent(responseString));
        }


        [SlashCommand("ark-reload", "Re-load the save game data if timestamp has changed.")]
        public async Task Reload(InteractionContext ctx)
        {

            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);
            string responseString = string.Empty;

            if (arkPack.Reload())
            {
                responseString = $"Map reloaded: {arkPack.LoadedMap.MapName} ({arkPack.GameSaveTime.ToString()})";
            }
            else
            {
                responseString = $"Map already up to date: {arkPack.LoadedMap.MapName} ({arkPack.GameSaveTime.ToString()})";
            }

            //Some time consuming task like a database call or a complex operation
            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent(responseString));
        }











        //ark-tribes <filterText> <tribeId | tribeName | discordUser>
        /*
            TribeId, Tribe Name, OwnerId, Owner, Player Count, Structure Count, Tame Count, Last Active

        */
        [SlashCommand("ark-tribes", "List tribe(s) summary associated with a tribe id, name or discord user.", false)]
        public async Task ListArkTribes(InteractionContext ctx, [Option("tribeFilter", "Tribe Id or Tribe Name (Optional)")] string tribeFilter = "", [Option("discordUser", "Discord user filter [optional]")] DiscordUser discordMember = null)
        {

            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);

            string reportHeader = "Id,Name,Last Active,Players,Structures,Tames";
            List<string> reportLines = new List<string>();

            var tribes = arkPack.Tribes;
            if (tribeFilter != null && tribeFilter.Length > 0)
            {
                tribes = arkPack.Tribes.Where(t => t.TribeId.ToString() == tribeFilter || t.TribeFileName == tribeFilter).ToList();
            }
            if (discordMember != null)
            {
                var discordUser = playerManager.GetPlayers().FirstOrDefault(p => p.DiscordUsername.ToLower() == discordMember.Username.ToLower());
                if (discordUser != null)
                {

                    tribes = tribes.Where(t => t.Players.LongCount(p => p.Id == discordUser.ArkPlayerId) > 0).ToList();
                }
            }

            if (tribes.Count == 0)
            {
                await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("Unable to find any tribe data matching your filter."));
                return;
            }

            foreach (var tribe in tribes)
            {
                var structCount = tribe.Structures.Count();
                var tameCount = tribe.Tames.Count();
                var playerCount = tribe.Players.Count();

                reportLines.Add($"{tribe.TribeId.ToString().Trim()},{tribe.TribeName},{tribe.LastActive.Value.ToString() ?? "Unknown"},{playerCount},{structCount},{tameCount}");

            }


            string responseString = dataFormatter.FormatResponseTable(reportHeader, reportLines);

            var tmpFilename = Path.GetTempFileName();
            File.WriteAllText(tmpFilename, responseString);
            FileStream fileStream = new FileStream(tmpFilename, FileMode.Open, FileAccess.Read);

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("").AddFile("asvbot-arktribes.txt", fileStream));
        }

        //ark-players <filterText> <tribeId | tribeName | discordUser>
        /*
            TribeId, Tribe Name, Player Id, Player Name, Gender, Level, Lat, Lon

        */
        [SlashCommand("ark-players", "List players associated with a tribe id, name or discord user.", false)]
        public async Task ListArkPlayers(InteractionContext ctx, [Option("tribeFilter", "Tribe Id or Tribe Name (Optional)")] string tribeFilter = "", [Option("discordUser", "Discord user filter [optional]")] DiscordUser discordMember = null)
        {
            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);

            string reportHeader = "Tribe Id,Tribe,Player Id,Character Name,User,NetId,Level,Gender,Lat,Lon,Last Active";
            List<string> reportLines = new List<string>();


            var tribes = arkPack.Tribes;
            if (tribeFilter != null && tribeFilter.Length > 0)
            {
                tribes = arkPack.Tribes.Where(t => t.TribeId.ToString() == tribeFilter || t.TribeFileName == tribeFilter).ToList();
            }
            if (discordMember != null)
            {
                var discordUser = playerManager.GetPlayers().FirstOrDefault(p => p.DiscordUsername.ToLower() == discordMember.Username.ToLower());
                if (discordUser != null)
                {

                    tribes = tribes.Where(t => t.Players.LongCount(p => p.Id == discordUser.ArkPlayerId) > 0).ToList();
                }
            }

            if (tribes.Count == 0)
            {
                await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("Unable to find any tribe data matching your filter."));
                return;
            }

            foreach (var tribe in tribes)
            {
                foreach (var player in tribe.Players)
                {

                    reportLines.Add($"{tribe.TribeId},{tribe.TribeName},{player.Id},{player.CharacterName},{player.Name},{player.NetworkId},{player.Level},{player.Gender},{player.Latitude.GetValueOrDefault(0).ToString("f1")},{player.Longitude.GetValueOrDefault(0).ToString("f1")},{player.LastActiveDateTime.Value.ToString() ?? "Unknown"}");

                }
            }


            string responseString = dataFormatter.FormatResponseTable(reportHeader, reportLines);

            var tmpFilename = Path.GetTempFileName();
            File.WriteAllText(tmpFilename, responseString);
            FileStream fileStream = new FileStream(tmpFilename, FileMode.Open, FileAccess.Read);

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("").AddFile("asvbot-arkplayers.txt", fileStream));
        }


        //ark-structures <filterText> <tribeId | tribeName | discordUser>
        /*
            TribeId, Tribe Name, Structure, Name, Lat, Lon, Inventory, Locked
        */
        [SlashCommand("ark-structures", "List player structures filtered by type and tribe.", false)]
        public async Task ListArkStructures(InteractionContext ctx, [Option("structFilter", "Structure type filter (optional)")] string structureType = "", [Option("tribeFilter", "Tribe Id or Tribe Name (Optional)")] string tribeFilter = "", [Option("discordUser", "Discord user filter [optional]")] DiscordUser discordMember = null)
        {
            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);


            string reportHeader = "Tribe Id,Tribe,Structure,Name,Ally In Range,Lat,Lon,Inventory,Locked";
            List<string> reportLines = new List<string>();


            var tribes = arkPack.Tribes;
            if (tribeFilter != null && tribeFilter.Length > 0)
            {
                tribes = arkPack.Tribes.Where(t => t.TribeId.ToString() == tribeFilter || t.TribeFileName == tribeFilter).ToList();
            }
            if (discordMember != null)
            {
                var discordUser = playerManager.GetPlayers().FirstOrDefault(p => p.DiscordUsername.ToLower() == discordMember.Username.ToLower());
                if (discordUser != null)
                {

                    tribes = tribes.Where(t => t.Players.LongCount(p => p.Id == discordUser.ArkPlayerId) > 0).ToList();
                }
            }

            if (tribes.Count == 0)
            {
                await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("Unable to find any tribe data matching your filter."));
                return;
            }


            List<ContentStructure> playerMatched = new List<ContentStructure>();

            foreach (var tribe in tribes)
            {
                foreach (var playerStructure in tribe.Structures.Where(s => s.ClassName.ToLower().Contains(structureType.ToLower())))
                {

                    playerMatched.Add(playerStructure);

                }
            }

            foreach (var playerStructure in playerMatched.OrderBy(o => o.ClassName).ThenBy(o => o.Latitude.GetValueOrDefault(0)).ThenBy(o => o.Longitude.GetValueOrDefault(0)))
            {
                string structureName = playerStructure.ClassName;
                var structureMap = classMaps.FirstOrDefault(c => c.ClassName.ToLower().Contains(playerStructure.ClassName.ToLower()));
                if (structureMap != null) structureName = structureMap.FriendlyName;

                string playerNamed = playerStructure.ClassName == playerStructure.DisplayName ? "" : playerStructure.DisplayName;

                bool hasInvent = playerStructure.Inventory != null && playerStructure.Inventory.Items != null && playerStructure.Inventory.Items.Count > 0;


                var tribe = tribes.First(t => t.TribeId == playerStructure.TargetingTeam);

                reportLines.Add($"{tribe.TribeId},{tribe.TribeName},{structureName},{playerNamed},{playerStructure.LastAllyInRangeTime.ToString()},{playerStructure.Latitude.GetValueOrDefault(0).ToString("f1")},{playerStructure.Longitude.GetValueOrDefault(0).ToString("f1")},{hasInvent},{playerStructure.IsLocked}");

            }

            string responseString = dataFormatter.FormatResponseTable(reportHeader, reportLines);

            var tmpFilename = Path.GetTempFileName();
            File.WriteAllText(tmpFilename, responseString);
            FileStream fileStream = new FileStream(tmpFilename, FileMode.Open, FileAccess.Read);

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("").AddFile("asvbot-arkstructures.txt", fileStream));
        }



        //ark-tames <filterText> <tribeId | tribeName | discordUser>
        /*
            Tribe Id, Tribe Name, Creature, Name, Level, 

        */

        [SlashCommand("ark-tames", "List player tames filtered by type and tribe.", false)]
        public async Task ListArkTames(InteractionContext ctx, [Option("creatureFilter", "Creature type filter (optional)")] string creatureType = "", [Option("tribeFilter", "Tribe Id or Tribe Name (Optional)")] string tribeFilter = "", [Option("discordUser", "Discord user filter [optional]")] DiscordUser discordMember = null)
        {
            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);

            var reportHeader = "Tribe Id,Tribe,Id, Creature,Name,Gender,Base,Level,Lat,Lon,HP0,Stam0,Melee0,Weight0,Speed0,Food0,Oxy0,Craft0,HP1,Stam1,Melee1,Weight1,Speed1,Food1,Oxy1,Craft1,Wandering,Mating,Neutered";

            List<string> reportLines = new List<string>();


            var tribes = arkPack.Tribes;
            if (tribeFilter != null && tribeFilter.Length > 0)
            {
                tribes = arkPack.Tribes.Where(t => t.TribeId.ToString() == tribeFilter || t.TribeFileName == tribeFilter).ToList();
            }
            if (discordMember != null)
            {
                var discordUser = playerManager.GetPlayers().FirstOrDefault(p => p.DiscordUsername.ToLower() == discordMember.Username.ToLower());
                if (discordUser != null)
                {

                    tribes = tribes.Where(t => t.Players.LongCount(p => p.Id == discordUser.ArkPlayerId) > 0).ToList();
                }
            }

            if (tribes.Count == 0)
            {
                await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("Unable to find any tribe data matching your filter."));
                return;
            }


            List<ContentTamedCreature> playerMatched = new List<ContentTamedCreature>();

            foreach (var tribe in tribes)
            {
                foreach (var playerTame in tribe.Tames.Where(s => s.ClassName.ToLower().Contains(creatureType.ToLower())))
                {

                    playerMatched.Add(playerTame);

                }
            }

            foreach (var playerTame in playerMatched.OrderBy(o => o.ClassName).ThenBy(o => o.Latitude.GetValueOrDefault(0)).ThenBy(o => o.Longitude.GetValueOrDefault(0)))
            {
                string creatureName = playerTame.ClassName;
                var structureMap = classMaps.FirstOrDefault(c => c.ClassName.ToLower().Contains(playerTame.ClassName.ToLower()));
                if (structureMap != null) creatureName = structureMap.FriendlyName;

                string playerNamed = playerTame.Name;

                bool hasInvent = playerTame.Inventory != null && playerTame.Inventory.Items != null && playerTame.Inventory.Items.Count > 0;

                //Tribe Id,Tribe,Creature,Name,Gender,Base,Level,Lat,Lon,HP0,Stam0,Melee0,Weight0,Speed0,Food0,Oxy0,Craft0,HP1,Stam1,Melee1,Weight1,Speed1,Food1,Oxy1,Craft1,Wandering,Mating,Neutered
                StringBuilder sbTame = new StringBuilder();
                sbTame.Append($"{playerTame.TargetingTeam}");
                sbTame.Append($",{playerTame.TribeName}");
                sbTame.Append($",{playerTame.DinoId}");
                sbTame.Append($",{creatureName}");
                sbTame.Append($",{playerTame.Name}");
                sbTame.Append($",{playerTame.Gender}");
                sbTame.Append($",{playerTame.BaseLevel}");
                sbTame.Append($",{playerTame.Level}");
                sbTame.Append($",{playerTame.Latitude.GetValueOrDefault(0).ToString("f1")}");
                sbTame.Append($",{playerTame.Longitude.GetValueOrDefault(0).ToString("f1")}");

                sbTame.Append($",{playerTame.BaseStats[0]}"); //hp
                sbTame.Append($",{playerTame.BaseStats[1]}"); //stam
                sbTame.Append($",{playerTame.BaseStats[8]}"); //melee
                sbTame.Append($",{playerTame.BaseStats[7]}"); //weight
                sbTame.Append($",{playerTame.BaseStats[9]}"); //speed
                sbTame.Append($",{playerTame.BaseStats[4]}"); //food
                sbTame.Append($",{playerTame.BaseStats[3]}"); //oxy
                sbTame.Append($",{playerTame.BaseStats[11]}"); //craft

                sbTame.Append($",{playerTame.TamedStats[0]}"); //hp
                sbTame.Append($",{playerTame.TamedStats[1]}"); //stam
                sbTame.Append($",{playerTame.TamedStats[8]}"); //melee
                sbTame.Append($",{playerTame.TamedStats[7]}"); //weight
                sbTame.Append($",{playerTame.TamedStats[9]}"); //speed
                sbTame.Append($",{playerTame.TamedStats[4]}"); //food
                sbTame.Append($",{playerTame.TamedStats[3]}"); //oxy
                sbTame.Append($",{playerTame.TamedStats[11]}"); //craft

                sbTame.Append($",{playerTame.IsWandering}");
                sbTame.Append($",{playerTame.IsMating}");
                sbTame.Append($",{playerTame.IsNeutered}");


                reportLines.Add(sbTame.ToString());
            }

            string responseString = dataFormatter.FormatResponseTable(reportHeader, reportLines);

            var tmpFilename = Path.GetTempFileName();
            File.WriteAllText(tmpFilename, responseString);
            FileStream fileStream = new FileStream(tmpFilename, FileMode.Open, FileAccess.Read);

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("").AddFile("asvbot-arktames.txt", fileStream));
        }



        //ark-items <filterText> <tribeId | tribeName | discordUser>
        [SlashCommand("ark-items", "List player items filtered by type and tribe.", false)]
        public async Task ListArkItems(InteractionContext ctx, [Option("itemFilter", "Item type filter (optional)")] string itemFilter = "", [Option("tribeFilter", "Tribe Id or Tribe Name (Optional)")] string tribeFilter = "", [Option("discordUser", "Discord user filter [optional]")] DiscordUser discordMember = null)
        {
            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);


            //"1065785058,PR,Player,Jr,47.4,71.0,Flak Gauntlets,3.7404695,1"

            var reportHeader = "Tribe Id,Tribe,Storage,Name,Lat,Lon,Item,Rating,Count";

            List<string> reportLines = new List<string>();


            var tribes = arkPack.Tribes;
            if (tribeFilter != null && tribeFilter.Length > 0)
            {
                tribes = arkPack.Tribes.Where(t => t.TribeId.ToString() == tribeFilter || t.TribeFileName == tribeFilter).ToList();
            }
            if (discordMember != null)
            {
                var discordUser = playerManager.GetPlayers().FirstOrDefault(p => p.DiscordUsername.ToLower() == discordMember.Username.ToLower());
                if (discordUser != null)
                {

                    tribes = tribes.Where(t => t.Players.LongCount(p => p.Id == discordUser.ArkPlayerId) > 0).ToList();
                }
            }

            if (tribes.Count == 0)
            {
                await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("Unable to find any tribe data matching your filter."));
                return;
            }


            List<Tuple<ContentTribe, string, string, float, float, ContentItem>> items = new List<Tuple<ContentTribe, string, string, float, float, ContentItem>>();

            foreach(var tribe in tribes)
            {
                if (tribe != null)
                {
                    var tribeStructures = tribe.Structures
                                            .Where(t =>
                                                        (t.Inventory != null && t.Inventory.Items != null && t.Inventory.Items.LongCount(i => !i.IsEngram & !i.IsBlueprint && i.ClassName.ToLower().Contains()) > 0)
                                            ).ToList();

                    if (tribeStructures != null)
                    {
                        foreach (var tribeStructure in tribeStructures)
                        {
                            string containerType = "Structure - ";
                            string containerName = tribeStructure.ClassName;
                            var classMap = classMaps.FirstOrDefault(c => c.ClassName.ToLower() == tribeStructure.ClassName.ToLower());
                            if (classMap != null) containerName = classMap.FriendlyName;
                            containerType = string.Concat(containerType, containerName);

                            string displayName = "";
                            if (tribeStructure.DisplayName != tribeStructure.ClassName) displayName = tribeStructure.DisplayName;

                            if (tribeStructure.Inventory != null && tribeStructure.Inventory.Items.Count > 0)
                            {
                                foreach (var matchItem in tribeStructure.Inventory.Items.Where(i => !i.IsEngram && !i.IsBlueprint && i.ClassName.ToLower().Contains(itemFilter.ToLower())))
                                {
                                    items.Add(new Tuple<ContentTribe, string, string, float, float, ContentItem>(tribe, containerType, displayName, tribeStructure.Latitude.GetValueOrDefault(0), tribeStructure.Longitude.GetValueOrDefault(0), matchItem));
                                }
                            }
                        }
                    }



                    var tribePlayers = tribe.Players.Where(p =>
                                                            p.Inventory != null
                                                            && p.Inventory.Items != null
                                                            && p.Inventory.Items.LongCount(
                                                                i => i.ClassName.ToLower().Contains(itemFilter.ToLower())
                                                                ) > 0);
                    if (tribePlayers != null)
                    {
                        foreach (var tribePlayer in tribePlayers)
                        {
                            string containerType = "Player";
                            string displayName = tribePlayer.CharacterName;
                            
                            if (tribePlayer.Inventory != null && tribePlayer.Inventory.Items.Count > 0)
                            {
                                foreach (var matchItem in tribePlayer.Inventory.Items.Where(i => !i.IsEngram && !i.IsBlueprint && i.ClassName.ToLower().Contains(itemFilter.ToLower())))
                                {
                                    items.Add(new Tuple<ContentTribe, string, string, float, float, ContentItem>(tribe, containerType, displayName, tribePlayer.Latitude.GetValueOrDefault(0), tribePlayer.Longitude.GetValueOrDefault(0), matchItem));
                                }
                            }
                        }


                    }
                        
                }
            }

            if (items.Count == 0)
            {
                await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("Unable to find any item data matching your filter(s)."));

                return;
            }

            foreach(var item in items.OrderBy(o => o.Item1.TribeName).ThenBy(o => o.Item2).ThenBy(o => o.Item3).ThenBy(o => o.Item4).ThenBy(o => o.Item5))
            {
                //Tribe Id,Tribe,Storage,Name,Lat,Lon,Item,Rating,Count
                string itemName = item.Item6.ClassName;
                var itemMap = classMaps.FirstOrDefault(c=>c.ClassName.ToLower() == item.Item6.ClassName.ToLower());
                if (itemMap != null) itemName = itemMap.FriendlyName;

                reportLines.Add($"{item.Item1.TribeId},{item.Item1.TribeName},{item.Item2},{item.Item3},{item.Item4.ToString("f1")},{item.Item5.ToString("f1")},{itemName},{item.Item6.Rating},{item.Item6.Quantity}");
            }


            string responseString = dataFormatter.FormatResponseTable(reportHeader, reportLines);

            var tmpFilename = Path.GetTempFileName();
            File.WriteAllText(tmpFilename, responseString);
            FileStream fileStream = new FileStream(tmpFilename, FileMode.Open, FileAccess.Read);

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent("").AddFile("asvbot-arkitems.txt", fileStream));


        }
    }
}
