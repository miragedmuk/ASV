using ASVPack.Extensions;
using NLog;
using SavegameToolkit;
using SavegameToolkit.Arrays;
using SavegameToolkit.Propertys;
using SavegameToolkit.Structs;
using SavegameToolkit.Types;
using SavegameToolkitAdditions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace ASVPack.Models
{
    [DataContract]
    public class ContentContainer
    {

        ILogger logWriter = LogManager.GetCurrentClassLogger();
        private ContentMapPack mapPack = new ContentMapPack();

        [DataMember] public ContentMap LoadedMap { get; set; } = new ContentMap();

        [DataMember] public string MapName { get; set; } = "";
        [DataMember] public List<ContentStructure> MapStructures { get; set; } = new List<ContentStructure>();
        [DataMember] public List<ContentWildCreature> WildCreatures { get; set; } = new List<ContentWildCreature>();
        [DataMember] public List<ContentTribe> Tribes { get; set; } = new List<ContentTribe>();
        [DataMember] public List<ContentDroppedItem> DroppedItems { get; set; } = new List<ContentDroppedItem>();
        [DataMember] public ContentLocalProfile LocalProfile { get; set; } = new ContentLocalProfile();
        [DataMember] public List<ContentLeaderboard> Leaderboards { get; set; } = new List<ContentLeaderboard>();
        [DataMember] public DateTime GameSaveTime { get; set; } = new DateTime();
        [DataMember] public float GameSeconds { get; set; } = 0;

        private void LoadDefaults()
        {
            try
            {
                logWriter = LogManager.GetCurrentClassLogger();
            }
            catch
            {

            }
            GameSaveTime = DateTime.MinValue;
            GameSeconds = 0;
            MapStructures = new List<ContentStructure>();
            WildCreatures = new List<ContentWildCreature>();
            Tribes = new List<ContentTribe>();
            DroppedItems = new List<ContentDroppedItem>();

        }

        public void LoadSaveGame(string saveFilename, string localProfileFilename, string clusterFolder)
        {
            ContentMap selectedMap = null;

            logWriter.Trace("BEGIN LoadSaveGame()");


            if (!File.Exists(saveFilename))
            {
                logWriter.Error($"LoadSaveGame failed - unable to find file: {saveFilename}");
                throw new FileNotFoundException();
            }


            LoadDefaults();

            long startTicks = DateTime.Now.Ticks;

            try
            {
                if (localProfileFilename.Length > 0 && File.Exists(localProfileFilename))
                {

                    logWriter.Info("Reading LocalProfile data...");
                    using (Stream streamProfile = new FileStream(localProfileFilename, FileMode.Open))
                    {
                        using (ArkArchive archiveProfile = new ArkArchive(streamProfile))
                        {
                            ArkLocalProfile arkProfile = new ArkLocalProfile();
                            arkProfile.ReadBinary(archiveProfile, ReadingOptions.Create().WithBuildComponentTree(true).WithDataFilesObjectMap(false).WithGameObjects(true).WithGameObjectProperties(true));
                            LocalProfile = new ContentLocalProfile(arkProfile);
                        }
                    }

                }

            }
            catch
            {
                //ignore, not really that bothered about LocalProfile, added bonus if it is read in.
            }


            




            logWriter.Info("Reading game save data...");
            try
            {
                List<ContentTribe> tribeContentList = new List<ContentTribe>();

                GameObjectContainer objectContainer = null;
                GameSaveTime = new FileInfo(saveFilename).LastWriteTimeUtc.ToLocalTime();


                logWriter.Debug($"Reading game save data: {saveFilename}");

                using (Stream stream = new MemoryStream(File.ReadAllBytes(saveFilename)))
                {
                    using (ArkArchive archive = new ArkArchive(stream))
                    {

                        ArkSavegame arkSavegame = new ArkSavegame();

                        arkSavegame.ReadBinary(archive, ReadingOptions.Create()
                                .WithThreadCount(int.MaxValue)
                                .WithStoredCreatures(true)
                                .WithDataFiles(true)
                                .WithEmbeddedData(false)
                                .WithDataFilesObjectMap(false)
                                .WithBuildComponentTree(true));



                        if (!arkSavegame.HibernationEntries.Any())
                        {
                            objectContainer = arkSavegame;
                            GameSeconds = arkSavegame.GameTime;
                        }
                        else
                        {
                            List<GameObject> combinedObjects = arkSavegame.Objects;

                            foreach (HibernationEntry entry in arkSavegame.HibernationEntries)
                            {
                                ObjectCollector collector = new ObjectCollector(entry, 1);
                                combinedObjects.AddRange(collector.Remap(combinedObjects.Count));
                            }

                            objectContainer = new GameObjectContainer(combinedObjects);
                            GameSeconds = arkSavegame.GameTime;
                        }

                        //get map name from .ark file data
                        logWriter.Debug($"Reading map name from: {saveFilename}");
                        MapName = arkSavegame.DataFiles[0];
                        logWriter.Debug($"Map name returned: {MapName}");

                        logWriter.Debug($"Loading map location data for: {MapName}.ark");
                        selectedMap = mapPack.GetMap($"{MapName}.ark");
                        LoadedMap = selectedMap;
                        if (selectedMap != null)
                        {
                            logWriter.Debug($"Map location data loaded for: {selectedMap.MapName}");
                        }
                        else
                        {
                            logWriter.Debug($"Failed to load location data for: {MapName}.ark");
                            return;
                        }

                        long saveLoadTime = DateTime.Now.Ticks;
                        TimeSpan timeTaken = TimeSpan.FromTicks(saveLoadTime - startTicks);
                        logWriter.Info($"Game data loaded in: {timeTaken.ToString(@"mm\:ss")}.");


                        logWriter.Info("Reading mission leaderboard data...");
                        List<ContentLeaderboard> leaderboardList = new List<ContentLeaderboard>();

                        var testGameMode = objectContainer.FirstOrDefault(x => x.ClassString == "TestGameMode_C");
                        if (testGameMode != null)
                        {
                            //try find leaderboards
                            var leaderBoardContainer = testGameMode.GetTypedProperty<PropertyStruct>("LeaderboardContainer");
                            if (leaderBoardContainer != null)
                            {
                                var leaderBoardContainerProperties = leaderBoardContainer.Value as StructPropertyList;
                                var leaderBoards = leaderBoardContainerProperties.GetTypedProperty<PropertyArray>("Leaderboards");
                                foreach (StructPropertyList leaderBoard in leaderBoards.Value as ArkArrayStruct)
                                {

                                    string fullTag = leaderBoard.GetTypedProperty<PropertyName>("MissionTag").Value.Name;

                                    ContentLeaderboard board = new ContentLeaderboard()
                                    {
                                        FullTag = fullTag,
                                        MissionTag = fullTag.Substring(fullTag.LastIndexOf(".") + 1),
                                        Scores = new List<ContentMissionScore>()
                                    };

                                    var scoreRows = leaderBoard.GetTypedProperty<PropertyArray>("Rows");
                                    if (scoreRows != null)
                                    {
                                        ArkArrayStruct rows = scoreRows.Value as ArkArrayStruct;
                                        foreach (StructPropertyList rowProperties in rows)
                                        {
                                            int tribeId = rowProperties.GetPropertyValue<int>("TribeId");
                                            long.TryParse(rowProperties.GetPropertyValue<string>("PlayerNetId"), out long dataId);
                                            string playerName = rowProperties.GetPropertyValue<string>("StringValue");

                                            float floatValue = rowProperties.GetPropertyValue<float>("FloatValue");
                                            int intValue = rowProperties.GetPropertyValue<int>("IntValue");

                                            string stringScore = floatValue.ToString($"f{intValue}");
                                            decimal.TryParse(stringScore, out decimal scoreValue);

                                            board.Scores.Add(new ContentMissionScore()
                                            {
                                                FullTag = fullTag,
                                                MissionTag = fullTag.Substring(fullTag.LastIndexOf(".") + 1),
                                                NetworkId = dataId,
                                                TargetingTeam = tribeId,
                                                PlayerName = playerName,
                                                HighScore = scoreValue
                                            });
                                        }
                                    }

                                    leaderboardList.Add(board);
                                }

                                Leaderboards = leaderboardList;

                            }
                        }



                        var filePath = Path.GetDirectoryName(saveFilename);
                        long profileStart = DateTime.Now.Ticks;
                        logWriter.Info("Reading .arkprofile(s)");
                        ConcurrentBag<ContentPlayer> fileProfiles = new ConcurrentBag<ContentPlayer>();
                        var profileFilenames = Directory.GetFiles(filePath, "*.arkprofile");
                        profileFilenames.AsParallel().ForAll(x =>
                        {
                            try
                            {
                                logWriter.Debug($"Reading profile data: {x}");
                                using (Stream streamProfile = new FileStream(x, FileMode.Open))
                                {


                                    using (ArkArchive archiveProfile = new ArkArchive(streamProfile))
                                    {
                                        ArkProfile arkProfile = new ArkProfile();
                                        arkProfile.ReadBinary(archiveProfile, ReadingOptions.Create().WithBuildComponentTree(false).WithDataFilesObjectMap(false).WithGameObjects(true).WithGameObjectProperties(true));

                                        if (arkProfile.Profile != null)
                                        {
                                            string profileMapName = arkProfile.Profile.Names[3].Name.ToLower();
                                            logWriter.Debug($"Profile map identified as: {profileMapName}");
                                            if (profileMapName == MapName.ToLower())
                                            {
                                                logWriter.Debug($"Converting to ContentPlayer: {x}");
                                                ContentPlayer contentPlayer = arkProfile.AsPlayer();
                                                if (contentPlayer.Id != 0)
                                                {

                                                    contentPlayer.LastActiveDateTime = GetApproxDateTimeOf(contentPlayer.LastTimeInGame);



                                                    fileProfiles.Add(contentPlayer);
                                                }

                                            }
                                        }


                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                logWriter.Debug($"Failed to read profile data: {x}");
                            }
                        });
                        long profileEnd = DateTime.Now.Ticks;





                        ConcurrentBag<ContentTribe> fileTribes = new ConcurrentBag<ContentTribe>();
                        //add fake tribes for abandoned and unclaimed
                        fileTribes.Add(new ContentTribe()
                        {
                            IsSolo = true,
                            TribeId = 2_000_000_000,
                            TribeName = "[ASV Unclaimed]"
                        });

                        fileTribes.Add(new ContentTribe()
                        {
                            IsSolo = true,
                            TribeId = int.MinValue,
                            TribeName = "[ASV Abandoned]"
                        });

                        long tribeStart = DateTime.Now.Ticks;
                        logWriter.Info("Reading .arktribe(s)");

                        var tribeFilenames = Directory.GetFiles(filePath, "*.arktribe");
                        tribeFilenames.AsParallel().ForAll(x =>
                        {
                            try
                            {
                                logWriter.Debug($"Reading tribe data: {x}");
                                using (Stream streamTribe = new FileStream(x, FileMode.Open))
                                {


                                    using (ArkArchive archiveTribe = new ArkArchive(streamTribe))
                                    {
                                        ArkTribe arkTribe = new ArkTribe();
                                        arkTribe.ReadBinary(archiveTribe, ReadingOptions.Create().WithBuildComponentTree(false).WithDataFilesObjectMap(false).WithGameObjects(true).WithGameObjectProperties(true));

                                        logWriter.Debug($"Converting to ContentTribe for: {x}");
                                        var contentTribe = arkTribe.Tribe.AsTribe();
                                        if (contentTribe != null && contentTribe.TribeName != null)
                                        {
                                            contentTribe.TribeFileDate = File.GetLastWriteTimeUtc(x).ToLocalTime();
                                            contentTribe.HasGameFile = true;
                                            fileTribes.Add(contentTribe);

                                        }
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                logWriter.Debug($"Failed to read tribe data: {x}");
                            }

                        });




                        long tribeEnd = DateTime.Now.Ticks;


                        logWriter.Info($"Allocating players to tribes");

                        //allocate players to tribes
                        fileProfiles.AsParallel().ForAll(p =>
                        {
                            var playerTribe = fileTribes.FirstOrDefault(t => t.TribeId == (long)p.TargetingTeam);
                            if (playerTribe == null)
                            {
                                playerTribe = new ContentTribe()
                                {
                                    IsSolo = true,
                                    HasGameFile = false,
                                    TribeId = p.Id,
                                    TribeName = $"Tribe of {p.CharacterName}"
                                };

                                fileTribes.Add(playerTribe);
                            }


                            playerTribe.Players.Add(p);
                        });
                        long allocationEnd = DateTime.Now.Ticks;


                        long structureStart = DateTime.Now.Ticks;

                        logWriter.Info($"Identifying map structures");
                        //map structures we care about
                        MapStructures = objectContainer.Objects.Where(x =>
                            x.Location != null
                            && x.GetPropertyValue<int?>("TargetingTeam") == null
                            && (x.ClassString.StartsWith("TributeTerminal_")
                            || x.ClassString.Contains("CityTerminal_")
                            || x.ClassString.StartsWith("PrimalItem_PowerNodeCharge")
                            || x.ClassString.StartsWith("BeaverDam_C")
                            || x.ClassString.StartsWith("WyvernNest_")
                            || x.ClassString.StartsWith("RockDrakeNest_C")
                            || x.ClassString.StartsWith("DeinonychusNest_C")
                            || x.ClassString.StartsWith("CherufeNest_C")
                            || x.ClassString.StartsWith("OilVein_")
                            || x.ClassString.StartsWith("WaterVein_")
                            || x.ClassString.StartsWith("GasVein_")
                            || x.ClassString.StartsWith("ArtifactCrate_")
                            || x.ClassString.StartsWith("Structure_PlantSpeciesZ")
                            || x.ClassString.StartsWith("BeeHive_C")



                            )
                        ).Select(s =>
                        {
                            ContentStructure structure = s.AsStructure();

                            structure.Latitude = (float)LoadedMap.LatShift + (structure.Y / (float)LoadedMap.LatDiv);
                            structure.Longitude = (float)LoadedMap.LonShift + (structure.X / (float)LoadedMap.LonDiv);

                            ConcurrentBag<ContentItem> inventoryItems = new ConcurrentBag<ContentItem>();

                            //check for inventory
                            logWriter.Debug($"Determining if structure has inventory: {s.ClassString}");
                            ObjectReference inventoryRef = s.GetPropertyValue<ObjectReference>("MyInventoryComponent");
                            if (inventoryRef != null)
                            {
                                logWriter.Debug($"Populating structure inventory: {s.ClassString}");
                                structure.Inventory = new ContentInventory();


                                objectContainer.TryGetValue(inventoryRef.ObjectId, out GameObject inventory);
                                if (inventory != null)
                                {
                                    //inventory found, add items
                                    PropertyArray inventoryItemsArray = inventory.GetTypedProperty<PropertyArray>("InventoryItems");
                                    if (inventoryItemsArray != null)
                                    {
                                        ArkArrayObjectReference objectReferences = (ArkArrayObjectReference)inventoryItemsArray.Value;

                                        Parallel.ForEach(objectReferences, objectReference =>
                                        {
                                            objectContainer.TryGetValue(objectReference.ObjectId, out GameObject itemObject);
                                            if (itemObject != null)
                                            {
                                                var item = itemObject.AsItem();

                                                if (!item.IsEngram & !item.IsBlueprint)
                                                {

                                                    inventoryItems.Add(item);
                                                }
                                            }
                                        });
                                    }

                                }
                            }
                            else
                            {
                                //no inventory component, check for any "egg" within range of nest location
                                if (s.ClassName.Name.Contains("Nest"))
                                {
                                    logWriter.Debug($"Finding nearby eggs for: {s.ClassString}");
                                    var eggInRange = objectContainer.Objects.FirstOrDefault(x =>
                                        x.ClassName.Name.Contains("Egg")
                                        && x.Location != null
                                        && (((x.Location.X > s.Location.X) ? x.Location.X - s.Location.X : s.Location.X - x.Location.X) < 1500)
                                        && (((x.Location.Z > s.Location.Z) ? x.Location.Z - s.Location.Z : s.Location.Z - x.Location.Z) < 1500)
                                    );

                                    if (eggInRange != null)
                                    {
                                        logWriter.Debug($"Egg found: {eggInRange.ClassString} for {s.ClassString}");
                                        inventoryItems.Add(new ContentItem()
                                        {
                                            ClassName = eggInRange.ClassString,
                                            CustomName = eggInRange.GetPropertyValue<string>("DroppedByName"),
                                            Quantity = 1
                                        });
                                    }
                                }


                            }
                            if (inventoryItems.Count > 0) structure.Inventory.Items.AddRange(inventoryItems.ToArray());



                            return structure;
                        }).Where(s => s != null).ToList();

                        long structureEnd = DateTime.Now.Ticks;
                        var structureTime = TimeSpan.FromTicks(structureEnd - structureStart);
                        logWriter.Info($"Structures loaded in: {structureTime.ToString(@"mm\:ss")}.");

                        long wildStart = DateTime.Now.Ticks;


                        logWriter.Info($"Identifying wild creatures");
                        //wilds
                        WildCreatures = objectContainer.Objects.AsParallel().Where(x => x.IsWild())
                            .Select(x =>
                            {
                                logWriter.Debug($"Determining character status for: {x.ClassString}");
                                ObjectReference statusRef = x.GetPropertyValue<ObjectReference>("MyCharacterStatusComponent") ?? x.GetPropertyValue<ObjectReference>("MyDinoStatusComponent");
                                if (statusRef != null)
                                {
                                    logWriter.Debug($"Character status found for: {x.ClassString}");
                                    objectContainer.TryGetValue(statusRef.ObjectId, out GameObject statusObject);
                                                                        ContentWildCreature wild = x.AsWildCreature(statusObject);

                                                                        //stryder rigs
                                                                        if (x.ClassString == "TekStrider_Character_BP_C")
                                                                        {
                                                                            ObjectReference inventoryRef = x.GetPropertyValue<ObjectReference>("MyInventoryComponent");
                                    if (inventoryRef != null)
                                    {
                                    var inventComp = objectContainer[inventoryRef.ObjectId];
                                    if (inventComp != null)
                                            {
                                                PropertyArray equippedItemsArray = inventComp.GetTypedProperty<PropertyArray>("EquippedItems");

                                                if (equippedItemsArray != null)
                                                {
                                                    ArkArrayObjectReference objectReferences = (ArkArrayObjectReference)equippedItemsArray.Value;
                                                    if (objectReferences != null && objectReferences.Count >= 2)
                                                    {
                                                        objectContainer.TryGetValue(objectReferences[0].ObjectId, out GameObject rig1Object);
                                                        var itemRig1 = rig1Object.AsItem();
                                                        wild.Rig1 = itemRig1.ClassName;

                                                        objectContainer.TryGetValue(objectReferences[1].ObjectId, out GameObject rig2Object);
                                                        var itemRig2 = rig2Object.AsItem();
                                                        wild.Rig2 = itemRig2.ClassName;
                                                    }
                                                }
                                            }

                                        }
                                    }

                                    wild.Latitude = (float)LoadedMap.LatShift + (wild.Y / (float)LoadedMap.LatDiv);
                                    wild.Longitude = (float)LoadedMap.LonShift + (wild.X / (float)LoadedMap.LonDiv);


                                    return wild;
                                
                                }
                                else
                                {

                                    return null;
                                }

                            }).Where(x => x != null).Distinct().ToList();



                        long wildEnd = DateTime.Now.Ticks;
                        var wildTime = TimeSpan.FromTicks(wildEnd - wildStart);
                        logWriter.Info($"Wilds loaded in: {wildTime.ToString(@"mm\:ss")}.");

                        var parallelContainer = objectContainer.AsParallel();

                        logWriter.Info($"Identifying tamed creatures");
                        var allTames = parallelContainer
                                        .Where(x => x.IsTamed()) //exclude rafts.. no idea why these are "creatures"
                                        .GroupBy(x => (long)x.GetPropertyValue<int>("TargetingTeam")).Select(x => new { TribeId = x.Key, TribeName = x.First().GetPropertyValue<string>("TribeName") ?? x.First().GetPropertyValue<string>("TamerString"), Tames = x.ToList() }).ToList();



                        logWriter.Debug($"Identifying player structures");
                        var playerStructures = parallelContainer.Where(x => x.IsStructure() && x.GetPropertyValue<int>("TargetingTeam") >= 50_000).GroupBy(x => x.Names[0]).Select(s => s.First()).ToList();

                        var tribeStructures = playerStructures
                                                    .GroupBy(x => new { TribeId = x.GetPropertyValue<int>("TargetingTeam"), TribeName = x.GetPropertyValue<string>("OwnerName") ?? x.GetPropertyValue<string>("TamerString") })
                                                    .Select(x => new { TribeId = x.Key.TribeId, TribeName = x.Key.TribeName, Structures = x.ToList() })
                                                    .ToList();


                        
                        //player and tribe data
                        long tribeLoadStart = DateTime.Now.Ticks;
                        logWriter.Debug($"Identifying in-game player data");
                        var gamePlayers = parallelContainer.Where(o => o.IsPlayer() & !o.HasAnyProperty("MyDeathHarvestingComponent")).GroupBy(x => x.GetPropertyValue<long>("LinkedPlayerDataID")).Select(x => x.First()).ToList();
                        var tribesAndPlayers = gamePlayers.GroupBy(x => x.GetPropertyValue<int>("TargetingTeam")).ToList();

                        logWriter.Debug($"Identifying in-game players with no .arkprofile");

                        var abandonedGamePlayers = tribesAndPlayers.Where(x => !fileTribes.Any(t => t.TribeId == (long)x.Key) & !fileProfiles.Any(p => p.Id == (long)x.Key)).ToList();
                        if (abandonedGamePlayers != null && abandonedGamePlayers.Count > 0)
                        {
                            abandonedGamePlayers.AsParallel().ForAll(abandonedTribe =>
                            //foreach(var abandonedTribe in abandonedGamePlayers)
                            {
                                var abandonedPlayers = abandonedTribe.ToList();
                                var newTribe = new ContentTribe()
                                {
                                    IsSolo = abandonedPlayers.Count == 1,
                                    HasGameFile = false,
                                    TribeId = abandonedTribe.Key,
                                    TribeName = abandonedTribe.First().GetPropertyValue<string>("TribeName") ?? "Tribe of " + abandonedTribe.First().GetPropertyValue<string>("PlayerName")
                                };

                                abandonedPlayers.Select(x => x.AsPlayer(x.CharacterStatusComponent())).ToList().ForEach(x =>
                                {
                                    if (x.Id != 0)
                                    {
                                        newTribe.Players.Add(x);
                                    }
                                });

                                fileTribes.Add(newTribe);
                            }
                            );
                        }



                        logWriter.Debug($"Identifying in-game missing tribes from player structures");



                        //attempt to get missing tribe data from structures
                        var missingStructureTribes = tribeStructures.AsParallel()
                            .Where(x => !fileTribes.Any(t => t.TribeId == x.TribeId))
                            .GroupBy(x => x.TribeId)
                            .Select(x => x.First())
                            .ToList();

                        if (missingStructureTribes != null && missingStructureTribes.Count > 0)
                        {
                            logWriter.Debug($"Identified player structure tribes: {missingStructureTribes.Count}");
                            missingStructureTribes.ForEach(tribe =>
                            {

                                fileTribes.Add(new ContentTribe()
                                {
                                    TribeId = tribe.TribeId,
                                    TribeName = tribe.TribeName,
                                    HasGameFile = false
                                });
                            });

                        }


                        logWriter.Debug($"Identifying in-game tribes from tames");


                        //attempt to get missing tribe data from tames
                        var missingTameTribes = allTames
                            .Where(x => !fileTribes.Any(t => t.TribeId == x.TribeId))
                            .ToList();

                        if (missingTameTribes != null && missingTameTribes.Count > 0)
                        {
                            logWriter.Debug($"Identified tame tribes: {missingStructureTribes.Count}");

                            missingTameTribes.ForEach(tribe =>
                            {


                                //we know there's no .arktribe
                                fileTribes.Add(new ContentTribe()
                                {
                                    TribeId = tribe.TribeId,
                                    TribeName = tribe.TribeName,
                                    HasGameFile = false
                                });

                            });
                        }


                        logWriter.Debug($"Populating player data");
                        //load inventories, locations etc.

                        fileTribes.Where(x => x.Players.Count > 0).AsParallel().ForAll(fileTribe =>
                        //foreach(var fileTribe in fileTribes.Where(x=>x.Players.Count > 0))
                        {
                            var tribePlayers = fileTribe.Players;

                            tribePlayers.AsParallel().ForAll(player =>
                            //foreach (var player in tribePlayers)
                            {

                                GameObject arkPlayer = gamePlayers.FirstOrDefault(x => x.GetPropertyValue<long>("LinkedPlayerDataID") == player.Id);

                                if (arkPlayer != null)
                                {
                                    ObjectReference statusRef = arkPlayer.GetPropertyValue<ObjectReference>("MyCharacterStatusComponent");
                                    objectContainer.TryGetValue(statusRef.ObjectId, out GameObject playerStatus);
                                    ContentPlayer contentPlayer = arkPlayer.AsPlayer(playerStatus);
                                    player.X = contentPlayer.X;
                                    player.Y = contentPlayer.Y;
                                    player.Z = contentPlayer.Z;
                                    player.Latitude = (float)LoadedMap.LatShift + (player.Y / (float)LoadedMap.LatDiv);
                                    player.Longitude = (float)LoadedMap.LonShift + (player.X / (float)LoadedMap.LonDiv);



                                    player.LastTimeInGame = contentPlayer.LastTimeInGame;
                                    player.LastActiveDateTime = GetApproxDateTimeOf(player.LastTimeInGame);
                                    player.Gender = arkPlayer.ClassName.Name.Contains("Female") ? "Female" : "Male";
                                    player.Level = contentPlayer.Level;
                                    player.Stats = contentPlayer.Stats;

                                    logWriter.Debug($"Retrieving player inventory: {player.Id} - {player.CharacterName}");
                                    if (arkPlayer.GetPropertyValue<ObjectReference>("MyInventoryComponent") != null)
                                    {
                                        int inventoryRefId = arkPlayer.GetPropertyValue<ObjectReference>("MyInventoryComponent").ObjectId;
                                        objectContainer.TryGetValue(inventoryRefId, out GameObject inventoryComponent);
                                        ConcurrentBag<ContentItem> inventoryItems = new ConcurrentBag<ContentItem>();
                                        ConcurrentBag<ContentItem> engramItems = new ConcurrentBag<ContentItem>();
                                        if (inventoryComponent != null)
                                        {
                                            PropertyArray inventoryItemsArray = inventoryComponent.GetTypedProperty<PropertyArray>("InventoryItems");
                                            if (inventoryItemsArray != null)
                                            {
                                                ArkArrayObjectReference objectReferences = (ArkArrayObjectReference)inventoryItemsArray.Value;

                                                Parallel.ForEach(objectReferences, objectReference =>
                                                //foreach (var objectReference in objectReferences)
                                                {
                                                    objectContainer.TryGetValue(objectReference.ObjectId, out GameObject itemObject);
                                                    if (itemObject != null)
                                                    {
                                                        var item = itemObject.AsItem();
                                                        if (!item.IsEngram)
                                                        {

                                                            inventoryItems.Add(item);

                                                        }
                                                    }
                                                }
                                                );
                                            }


                                            PropertyArray equippedItemsArray = inventoryComponent.GetTypedProperty<PropertyArray>("EquippedItems");

                                            if (equippedItemsArray != null)
                                            {
                                                ArkArrayObjectReference objectReferences = (ArkArrayObjectReference)equippedItemsArray.Value;
                                                Parallel.ForEach(objectReferences, objectReference =>
                                                //foreach (var objectReference in objectReferences)
                                                {
                                                    objectContainer.TryGetValue(objectReference.ObjectId, out GameObject itemObject);
                                                    if (itemObject != null)
                                                    {
                                                        var item = itemObject.AsItem();
                                                        if (!item.IsEngram)
                                                        {

                                                            inventoryItems.Add(item);
                                                        }
                                                    }
                                                }
                                                );
                                            }

                                        }



                                        player.Inventory = new ContentInventory() { Items = inventoryItems.ToList() };

                                    }
                                }

                            }
                            );
                        }
                        );


                        long tribeLoadEnd = DateTime.Now.Ticks;
                        var tribeLoadTime = TimeSpan.FromTicks(tribeLoadEnd - tribeLoadStart);
                        logWriter.Info($"Tribe players loaded in: {tribeLoadTime.ToString(@"mm\:ss")}.");


                        logWriter.Debug($"Populating tamed creature inventories");

                        Parallel.ForEach(allTames.SelectMany(x => x.Tames), x =>
                        //foreach (GameObject x in allTames)
                        {
                            //find appropriate tribe to add to
                            var teamId = x.GetPropertyValue<int>("TargetingTeam");
                            var tribe = fileTribes.FirstOrDefault(t => t.TribeId == teamId) ?? fileTribes.FirstOrDefault(t => t.TribeId == int.MinValue); //tribe or abandoned

                            logWriter.Debug($"Determining character status for: {x.ClassString}");
                            ObjectReference statusRef = x.GetPropertyValue<ObjectReference>("MyCharacterStatusComponent") ?? x.GetPropertyValue<ObjectReference>("MyDinoStatusComponent");
                            if (statusRef != null)
                            {
                                objectContainer.TryGetValue(statusRef.ObjectId, out GameObject statusObject);

                                logWriter.Debug($"Converting to ContentTamedCreature: {x.ClassString}");
                                ContentTamedCreature creature = x.AsTamedCreature(statusObject);
                                creature.Latitude = (float)LoadedMap.LatShift + (creature.Y / (float)LoadedMap.LatDiv);
                                creature.Longitude = (float)LoadedMap.LonShift + (creature.X / (float)LoadedMap.LonDiv);
                                creature.TamedAtDateTime = GetApproxDateTimeOf(creature.TamedTimeInGame);
                                creature.LastAllyInRangeTime = GetApproxDateTimeOf(creature.LastAllyInRangeTimeInGame);

                                //get inventory items
                                ConcurrentBag<ContentItem> inventoryItems = new ConcurrentBag<ContentItem>();

                                logWriter.Debug($"Determining inventory status for: {creature.Id} - {creature.Name}");


                                if (x.GetPropertyValue<ObjectReference>("MyInventoryComponent") != null)
                                {


                                    logWriter.Debug($"Retrieving inventory for: {creature.Id} - {creature.Name}");

                                    int inventoryRefId = x.GetPropertyValue<ObjectReference>("MyInventoryComponent").ObjectId;
                                    objectContainer.TryGetValue(inventoryRefId, out GameObject inventoryComponent);

                                    PropertyArray inventoryItemsArray = inventoryComponent.GetTypedProperty<PropertyArray>("InventoryItems");
                                    if (inventoryItemsArray != null)
{
                                        ArkArrayObjectReference objectReferences = (ArkArrayObjectReference)inventoryItemsArray.Value;

                                        Parallel.ForEach(objectReferences, objectReference =>
{
                                            objectContainer.TryGetValue(objectReference.ObjectId, out GameObject itemObject);
                                            if (itemObject != null)
                                            {
                                                var item = itemObject.AsItem();
                                                if (!item.IsEngram)
                                                {

                                                    inventoryItems.Add(item);
                                                }
                                            }
                                        });





                                    }


                                    PropertyArray equippedItemsArray = inventoryComponent.GetTypedProperty<PropertyArray>("EquippedItems");
                                    if (equippedItemsArray != null)
                                    {
                                        ArkArrayObjectReference equippedReferences = (ArkArrayObjectReference)equippedItemsArray.Value;

                                        if (equippedReferences != null)
                                        {

                                            if (x.ClassString == "TekStrider_Character_BP_C")
                                            {
                                                objectContainer.TryGetValue(equippedReferences[0].ObjectId, out GameObject rig1Object);
                                                var itemRig1 = rig1Object.AsItem();
                                                creature.Rig1 = itemRig1.ClassName;

                                                objectContainer.TryGetValue(equippedReferences[1].ObjectId, out GameObject rig2Object);
                                                var itemRig2 = rig2Object.AsItem();
                                                creature.Rig2 = itemRig2.ClassName;
                                            }
                                            else
                                            {
                                                Parallel.ForEach(equippedReferences, objectReference =>
                                                //foreach (var objectReference in objectReferences)
                                                {
                                                    objectContainer.TryGetValue(objectReference.ObjectId, out GameObject itemObject);
                                                    if (itemObject != null)
                                                    {
                                                        var item = itemObject.AsItem();
                                                        if (!item.IsEngram)
                                                        {

                                                            inventoryItems.Add(item);
                                                        }
                                                    }
                                                }
                                                );
                                            }
                                        }


                                    }




                                    creature.Inventory = new ContentInventory() { Items = inventoryItems.ToList() };
                                }

                                tribe.Tames.Add(creature);

                            }

                        }
                        );

                        long tameLoadEnd = DateTime.Now.Ticks;
                        var tameLoadTime = TimeSpan.FromTicks(tameLoadEnd - tribeLoadEnd);
                        logWriter.Info($"Tames loaded in: {tameLoadTime.ToString(@"mm\:ss")}.");

                        //TODO:// add unclaimed babies, with living parent belonging to tribe
                        var unclaimedTribe = fileTribes.First(x => x.TribeId == int.MinValue);
                        var unclaimedBabies = unclaimedTribe.Tames.Where(x => x.IsBaby).ToList();
                        if (unclaimedBabies != null && unclaimedBabies.Count > 0)
                        {
                            foreach (var baby in unclaimedBabies)
                            {
                                if (baby.MotherId.HasValue)
                                {
                                    objectContainer.TryGetValue((int)baby.MotherId.Value, out GameObject babyMamma);

                                    if (babyMamma != null)
                                    {
                                        //find mothers tribe
                                        var mammaTribe = fileTribes.FirstOrDefault(x => x.TribeId == babyMamma.GetPropertyValue<int>("TargetingTeam"));
                                        if (mammaTribe != null)
                                        {
                                            baby.TargetingTeam = mammaTribe.TribeId;

                                            //add to mammaTribe - prepend [Unclaimed] 
                                            baby.Name = $"[Unclaimed] {baby.Name}";
                                            mammaTribe.Tames.Add(baby);

                                            //remove from unclaimed tribe
                                            unclaimedTribe.Tames.ToList().Remove(baby);
                                        }

                                    }

                                }
                            }
                        }

                        //structures
                        logWriter.Debug($"Populating player structure inventories");

                        //Parallel.ForEach(tribeStructures.SelectMany(x => x.Structures), x =>
                        foreach(var x in tribeStructures.SelectMany(x=>x.Structures))
                        {

                            var teamId = x.GetPropertyValue<int>("TargetingTeam");
                            var tribe = fileTribes.FirstOrDefault(t => t.TribeId == teamId) ?? fileTribes.FirstOrDefault(t => t.TribeId == int.MinValue); //tribe or abandoned

                            logWriter.Debug($"Converting to ContentStructure: {x.ClassString}");

                            ContentStructure structure = x.AsStructure();
                            ConcurrentBag<ContentItem> inventoryItems = new ConcurrentBag<ContentItem>();

                            structure.Latitude = (float)LoadedMap.LatShift + (structure.Y / (float)LoadedMap.LatDiv);
                            structure.Longitude = (float)LoadedMap.LonShift + (structure.X / (float)LoadedMap.LonDiv);


                            structure.CreatedDateTime = GetApproxDateTimeOf(structure.CreatedTimeInGame);
                            structure.LastAllyInRangeTime = GetApproxDateTimeOf(structure.LastAllyInRangeTimeInGame);

                            //inventory
                            logWriter.Debug($"Determining inventory status for: {structure.ClassName}");
                            if (x.GetPropertyValue<ObjectReference>("MyInventoryComponent") != null)
                            {
                                logWriter.Debug($"Retrieving inventory for: {structure.ClassName}");
                                int inventoryRefId = x.GetPropertyValue<ObjectReference>("MyInventoryComponent").ObjectId;
                                objectContainer.TryGetValue(inventoryRefId, out GameObject inventoryComponent);
                                if (inventoryComponent != null)
                                {
                                    PropertyArray inventoryItemsArray = inventoryComponent.GetTypedProperty<PropertyArray>("InventoryItems");
                                    if (inventoryItemsArray != null)
{
                                        ArkArrayObjectReference objectReferences = (ArkArrayObjectReference)inventoryItemsArray.Value;

                                        Parallel.ForEach(objectReferences, objectReference =>
{
                                            objectContainer.TryGetValue(objectReference.ObjectId, out GameObject itemObject);
                                            if (itemObject != null)
                                            {
                                                var item = itemObject.AsItem();
                                                if (!item.IsEngram)
                                                {

                                                    inventoryItems.Add(item);
                                                }
                                            }
                                        });
                                    }


                                    PropertyArray equippedItemsArray = inventoryComponent.GetTypedProperty<PropertyArray>("EquippedItems");
                                    if (equippedItemsArray != null)
                                    {
                                        ArkArrayObjectReference objectReferences = (ArkArrayObjectReference)equippedItemsArray.Value;
                                        Parallel.ForEach(objectReferences, objectReference =>
                                        {
                                            objectContainer.TryGetValue(objectReference.ObjectId, out GameObject itemObject);
                                            if (itemObject != null)
                                            {
                                                var item = itemObject.AsItem();
                                                if (!item.IsEngram)
                                                {

                                                    inventoryItems.Add(item);
                                                }
                                            }
                                        });
                                    }
                                }




                                structure.Inventory = new ContentInventory() { Items = inventoryItems.ToList() };
                            }
                            if (!tribe.Structures.Contains(structure)) tribe.Structures.Add(structure);
                            

                        }//);
                        

                        if (fileTribes.Count > 0) Tribes.AddRange(fileTribes.ToList());

                        long structureLoadEnd = DateTime.Now.Ticks;
                        var structureLoadTime = TimeSpan.FromTicks(structureLoadEnd - tameLoadEnd);
                        logWriter.Info($"Player structures loaded in: {structureLoadTime.ToString(@"mm\:ss")}.");

                        //dropped 
                        logWriter.Debug($"Identifying dropped items");
                        DroppedItems = new List<ContentDroppedItem>();

                        //..items
                        DroppedItems.AddRange(objectContainer.Where(o => o.IsDroppedItem())
                            .Select(x =>
                            {
                                ContentDroppedItem droppedItem = x.AsDroppedItem();
                                ObjectReference itemRef = x.GetPropertyValue<ObjectReference>("MyItem");
                                objectContainer.TryGetValue(itemRef.ObjectId, out GameObject itemObject);

                                droppedItem.ClassName = itemObject.ClassString;
                                droppedItem.IsDeathCache = itemObject.IsDeathItemCache();


                                droppedItem.Latitude = (float)LoadedMap.LatShift + (droppedItem.Y / (float)LoadedMap.LatDiv);
                                droppedItem.Longitude = (float)LoadedMap.LonShift + (droppedItem.X / (float)LoadedMap.LonDiv);




                                return droppedItem;
                            }).ToList()
                        );

                        //.. corpses
                        logWriter.Debug($"Identifying any corpse");
DroppedItems.AddRange(objectContainer.Where(x => x.IsPlayer() && x.HasAnyProperty("MyDeathHarvestingComponent"))
.Select(x =>
{
                                ContentDroppedItem droppedItem = x.AsDroppedItem();

                                ConcurrentBag<ContentItem> inventoryItems = new ConcurrentBag<ContentItem>();

                                droppedItem.ClassName = x.ClassString;
                                droppedItem.IsDeathCache = true;
                                droppedItem.DroppedByTribeId = x.GetPropertyValue<int>("TargetingTeam", 0, 0);
                                droppedItem.DroppedByPlayerId = x.GetPropertyValue<long>("LinkedPlayerDataID", 0, 0);
                                droppedItem.DroppedByName = x.GetPropertyValue<string>("PlayerName");
                                droppedItem.Latitude = (float)LoadedMap.LatShift + (droppedItem.Y / (float)LoadedMap.LatDiv);
                                droppedItem.Longitude = (float)LoadedMap.LonShift + (droppedItem.X / (float)LoadedMap.LonDiv);


                                if (x.GetPropertyValue<ObjectReference>("MyInventoryComponent") != null)
                                {
                                    int inventoryRefId = x.GetPropertyValue<ObjectReference>("MyInventoryComponent").ObjectId;
                                    objectContainer.TryGetValue(inventoryRefId, out GameObject inventoryComponent);
                                    if (inventoryComponent != null)
                                    {
                                        PropertyArray inventoryItemsArray = inventoryComponent.GetTypedProperty<PropertyArray>("InventoryItems");
                                        if (inventoryItemsArray != null)
                                        {
                                            ArkArrayObjectReference objectReferences = (ArkArrayObjectReference)inventoryItemsArray.Value;

                                            Parallel.ForEach(objectReferences, objectReference =>
{
                                                objectContainer.TryGetValue(objectReference.ObjectId, out GameObject itemObject);
if (itemObject != null)
                                                {
                                                    if (itemObject.GetPropertyValue<bool>("bIsInitialItem", 0, false))
                                                    {

                                                        var item = itemObject.AsItem();
                                                        if (!item.IsEngram)
                                                        {

                                                            inventoryItems.Add(item);
                                                        }

                                                    }
                                                }
                                            });


                                            PropertyArray equippedItemArray = inventoryComponent.GetTypedProperty<PropertyArray>("EquippedItems");
                                            if (equippedItemArray != null)
                                            {
                                                ArkArrayObjectReference equippedReferences = (ArkArrayObjectReference)equippedItemArray.Value;
                                                Parallel.ForEach(equippedReferences, objectReference =>
                                                {
                                                    objectContainer.TryGetValue(objectReference.ObjectId, out GameObject itemObject);
                                                    if (itemObject != null)
                                                    {
                                                        if (!itemObject.HasAnyProperty("bIsInitialItem"))
                                                        {

                                                            var item = itemObject.AsItem();
                                                            if (!item.IsEngram)
                                                            {

                                                                inventoryItems.Add(item);
                                                            }

                                                        }
                                                    }
                                                });
                                            }

                                        }

                                    }



                                    droppedItem.Inventory = new ContentInventory() { Items = inventoryItems.ToList() };
                                }



                                return droppedItem;
                            }).ToList()
                        );

                        //.. bags
                        logWriter.Debug($"Identifying drop bags");

                        DroppedItems.AddRange(objectContainer.Where(x => x.IsDeathItemCache())
                            .Select(x =>
                            {
                                ContentDroppedItem droppedItem = x.AsDroppedItem();
                                ConcurrentBag<ContentItem> inventoryItems = new ConcurrentBag<ContentItem>();
                                droppedItem.ClassName = x.ClassString;
                                droppedItem.IsDeathCache = true;

                                droppedItem.Latitude = (float)LoadedMap.LatShift + (droppedItem.Y / (float)LoadedMap.LatDiv);
                                droppedItem.Longitude = (float)LoadedMap.LonShift + (droppedItem.X / (float)LoadedMap.LonDiv);


                                if (x.GetPropertyValue<ObjectReference>("MyInventoryComponent") != null)
                                {
                                    int inventoryRefId = x.GetPropertyValue<ObjectReference>("MyInventoryComponent").ObjectId;
                                    objectContainer.TryGetValue(inventoryRefId, out GameObject inventoryComponent);
                                    if (inventoryComponent != null && inventoryComponent.HasAnyProperty("InventoryItems"))
                                    {
                                        PropertyArray inventoryItemsArray = inventoryComponent.GetTypedProperty<PropertyArray>("InventoryItems");
                                        if (inventoryItemsArray != null)
                                        {
                                            ArkArrayObjectReference objectReferences = (ArkArrayObjectReference)inventoryItemsArray.Value;

                                            Parallel.ForEach(objectReferences, objectReference =>
{
                                                objectContainer.TryGetValue(objectReference.ObjectId, out GameObject itemObject);
if (itemObject != null)
{
                                                    if (!itemObject.HasAnyProperty("bIsInitialItem"))
                                                    {

                                                        var item = itemObject.AsItem();
                                                        if (!item.IsEngram)
                                                        {

                                                            inventoryItems.Add(item);
                                                        }

                                                    }
                                                }
                                            });
                                        }

                                    }

                                    if (inventoryComponent.HasAnyProperty("EquippedItems"))
                                    {
                                        PropertyArray inventoryItemsArray = inventoryComponent.GetTypedProperty<PropertyArray>("EquippedItems");
                                        if (inventoryItemsArray != null)
                                        {
                                            ArkArrayObjectReference objectReferences = (ArkArrayObjectReference)inventoryItemsArray.Value;
                                            Parallel.ForEach(objectReferences, objectReference =>
                                            {
                                                objectContainer.TryGetValue(objectReference.ObjectId, out GameObject itemObject);
                                                if (itemObject != null)
                                                {
                                                    if (!itemObject.HasAnyProperty("bIsInitialItem"))
                                                    {

                                                        var item = itemObject.AsItem();
                                                        if (!item.IsEngram)
                                                        {

                                                            inventoryItems.Add(item);
                                                        }

                                                    }
                                                }
                                            });
                                        }
                                    }

                                    droppedItem.Inventory = new ContentInventory() { Items = inventoryItems.ToList() };
                                }


                                return droppedItem;
                            }).ToList()
                        );

                        long droppedLoadEnd = DateTime.Now.Ticks;
                        var droppedLoadTime = TimeSpan.FromTicks(droppedLoadEnd - structureLoadEnd);
                        logWriter.Info($"Dropped items / bags loaded in: {droppedLoadTime.ToString(@"mm\:ss")}.");


                    }

                }


                foreach(var tribe in Tribes)
                {
                    var missingPlayers = tribe.Members.Where(m => !tribe.Players.Any(p => p.Id == m.Key)).ToList();
                    if(missingPlayers!=null && missingPlayers.Count > 0)
                    {
                        foreach(var missingPlayer in missingPlayers)
                        {
                            tribe.Players.Add(new ContentPlayer()
                            {
                                Id = missingPlayer.Key,
                                CharacterName = missingPlayer.Value,
                                Name = missingPlayer.Value
                            });
                        }
                    }
                    

                }


                //cluster data
                if (!string.IsNullOrEmpty(clusterFolder) && Directory.Exists(clusterFolder))
                {

                    logWriter.Info("Reading cluster data...");
                    var profileFilenames = Directory.GetFiles(clusterFolder, "*");
                    profileFilenames.AsParallel().ForAll(fileName =>
                    //foreach (var fileName in profileFilenames)
                    {
                        long itemOwnerId = 0;
                        long.TryParse(System.IO.Path.GetFileNameWithoutExtension(fileName), out itemOwnerId);

                        try
                        {
                            using (Stream clusterFileStream = new FileStream(fileName, FileMode.Open))
                            {
                                using (ArkArchive clusterArchive = new ArkArchive(clusterFileStream))
                                {
                                    ArkCloudInventory cloudInventory = new ArkCloudInventory();
                                    cloudInventory.ReadBinary(clusterArchive, ReadingOptions.Create().WithBuildComponentTree(true).WithDataFilesObjectMap(false).WithGameObjects(true).WithGameObjectProperties(true));

                                    PropertyStruct propTest = cloudInventory.GetTypedProperty<PropertyStruct>("MyArkData");
                                    StructPropertyList propList = propTest.Value as StructPropertyList;
                                    if (propList != null)
                                    {
                                        var itemList = propList.GetTypedProperty<PropertyArray>("ArkItems");
                                        if (itemList != null)
                                        {
                                            foreach (StructPropertyList testItem in itemList.Value as ArkArrayStruct)
                                            {
                                                try
                                                {
                                                    var item = testItem.GetTypedProperty<PropertyStruct>("ArkTributeItem");

                                                    var isInitialItem = (item.Value as StructPropertyList).GetPropertyValue<bool>("bIsInitialItem");
                                                    if (!isInitialItem)
                                                    {
                                                        ContentItem newItem = new ContentItem(item.Value as StructPropertyList);
                                                        //newItem.OwnerPlayerId = itemOwnerId;
                                                        if (newItem.UploadedTimeInGame != 0)
                                                        {
                                                            newItem.UploadedTime = GetApproxDateTimeOf(newItem.UploadedTimeInGame);
                                                            if (!newItem.UploadedTime.HasValue) newItem.UploadedTime = DateTime.MinValue;
                                                        }

                                                        if (newItem.OwnerPlayerId == 0)
                                                        {
                                                            //attempt to find by steam / epic id (filename)
                                                            var ownerPlayer = Tribes.SelectMany(t => t.Players.Where(p => p.NetworkId == itemOwnerId.ToString())).FirstOrDefault();
                                                            if (ownerPlayer != null) newItem.OwnerPlayerId = ownerPlayer.Id;
                                                        }

                                                        if (newItem.OwnerPlayerId != 0)
                                                        {
                                                            var targetPlayer = Tribes.SelectMany(m => m.Players).FirstOrDefault(p => p.Id == newItem.OwnerPlayerId || p.TargetingTeam == newItem.OwnerPlayerId);
                                                            if (targetPlayer != null)
                                                            {
                                                                if(newItem.Quantity == 0)
                                                                {

                                                                }

                                                                targetPlayer.Inventory.Items.Add(newItem);
                                                            }                    
                                                        }
                                                    }
                                                }
                                                catch 
                                                { 
                                                
                                                }
                                                

                                            }

                                        }

                                        var dinoList = propList.GetTypedProperty<PropertyArray>("ArkTamedDinosData");
                                        if (dinoList != null)
                                        {


                                            foreach (StructPropertyList dinoData in dinoList.Value as ArkArrayStruct)
                                            {
                                                var byteArray = dinoData.GetTypedProperty<PropertyArray>("DinoData");
                                                int uploadTime = dinoData.GetPropertyValue<int>("UploadTime");


                                                ArkArrayUInt8? creatureBytes = byteArray.Value as ArkArrayUInt8;
                                                if (creatureBytes != null)
                                                {


                                                    var cryoStream = new System.IO.MemoryStream(creatureBytes.ToArray<byte>());

                                                    using (ArkArchive uploadArchive = new ArkArchive(cryoStream))
                                                    {
                                                        // number of serialized objects
                                                        int objCount = uploadArchive.ReadInt();
                                                        if (objCount != 0)
                                                        {
                                                            var storedGameObjects = new List<GameObject>(objCount);
                                                            for (int oi = 0; oi < objCount; oi++)
                                                            {
                                                                storedGameObjects.Add(new GameObject(uploadArchive));
                                                            }

                                                            foreach (var ob in storedGameObjects)
                                                            {
                                                                ob.LoadProperties(uploadArchive, new GameObject(), 0);
                                                            }

                                                            var creatureObject = storedGameObjects[0];
                                                            var statusObject = storedGameObjects[1];

                                                            // assume the first object is the creature object
                                                            string creatureActorId = creatureObject.Names[0].ToString();

                                                            // the tribe name is stored in `TamerString`, non-cryoed creatures have the property `TribeName` for that.
                                                            if (creatureObject.GetPropertyValue<string>("TribeName")?.Length == 0 && creatureObject.GetPropertyValue<string>("TamerString")?.Length > 0)
                                                                creatureObject.Properties.Add(new PropertyString("TribeName", creatureObject.GetPropertyValue<string>("TamerString")));


                                                            ContentTamedCreature tamedDino = new ContentTamedCreature(uploadTime, creatureObject, statusObject);

                                                            if (tamedDino.UploadedTimeInGame != 0)
                                                            {
                                                                tamedDino.UploadedTime = DateTime.UnixEpoch.AddSeconds(tamedDino.UploadedTimeInGame);
                                                            }
                                                            

                                                            //TODO:// add to a list so we can assign it to the correct tribe
                                                            var targetTribe = Tribes.FirstOrDefault(t => t.TribeId == tamedDino.TargetingTeam);
                                                            if (targetTribe != null)
                                                            {
                                                                targetTribe.Tames.Add(tamedDino);
                                                            }
                                                            else
                                                            {
                                                                targetTribe = new ContentTribe()
                                                                {
                                                                    TribeName = tamedDino.TribeName ?? tamedDino.TamerName ?? tamedDino.ImprinterName,
                                                                    TribeId = tamedDino.TargetingTeam
                                                                };
                                                                if (!string.IsNullOrEmpty(targetTribe.TribeName))
                                                                {
                                                                    targetTribe.Tames.Add(tamedDino);
                                                                    Tribes.Add(targetTribe);
                                                                }
                                                            }

                                                        }

                                                    }

                                                }





                                            }

                                        }
                                    }


                                }
                            }


                        }
                        catch
                        {
                            //ignore
                        }

                    }
                    );


                }



                long endTicks = DateTime.Now.Ticks;
                var duration = TimeSpan.FromTicks(endTicks - startTicks);

                logWriter.Info($"Loaded in: {duration.ToString(@"mm\:ss")}.");
            }
            catch (Exception ex)
            {
                logWriter.Error(ex, "LoadSaveGame failed");
                throw;
            }


            logWriter.Trace("END LoadSaveGame()");
        }

        public DateTime? GetApproxDateTimeOf(double? objectTime)
        {
            try
            {
                return objectTime.HasValue
                && GameSeconds > 0 ? GameSaveTime.AddSeconds(objectTime.Value - GameSeconds) : (DateTime?)null;
            }
            catch
            {
                return (DateTime?)null;
            }
            
        }


    }
}
