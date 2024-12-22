using AsaSavegameToolkit;
using AsaSavegameToolkit.Propertys;
using AsaSavegameToolkit.Structs;
using AsaSavegameToolkit.Types;
using ASVPack.Extensions;
using NLog;
using SavegameToolkit;
using SavegameToolkit.Arrays;
using SavegameToolkit.Propertys;
using SavegameToolkit.Structs;
using SavegameToolkit.Types;
using SavegameToolkitAdditions;
using System.Collections.Concurrent;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO.Compression;
using System.Runtime.Serialization;


namespace ASVPack.Models
{
    [DataContract]
    public class ContentContainer : IContentContainer
    {

        private DateTime loadedTimestamp = DateTime.MinValue;
        private string loadedFilename = string.Empty;
        private string loadedClusterFolder = string.Empty;

        public delegate void ProgressUpdateHandler(string message);
        public event ProgressUpdateHandler OnUpdateProgress;


        ILogger logWriter = LogManager.GetCurrentClassLogger();
        private ContentMapPack mapPack = new ContentMapPack();


        public string LoadedFilename
        {
            get
            {
                return this.loadedFilename;
            }
        }
        [DataMember] public ContentMap LoadedMap { get; set; } = new ContentMap();

        [DataMember] public string MapName { get; set; } = "";
        [DataMember] public int MapDay { get; set; } = 0;
        [DataMember] public DateTime MapTime { get; set; } = DateTime.Now.Date;
        [DataMember] public List<ContentStructure> MapStructures { get; set; } = new List<ContentStructure>();
        [DataMember] public List<ContentWildCreature> WildCreatures { get; set; } = new List<ContentWildCreature>();
        [DataMember] public List<ContentTribe> Tribes { get; set; } = new List<ContentTribe>();
        [DataMember] public List<ContentDroppedItem> DroppedItems { get; set; } = new List<ContentDroppedItem>();
        [DataMember] public List<ContentStructure> PaintingStructures { get; set; } = new List<ContentStructure>();
        [DataMember] public ContentLocalProfile LocalProfile { get; set; } = new ContentLocalProfile();
        [DataMember] public List<ContentLeaderboard> Leaderboards { get; set; } = new List<ContentLeaderboard>();
        [DataMember] public DateTime GameSaveTime { get; set; } = new DateTime();
        [DataMember] public float GameSeconds { get; set; } = 0;


        private int profileDayLimit = 30;
        private int maxCoresCached = (int)(Environment.ProcessorCount * (0.75));

        private bool isLoaded = false;
        public bool IsLoaded()
        {
            return isLoaded;
        }

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


        private Stream GetFileStream(string filename)
        {
            var fileInfo = new FileInfo(filename);
            if(fileInfo.Length > int.MaxValue)
            {
                // >2GB limit for MemoryStream, return as FileStream instead.
                return new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            }

            byte[] fileContentBytes;
            using(FileStream s = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using(BinaryReader r = new BinaryReader(s))
                {
                    fileContentBytes = r.ReadAllBytes();
                }
            }

            return new MemoryStream(fileContentBytes);            
        }


        public void LoadSaveGame(string saveFilename, string localProfileFilename, string clusterFolder, int profileDayCountLimit=30, int maxCores = -1)
        {
            if (maxCores <= 0)
            {
                maxCores = (int)(Environment.ProcessorCount * (0.75));
            }
            maxCoresCached = maxCores;

            if (saveFilename.ToLowerInvariant().EndsWith(".gz"))
            {

                using (FileStream fileToDecompressAsStream = File.OpenRead(saveFilename))
                {
                    string decompressedFileName = Path.Combine(Path.GetDirectoryName(saveFilename)??"", string.Concat(Path.GetFileNameWithoutExtension(saveFilename), @"_raw.ark"));
                    
                    if(File.Exists(decompressedFileName))
                    {
                        File.Delete(decompressedFileName);
                    }

                    using (FileStream decompressedStream = File.Create(decompressedFileName))
                    {
                        using (GZipStream decompressionStream = new GZipStream(fileToDecompressAsStream, CompressionMode.Decompress))
                        {
                            try
                            {
                                decompressionStream.CopyTo(decompressedStream);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    }

                    saveFilename = decompressedFileName;
                }
            }


            loadedFilename = saveFilename;
            loadedClusterFolder = clusterFolder;
            profileDayLimit = profileDayCountLimit;
            isLoaded = false;

            logWriter.Trace("BEGIN LoadSaveGame()");

            if (!File.Exists(saveFilename))
            {
                logWriter.Error($"LoadSaveGame failed - unable to find file: {saveFilename}");
                throw new FileNotFoundException();
            }

            ContentMap? selectedMap = null;

            loadedTimestamp = File.GetLastWriteTimeUtc(saveFilename);

            LoadDefaults();

            long startTicks = DateTime.Now.Ticks;

            OnUpdateProgress?.Invoke("Checking LocalProfile data...");
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

            OnUpdateProgress?.Invoke("Started to load ARK save file...");
            logWriter.Info("Reading game save data...");
            try
            {
                List<ContentTribe> tribeContentList = new List<ContentTribe>();

                var fileInf = new FileInfo(saveFilename);
                
                GameSaveTime = fileInf.LastWriteTime;
                fileInf = null;

                logWriter.Debug($"Reading game save data: {saveFilename}");
                var dbTestString = string.Empty;

                using (Stream stream = GetFileStream(saveFilename))
                {
                    byte[] dbTestBytes = new byte[15];
                    stream.Read(dbTestBytes, 0, 15);
                    dbTestString = System.Text.Encoding.UTF8.GetString(dbTestBytes);
                    stream.Close();
                    stream.Dispose();
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();

                if (dbTestString.StartsWith("sqlite", StringComparison.InvariantCultureIgnoreCase))
                {
                    //Ark Survival Ascended
                    LoadArkAscendedData(saveFilename, maxCores);
                    
                }
                else
                {
                    LoadArkEvolvedData(saveFilename);
                }





                foreach (var tribe in Tribes)
                {
                    var missingPlayers = tribe.Members.Where(m => !tribe.Players.Any(p => p.Id == m.Key)).ToList();
                    if (missingPlayers != null && missingPlayers.Count > 0)
                    {
                        foreach (var missingPlayer in missingPlayers)
                        {
                            if (!Tribes.Any(t => t.Players.Any(p => p.Id == missingPlayer.Key)))
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
                }


                //cluster data
                if (!string.IsNullOrEmpty(clusterFolder) && Directory.Exists(clusterFolder))
                {

                    OnUpdateProgress?.Invoke("Loading cluster data...");
                    logWriter.Info("Reading cluster data...");
                    var profileFilenames = Directory.EnumerateFiles(clusterFolder, "*");

                    Parallel.ForEach(profileFilenames, new ParallelOptions() { MaxDegreeOfParallelism = maxCores}, fileName =>
                    //profileFilenames.AsParallel().ForAll(fileName =>
                    {
                        long itemOwnerId = 0;
                        long.TryParse(System.IO.Path.GetFileNameWithoutExtension(fileName), out itemOwnerId);

                        try
                        {
                            using (Stream clusterFileStream = GetAppropriateStream(fileName))
                            {
                                using (ArkArchive clusterArchive = new ArkArchive(clusterFileStream))
                                {
                                    ArkCloudInventory cloudInventory = new ArkCloudInventory();
                                    cloudInventory.ReadBinary(clusterArchive, ReadingOptions.Create().WithBuildComponentTree(true).WithDataFilesObjectMap(false).WithGameObjects(true).WithGameObjectProperties(true));

                                    PropertyStruct propTest = cloudInventory.GetTypedProperty<PropertyStruct>("MyArkData");
                                    StructPropertyList? propList = propTest.Value as StructPropertyList;
                                    if (propList != null)
                                    {
                                        var itemList = propList.GetTypedProperty<PropertyArray>("ArkItems");
                                        if (itemList != null)
                                        {
                                            foreach (StructPropertyList testItem in (ArkArrayStruct)itemList.Value)
                                            {
                                                try
                                                {
                                                    var item = testItem.GetTypedProperty<PropertyStruct>("ArkTributeItem");

                                                    var isInitialItem = ((StructPropertyList)item.Value).GetPropertyValue<bool>("bIsInitialItem");
                                                    if (!isInitialItem)
                                                    {
                                                        ContentItem newItem = new ContentItem((StructPropertyList)item.Value);
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
                                                                if (newItem.Quantity == 0)
                                                                {
                                                                    newItem.Quantity = 1;
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
                                        if (dinoList != null && dinoList.Value != null)
                                        {


                                            foreach (StructPropertyList dinoData in (ArkArrayStruct)dinoList.Value)
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


                                              

                                                            var targetTribe = Tribes.FirstOrDefault(t => t.TribeId == tamedDino.TargetingTeam);
                                                            if (targetTribe == null)
                                                            {
                                                                //see if we can find a matching steam player in existing tribe
                                                                var ownerTribe = Tribes.FirstOrDefault(t => t.Players.LongCount(p => p.NetworkId == itemOwnerId.ToString()) > 0);
                                                                if (ownerTribe != null)
                                                                {
                                                                    targetTribe = ownerTribe;
                                                                }

                                                                if (targetTribe == null)
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
                                                            if (targetTribe != null)
                                                            {
                                                                tamedDino.TribeName = targetTribe.TribeName;
                                                                targetTribe.Tames.Add(tamedDino);

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


                isLoaded = true;                
                long endTicks = DateTime.Now.Ticks;
                var duration = TimeSpan.FromTicks(endTicks - startTicks);
                OnUpdateProgress?.Invoke("Save data loaded and analysed.");

                logWriter.Info($"Loaded in: {duration.ToString(@"mm\:ss")}.");
            }
            catch (Exception ex)
            {
                isLoaded = false;
                logWriter.Error(ex, "LoadSaveGame failed");
                throw;
            }


            logWriter.Trace("END LoadSaveGame()");
        }

        private void LoadArkEvolvedData(string saveFilename)
        {
            GameObjectContainer? objectContainer = null;
            long startTicks = DateTime.Now.Ticks;

            //Ark Survival Evolved.
            using (Stream stream = GetFileStream(saveFilename))
            {
                using (ArkArchive archive = new ArkArchive(stream))
                {
                    ArkSavegame arkSavegame = new ArkSavegame();

                    OnUpdateProgress?.Invoke("Loading ARK save file...");

                    arkSavegame.ReadBinary(archive, ReadingOptions.Create()
                            .WithDataFiles(true)
                            .WithStoredCreatures(true)
                            .WithStoredTribes(true)
                            .WithStoredProfiles(true, profileDayLimit)
                            .WithBuildComponentTree(true));

                    arkSavegame.FileTime = GameSaveTime;

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
                    OnUpdateProgress?.Invoke("ARK save file loaded, analysing and parsing data...");





                    //get map name from .ark file data
                    logWriter.Debug($"Reading map name from: {saveFilename}");
                    MapName = arkSavegame.DataFiles[0];
                    logWriter.Debug($"Map name returned: {MapName}");

                    logWriter.Debug($"Loading map location data for: {MapName}.ark");
                    var selectedMap = mapPack.GetMap($"{MapName}.ark");

                    if (selectedMap != null)
                    {
                        LoadedMap = selectedMap;
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
                        OnUpdateProgress?.Invoke("Parsing missiong leaderboard data...");

                        //try find leaderboards
                        var leaderBoardContainer = testGameMode.GetTypedProperty<PropertyStruct>("LeaderboardContainer");
                        if (leaderBoardContainer != null)
                        {
                            var leaderBoardContainerProperties = leaderBoardContainer.Value as StructPropertyList;
                            if (leaderBoardContainerProperties != null)
                            {
                                var leaderBoards = leaderBoardContainerProperties.GetTypedProperty<PropertyArray>("Leaderboards");
                                if (leaderBoards != null)
                                {
                                    foreach (StructPropertyList leaderBoard in (ArkArrayStruct)leaderBoards.Value)
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
                                            ArkArrayStruct rows = (ArkArrayStruct)scoreRows.Value;
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
                                }

                            }


                            Leaderboards = leaderboardList;

                        }
                    }

                    var filePath = Path.GetDirectoryName(saveFilename) ?? "";
                    ConcurrentBag<ContentPlayer> fileProfiles = new ConcurrentBag<ContentPlayer>();

                    if (filePath.Length > 0)
                    {

                        OnUpdateProgress?.Invoke("Started loading .arkprofile data...");

                        long profileStart = DateTime.Now.Ticks;
                        logWriter.Info("Reading .arkprofile(s)");

                        var profileFilenames = Directory.EnumerateFiles(filePath, "*.arkprofile");
                        Parallel.ForEach(profileFilenames, new ParallelOptions() { MaxDegreeOfParallelism = maxCoresCached}, x =>
                        //profileFilenames.AsParallel().ForAll(x =>
                        {
                            try
                            {
                                logWriter.Debug($"Reading profile data: {x}");
                                var contentPlayer = ReadArkEvolvedProfileData(x);
                                if(contentPlayer!=null) fileProfiles.Add(contentPlayer);
                            }
                            catch
                            {
                                logWriter.Debug($"Failed to read profile data: {x}");
                            }
                        });
                        long profileEnd = DateTime.Now.Ticks;
                    }


                    if (arkSavegame.Profiles != null && arkSavegame.Profiles.Count > 0)
                    {
                        foreach (var arkProfile in arkSavegame.Profiles)
                        {
                            ContentPlayer contentPlayer = arkProfile.AsPlayer();
                            contentPlayer.PlayerFilename = string.Concat(contentPlayer.NetworkId ?? contentPlayer.Id.ToString(), ".arkprofile");

                            if (contentPlayer.Id != 0)
                            {
                                contentPlayer.LastActiveDateTime = GetApproxDateTimeOf(contentPlayer.LastTimeInGame);

                                contentPlayer.PlayerFilename = string.Concat(arkProfile.GetPropertyValue<Int64>("ProfileFilename", 0, 0).ToString(), ".arkprofile");

                                var matchingFileProfile = fileProfiles.FirstOrDefault(p => p.Id == contentPlayer.Id);
                                if (matchingFileProfile == null)
                                {
                                    fileProfiles.Add(contentPlayer);
                                }
                                else
                                {
                                    if (matchingFileProfile.LastTimeInGame < contentPlayer.LastTimeInGame)
                                    {
                                        matchingFileProfile = contentPlayer;
                                    }
                                }
                            }
                        }
                    }















                    ConcurrentBag<ContentTribe> fileTribes = new ConcurrentBag<ContentTribe>();
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

                    OnUpdateProgress?.Invoke(".arkprofile data loaded.");

                    long tribeStart = DateTime.Now.Ticks;
                    logWriter.Info("Reading .arktribe(s)");

                    OnUpdateProgress?.Invoke("Started loading .arktribe data...");
                    var tribeFilenames = Directory.EnumerateFiles(filePath, "*.arktribe");

                    Parallel.ForEach(tribeFilenames, new ParallelOptions() { MaxDegreeOfParallelism = maxCoresCached}, x =>
                    //tribeFilenames.AsParallel().ForAll(x =>
                    {
                        try
                        {
                            logWriter.Debug($"Reading tribe data: {x}");
                            var contentTribe = ReadArkEvolvedTribeData(x);
                            if (contentTribe != null) fileTribes.Add(contentTribe);
                        }
                        catch
                        {
                            logWriter.Debug($"Failed to read tribe data: {x}");
                        }

                    });


                    if (arkSavegame.Tribes != null && arkSavegame.Tribes.Count > 0)
                    {
                        foreach (var arkTribe in arkSavegame.Tribes)
                        {
                            var contentTribe = arkTribe.AsTribe();
                            if (contentTribe != null && contentTribe.TribeName != null)
                            {
                                contentTribe.TribeFileName = contentTribe.TribeFileName = string.Concat(contentTribe.TribeId, ".arktribe");
                                contentTribe.TribeFileDate = GameSaveTime;
                                contentTribe.HasGameFile = false;
                                if (!fileTribes.Any(t => t.TribeId == contentTribe.TribeId))
                                {
                                    if (contentTribe.LastActive > DateTime.Now)
                                    {

                                    }

                                    fileTribes.Add(contentTribe);
                                }

                            }
                        }
                    }

                    OnUpdateProgress?.Invoke(".arktribe data loaded.");

                    long tribeEnd = DateTime.Now.Ticks;

                    OnUpdateProgress?.Invoke("Allocating players to tribes...");

                    logWriter.Info($"Allocating players to tribes");

                    //allocate players to tribes

                    foreach (var p in fileProfiles)
                    {

           
                        var playerTribe = fileTribes.FirstOrDefault(t => t.TribeId == (long)p.TargetingTeam);
                        if (playerTribe == null)
                        {
                            playerTribe = fileTribes.FirstOrDefault(t => t.Members.Any(x => x.Key == p.Id));
                        }
                        var soloTribe = fileTribes.FirstOrDefault(t => t.TribeId == (long)p.Id);


                        if (playerTribe == null && soloTribe == null)
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
                    }

                    //var test = fileTribes.Where(t => t.Players.Any(p => p.NetworkId == "2535459452569590")).ToList();



                    /*
                    Parallel.ForEach(fileProfiles, new ParallelOptions() { MaxDegreeOfParallelism = maxCoresCached}, p =>
                    //fileProfiles.AsParallel().ForAll(p =>
                    //foreach(var p in fileProfiles)
                    {
                        var playerTribe = fileTribes.FirstOrDefault(t => t.TribeId == (long)p.TargetingTeam);

                        if (playerTribe != null)
                        {
                            if (playerTribe.Members.ContainsKey((int)p.Id))
                            {
                                playerTribe.Players.Add(p);
                            }
                            else
                            {
                                p.TargetingTeam = (int)p.Id; //must have left tribe, put in own tribe
                                playerTribe = null;
                            }
                        }

                        if (playerTribe == null)
                        {
                            playerTribe = new ContentTribe()
                            {
                                IsSolo = true,
                                HasGameFile = false,
                                TribeId = p.Id,
                                TribeName = $"Tribe of {p.CharacterName}"
                            };
                            playerTribe.Members.Add((int)p.Id, p.CharacterName);
                            playerTribe.Players.Add(p);
                            fileTribes.Add(playerTribe);
                        }




                    }
                    );
                    */
                    long allocationEnd = DateTime.Now.Ticks;



                    long structureStart = DateTime.Now.Ticks;

                    OnUpdateProgress?.Invoke("Identifying game map structures...");

                    logWriter.Info($"Identifying map structures");
                    //map structures we care about
                    MapStructures = objectContainer.Objects.Where(x =>
                        x.Location != null
                        && x.GetPropertyValue<int?>("TargetingTeam") == null
                        && (x.ClassString.StartsWith("TributeTerminal_")
                        || x.ClassString.Contains("CityTerminal_")
                        || x.ClassString.StartsWith("PowerNodeCharge")
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

                        var paintingRef = s.GetPropertyValue<ObjectReference?>("PaintingComponent", 0, null);
                        if (paintingRef != null)
                        {
                            var paintingComp = objectContainer.Objects.FirstOrDefault(p => p.Id == paintingRef.ObjectId);
                            if (paintingComp != null)
                            {
                                structure.UniquePaintingId = paintingComp.GetPropertyValue<int>("UniquePaintingId", 0, 0);
                            }
                        }


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

                                    foreach (var objectReference in objectReferences)
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
                                    };
                                }

                            }
                        }
                        else
                        {
                            //no inventory component, check for any "egg" within range of nest location
                            if (s.ClassName.Name.Contains("Nest"))
                            {
                                logWriter.Debug($"Finding nearby eggs for: {s.ClassString}");
                                var eggInRange = objectContainer.Objects.Find(x =>
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

                    var nests = MapStructures.Where(m => m.ClassName.ToLower().Contains("nest")).ToList();


                    long structureEnd = DateTime.Now.Ticks;
                    var structureTime = TimeSpan.FromTicks(structureEnd - structureStart);
                    logWriter.Info($"Structures loaded in: {structureTime.ToString(@"mm\:ss")}.");

                    long wildStart = DateTime.Now.Ticks;


                    OnUpdateProgress?.Invoke("Identifying wild creatures...");

                    logWriter.Info($"Identifying wild creatures");
                    //wilds

                    //Parallel.ForEach(objectContainer.Objects.Where(x=>x.IsWild()), x=>
                    WildCreatures = objectContainer.Objects.AsParallel().WithDegreeOfParallelism(maxCoresCached).Where(x => x.IsWild())
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
                            
                        }).Where(x => x !=null).Distinct().ToList();


                    
                    long wildEnd = DateTime.Now.Ticks;
                    var wildTime = TimeSpan.FromTicks(wildEnd - wildStart);
                    logWriter.Info($"Wilds loaded in: {wildTime.ToString(@"mm\:ss")}.");

                    var parallelContainer = objectContainer.AsParallel();

                    OnUpdateProgress?.Invoke("Allocating tames to tribes...");

                    logWriter.Info($"Identifying tamed creatures");
                    var allTames = parallelContainer
                                    .Where(x => x.IsTamed()) //exclude rafts.. no idea why these are "creatures"
                                    .GroupBy(x => (long)x.GetPropertyValue<int>("TargetingTeam")).Select(x => new { TribeId = x.Key, TribeName = x.First().GetPropertyValue<string>("TribeName") ?? x.First().GetPropertyValue<string>("TamerString"), Tames = x.ToList() }).ToList();



                    OnUpdateProgress?.Invoke("Parsing structures and inventory containers...");
                    logWriter.Debug($"Identifying player structures");
                    var allStructures = parallelContainer.Where(x => x.IsStructure()).GroupBy(x => x.Names[0]).Select(s => s.First()).ToList();
                    var playerStructures = allStructures.Where(x => x.GetPropertyValue<int>("TargetingTeam") >= 50_000).ToList();

                    var tribeStructures = playerStructures
                                                .GroupBy(x => new { TribeId = x.GetPropertyValue<int>("TargetingTeam"), TribeName = x.GetPropertyValue<string>("OwnerName") ?? x.GetPropertyValue<string>("TamerString") })
                                                .Select(x => new { TribeId = x.Key.TribeId, TribeName = x.Key.TribeName, Structures = x.ToList() })
                                                .ToList();



                    var abandonedStructures = allStructures.Where(x => x.GetPropertyValue<int>("TargetingTeam") < 50_0000).ToList();
                    abandonedStructures.RemoveAll(s =>
                        s.ClassString.StartsWith("BeeHive_C")
                        || s.ClassString.StartsWith("ArtifactCrate_")
                        || s.ClassString.StartsWith("TributeTerminal_")
                        || s.ClassString.Contains("Button_")
                        || s.ClassString.StartsWith("SupplyCrate_")
                        || s.ClassString.Contains("Nest_")
                        || s.ClassString.Contains("Vein_")
                        || s.ClassString.Contains("Beaver")

                    );



                    var abandonedTribe = fileTribes.FirstOrDefault(t => t.TribeId == int.MinValue);
                    if (abandonedTribe != null)
                    {
                        abandonedStructures.ForEach(
                            s => {
                                var structure = s.AsStructure();
                                structure.Latitude = (float)LoadedMap.LatShift + (structure.Y / (float)LoadedMap.LatDiv);
                                structure.Longitude = (float)LoadedMap.LonShift + (structure.X / (float)LoadedMap.LonDiv);
                                abandonedTribe.Structures.Add(structure);
                            }
                            );
                    }


                    //player and tribe data
                    long tribeLoadStart = DateTime.Now.Ticks;

                    OnUpdateProgress?.Invoke("Identifying in-game players...");

                    logWriter.Debug($"Identifying in-game player data");
                    var gamePlayers = parallelContainer.Where(o => o.IsPlayer() & !o.HasAnyProperty("MyDeathHarvestingComponent")).GroupBy(x => x.GetPropertyValue<long>("LinkedPlayerDataID")).Select(x => x.First()).ToList();
                    var tribesAndPlayers = gamePlayers.GroupBy(x => x.GetPropertyValue<int>("TargetingTeam")).ToList();

                    logWriter.Debug($"Identifying in-game players with no .arkprofile");

                    /*
                    var abandonedGamePlayers = tribesAndPlayers.Where(x => !fileTribes.Any(t => t.TribeId == (long)x.Key) & !fileProfiles.Any(p => p.Id == (long)x.Key)).ToList();
                    if (abandonedGamePlayers != null && abandonedGamePlayers.Count > 0)
                    {
                        Parallel.ForEach(abandonedGamePlayers, new ParallelOptions() { MaxDegreeOfParallelism = maxCoresCached}, abandonedTribe =>
                        //abandonedGamePlayers.AsParallel().ForAll(abandonedTribe =>
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
                    */


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
                        logWriter.Debug($"Identified tame tribes: {missingTameTribes.Count}");

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

                    OnUpdateProgress?.Invoke("Parsing player data...");

                    logWriter.Debug($"Populating player data");
                    //load inventories, locations etc.

                    Parallel.ForEach(fileTribes.Where(x => x.Players.Count > 0), new ParallelOptions() { MaxDegreeOfParallelism  = maxCoresCached},  fileTribe =>
                    //fileTribes.AsParallel().Where(x => x.Players.Count > 0).ForAll(fileTribe =>
                    //foreach(var fileTribe in fileTribes.Where(x=>x.Players.Count > 0))
                    {
                        var tribePlayers = fileTribe.Players;

                        Parallel.ForEach(tribePlayers, new ParallelOptions() {MaxDegreeOfParallelism = maxCoresCached }, player =>
                        //tribePlayers.AsParallel().ForAll(player =>
                        //foreach (var player in tribePlayers)
                        {

                            GameObject? arkPlayer = gamePlayers.Find(x => x.GetPropertyValue<long>("LinkedPlayerDataID") == player.Id);

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

                                            foreach (var objectReference in objectReferences)
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

                                        }


                                        PropertyArray equippedItemsArray = inventoryComponent.GetTypedProperty<PropertyArray>("EquippedItems");

                                        if (equippedItemsArray != null)
                                        {
                                            ArkArrayObjectReference objectReferences = (ArkArrayObjectReference)equippedItemsArray.Value;
                                            foreach (var objectReference in objectReferences)
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


                    OnUpdateProgress?.Invoke("Parsing tame data...");

                    Parallel.ForEach(allTames.SelectMany(x=>x.Tames), new ParallelOptions() { MaxDegreeOfParallelism = maxCoresCached},  x =>
                    //allTames.AsParallel().SelectMany(x => x.Tames).ForAll(x =>
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

                            if (float.IsNaN(creature.Y.GetValueOrDefault(0)))
                            {

                                creature.Latitude = 0;
                                creature.Longitude = 0;
                            }
                            else
                            {
                                creature.Latitude = (float)LoadedMap.LatShift + (creature.Y / (float)LoadedMap.LatDiv);
                                creature.Longitude = (float)LoadedMap.LonShift + (creature.X / (float)LoadedMap.LonDiv);

                                if (Math.Abs(creature.Latitude.GetValueOrDefault(0)) > 250 || Math.Abs(creature.Longitude.GetValueOrDefault(0)) > 250)
                                {
                                    creature.Latitude = 0;
                                    creature.Longitude = 0;
                                }
                            }

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

                                    foreach (var objectReference in objectReferences)
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
                                            if (rig1Object != null)
                                            {
                                                var itemRig1 = rig1Object.AsItem();
                                                creature.Rig1 = itemRig1.ClassName;
                                            }

                                            if (equippedReferences.Count > 1)
                                            {
                                                objectContainer.TryGetValue(equippedReferences[1].ObjectId, out GameObject rig2Object);
                                                var itemRig2 = rig2Object.AsItem();
                                                creature.Rig2 = itemRig2.ClassName;
                                            }

                                        }
                                        else
                                        {
                                            foreach (var objectReference in equippedReferences)
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
                                        }
                                    }


                                }




                                creature.Inventory = new ContentInventory() { Items = inventoryItems.ToList() };
                            }

                            if (tribe != null) tribe.Tames.Add(creature);

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
                        Parallel.ForEach(unclaimedBabies, new ParallelOptions() { MaxDegreeOfParallelism = maxCoresCached}, baby =>
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
                        );
                    }

                    //structures
                    OnUpdateProgress?.Invoke("Parsing player structure data...");
                    logWriter.Debug($"Populating player structure inventories");

                    var allTribeStructures = tribeStructures.SelectMany(x => x.Structures);
                    Parallel.ForEach(allTribeStructures, new ParallelOptions() { MaxDegreeOfParallelism = maxCoresCached}, x =>
                    {

                        var teamId = x.GetPropertyValue<int>("TargetingTeam");
                        var tribe = fileTribes.FirstOrDefault(t => t.TribeId == teamId) ?? fileTribes.FirstOrDefault(t => t.TribeId == int.MinValue); //tribe or abandoned

                        logWriter.Debug($"Converting to ContentStructure: {x.ClassString}");

                        ContentStructure structure = x.AsStructure();
                        ConcurrentBag<ContentItem> inventoryItems = new ConcurrentBag<ContentItem>();

                        structure.Latitude = (float)LoadedMap.LatShift + (structure.Y / (float)LoadedMap.LatDiv);
                        structure.Longitude = (float)LoadedMap.LonShift + (structure.X / (float)LoadedMap.LonDiv);

                        if (structure.CreatedTimeInGame > 0)
                        {
                            structure.CreatedDateTime = GetApproxDateTimeOf(structure.CreatedTimeInGame);
                        }
                        if (structure.LastAllyInRangeTimeInGame > 0)
                        {
                            structure.LastAllyInRangeTime = GetApproxDateTimeOf(structure.LastAllyInRangeTimeInGame);
                        }
                        
                        var paintingRef = x.GetPropertyValue<ObjectReference?>("PaintingComponent", 0, null);
                        if (paintingRef != null)
                        {
                            var paintingComp = objectContainer.Objects.FirstOrDefault(p => p.Id == paintingRef.ObjectId);
                            if (paintingComp != null)
                            {
                                structure.UniquePaintingId = paintingComp.GetPropertyValue<int>("UniquePaintingId", 0, 0);
                            }
                        }

                        //inventory
                        logWriter.Debug($"Determining inventory status for: {structure.ClassName}");


                        if (x.HasAnyProperty("SelectedResourceClass"))
                        {
                            //dedicated storage
                            var itemClass = x.GetPropertyValue<ObjectReference>("SelectedResourceClass").ObjectString.Name;
                            itemClass = itemClass.Substring(itemClass.LastIndexOf(".") + 1);

                            ContentItem item = new ContentItem();
                            item.ClassName = itemClass;
                            item.Quantity = x.GetPropertyValue<int>("ResourceCount");
                            item.Rating = 0;
                            item.OwnerPlayerId = x.GetPropertyValue<int>("OwningPlayerID");

                            if (item.Quantity != 0) inventoryItems.Add(item);
                        }

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

                                    Parallel.ForEach(objectReferences, new ParallelOptions() { MaxDegreeOfParallelism = maxCoresCached}, objectReference =>
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
                                    Parallel.ForEach(objectReferences, new ParallelOptions() { MaxDegreeOfParallelism = maxCoresCached}, objectReference =>
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
                        if (tribe != null && !tribe.Structures.Contains(structure)) tribe.Structures.Add(structure);

                    });


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

                                    Parallel.ForEach(objectReferences, new ParallelOptions() { MaxDegreeOfParallelism =maxCoresCached }, objectReference =>
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
                                        Parallel.ForEach(equippedReferences, new ParallelOptions() { MaxDegreeOfParallelism = maxCoresCached},  objectReference =>
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

                                        Parallel.ForEach(objectReferences, new ParallelOptions() { MaxDegreeOfParallelism = maxCoresCached}, objectReference =>
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

                                if (inventoryComponent != null && inventoryComponent.HasAnyProperty("EquippedItems"))
                                {
                                    PropertyArray inventoryItemsArray = inventoryComponent.GetTypedProperty<PropertyArray>("EquippedItems");
                                    if (inventoryItemsArray != null)
                                    {
                                        ArkArrayObjectReference objectReferences = (ArkArrayObjectReference)inventoryItemsArray.Value;
                                        Parallel.ForEach(objectReferences, new ParallelOptions() { MaxDegreeOfParallelism = maxCoresCached}, objectReference =>
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

        }

        private ContentTribe? ReadArkEvolvedTribeData(string x)
        {

            ContentTribe? contentTribe = null;
            using (Stream streamTribe = new FileStream(x, FileMode.Open))
            {

                using (ArkArchive archiveTribe = new ArkArchive(streamTribe))
                {
                    ArkTribe arkTribe = new ArkTribe();
                    arkTribe.ReadBinary(archiveTribe, ReadingOptions.Create().WithBuildComponentTree(false).WithDataFilesObjectMap(false).WithGameObjects(true).WithGameObjectProperties(true));

                    logWriter.Debug($"Converting to ContentTribe for: {x}");
                    contentTribe = arkTribe.Tribe.AsTribe();
                    if (contentTribe != null && contentTribe.TribeName != null)
                    {
                        contentTribe.TribeFileName = Path.GetFileName(x);
                        contentTribe.TribeFileDate = File.GetLastWriteTimeUtc(x).ToLocalTime();
                        contentTribe.HasGameFile = true;
                    }
                }
            }

            return contentTribe;
        }



        private ContentPlayer? ReadArkEvolvedProfileData(string x)
        {
            ContentPlayer? contentPlayer = null;

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
                            contentPlayer = arkProfile.AsPlayer();
                            contentPlayer.PlayerFilename = Path.GetFileName(x);
                            if (contentPlayer.Id != 0)
                            {
                                contentPlayer.LastActiveDateTime = GetApproxDateTimeOf(contentPlayer.LastTimeInGame);
                            }
                        }
                    }
                }
            }

            return contentPlayer;
        }

        private void LoadArkAscendedData(string saveFilename, int maxCores)
        {


            long startTicks = DateTime.Now.Ticks;

            //load data
            OnUpdateProgress?.Invoke("Loading ARK save file...");
            AsaSavegame arkSavegame = new AsaSavegame();
            arkSavegame.Read(saveFilename, maxCores);
            OnUpdateProgress?.Invoke("ARK save file loaded. Analysing and parsing data...");

        
            long endTicks = DateTime.Now.Ticks;
            TimeSpan timeTaken = TimeSpan.FromTicks(endTicks - startTicks);
            logWriter.Info($"Game data loaded in: {timeTaken.ToString(@"mm\:ss")}.");

            
            //determine map
            MapName = arkSavegame.DataFiles[0];
            var selectedMap = mapPack.GetMap($"{MapName}.ark");

            if (selectedMap != null)
            {
                LoadedMap = selectedMap;
                logWriter.Debug($"Map location data loaded for: {selectedMap.MapName}");
            }
            else
            {
                logWriter.Debug($"Failed to load location data for: {MapName}.ark");
                return;
            }

            var gameDayCycle = arkSavegame.Objects.FirstOrDefault(o => o.ClassString.Contains("daycycle", StringComparison.CurrentCultureIgnoreCase));
            if (gameDayCycle != null)
            {
                MapDay = 1;
                var mapTimeEpoch = gameDayCycle.GetPropertyValue<float>("CurrentTime", 0, 0);
                MapTime = DateTime.UnixEpoch.AddSeconds(mapTimeEpoch);

                if (gameDayCycle.HasAnyProperty("theDayNumberToMakeSerilizationWork"))
                {
                    MapDay = gameDayCycle.GetPropertyValue<int>("theDayNumberToMakeSerilizationWork", 0, 1);
                }
            }

            //read game time and file datetime
            FileInfo fileInfo = new FileInfo(saveFilename);
            DateTime fileTimestamp =  fileInfo.LastWriteTime;
            GameSeconds = (float)arkSavegame.GameTime;
            GameSaveTime = fileTimestamp;

            //parse tribes
            OnUpdateProgress?.Invoke("ARK save file loaded. Parsing Tribes...");
            ConcurrentBag<ContentTribe> fileTribes = new ConcurrentBag<ContentTribe>();
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

            ConcurrentBag<ContentTribe> tribeList = new ConcurrentBag<ContentTribe>();

            Parallel.ForEach(arkSavegame.Tribes, new ParallelOptions { MaxDegreeOfParallelism = maxCores }, tribe =>
            //arkSavegame.Tribes.AsParallel().ForAll(tribe =>
            {
                var contentTribe = tribe.Tribe.AsTribe();
                contentTribe.TribeFileDate = tribe.TribeFileTimestamp.ToLocalTime();
                if (contentTribe != null)
                {
                    tribeList.Add(contentTribe);
                }                    
            });

            foreach (var tribe in tribeList.OrderByDescending(o => o.TribeFileDate))
            {
                if(!fileTribes.Any(f=>f.TribeId == tribe.TribeId))
                {
                    fileTribes.Add(tribe);
                }
            }

            startTicks = DateTime.Now.Ticks;

            //parse profiles
            OnUpdateProgress?.Invoke("ARK save file loaded. Parsing Profiles...");
            ConcurrentBag<ContentPlayer> fileProfiles = new ConcurrentBag<ContentPlayer>();
            Parallel.ForEach(arkSavegame.Profiles, new ParallelOptions() { MaxDegreeOfParallelism = maxCores }, profile=>
            {
                //parse into ContentPlayer and add to list
                var playerProfile = profile?.Profile;
                var contentPlayer = playerProfile?.AsPlayer() ?? null;

                if (contentPlayer != null)
                {
    

                    if (playerProfile?.Location != null)
                    {
                        float latitude = (float)LoadedMap.LatShift + ((float)playerProfile?.Location.Y / (float)LoadedMap.LatDiv);
                        float longitude = (float)LoadedMap.LonShift + ((float)playerProfile?.Location.X / (float)LoadedMap.LonDiv);
                        contentPlayer.Latitude = latitude;
                        contentPlayer.Longitude = longitude;
                    }
                    fileProfiles.Add(contentPlayer);
                }
            }
            );



            endTicks = DateTime.Now.Ticks;
            timeTaken = TimeSpan.FromTicks(endTicks - startTicks);
            logWriter.Info($"Profile data loaded in: {timeTaken.ToString(@"mm\:ss")}.");

            

            startTicks = DateTime.Now.Ticks;
            OnUpdateProgress?.Invoke("ARK save file loaded. Allocating Tribe Players...");
            //allocate players to tribes
            //foreach (var p in fileProfiles)
           
            Parallel.ForEach(fileProfiles, new ParallelOptions() { MaxDegreeOfParallelism = maxCores }, p =>
            { 
                var playerTribe = fileTribes.FirstOrDefault(t => t.TribeId == (long)p.TargetingTeam);
                if (playerTribe == null)
                {
                    playerTribe = fileTribes.FirstOrDefault(t => t.Members.Any(x => x.Key == p.Id));
                }                
                var soloTribe = fileTribes.FirstOrDefault(t => t.TribeId == (long)p.Id);

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
            }
            );
            
            

            endTicks = DateTime.Now.Ticks;
            timeTaken = TimeSpan.FromTicks(endTicks - startTicks);

            //var drakeNests = arkSavegame.Objects.Where(o => o.ClassString.ToLower().Contains("rockdrakenest_c")).ToList();


            logWriter.Info($"Allocated player tribes in: {timeTaken.ToString(@"mm\:ss")}.");

            startTicks = DateTime.Now.Ticks;
            OnUpdateProgress?.Invoke("ARK save file loaded. Parsing Map Structures...");

            //parse structures         
            var mapStructures = arkSavegame.Objects.Where(x =>
                        x.Location != null
                        && x.GetPropertyValue<int?>("TargetingTeam") == null
                        && (
                        x.ClassString.StartsWith("TributeTerminal_")
                            || x.ClassString.Contains("CityTerminal_")
                            || x.ClassString.Equals("PrimalStructurePowerNode_C")
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
                        ContentStructure? structure = s.AsStructure();
                        
                        if (structure != null)
                        {

                            if (s.Location != null)
                            {
                                float latitude = (float)LoadedMap.LatShift + ((float)s.Location.Y / (float)LoadedMap.LatDiv);
                                float longitude = (float)LoadedMap.LonShift + ((float)s.Location.X / (float)LoadedMap.LonDiv);
                                structure.Latitude = latitude;
                                structure.Longitude = longitude;
                            }
     

                            structure.CreatedDateTime = GetApproxDateTimeOf(structure.CreatedTimeInGame);
                            structure.Latitude = (float)LoadedMap.LatShift + (structure.Y / (float)LoadedMap.LatDiv);
                            structure.Longitude = (float)LoadedMap.LonShift + (structure.X / (float)LoadedMap.LonDiv);

                            ConcurrentBag<ContentItem> inventoryItems = new ConcurrentBag<ContentItem>();

                            AsaGameObject? paintingComponent = null;
                            AsaObjectReference? paintingRef = s.GetPropertyValue<AsaObjectReference?>("PaintingComponent", 0, null);
                            if (paintingRef != null)
                            {
                                paintingComponent = arkSavegame.Objects.FirstOrDefault(o => o.Guid.ToString() == paintingRef.Value);
                                if(paintingComponent!=null)
                                    structure.UniquePaintingId = paintingComponent.GetPropertyValue<int>("UniquePaintingId", 0, 0);
                            }

                            structure.Inventory = new ContentInventory();

                            AsaGameObject inventoryComponent = null;
                            AsaObjectReference? inventoryRef = s.GetPropertyValue<AsaObjectReference?>("MyInventoryComponent", 0, null);
                            if (inventoryRef != null)
                            {
                                inventoryComponent = arkSavegame.Objects.FirstOrDefault(o => o.Guid.ToString() == inventoryRef.Value);

                                if (inventoryComponent != null)
                                {
                                    //inventory found, add items
                                    var inventoryItemsArray = inventoryComponent.GetPropertyValue<dynamic>("InventoryItems");
                                    if (inventoryItemsArray != null)
                                    {
                                        foreach (AsaObjectReference objectReference in inventoryItemsArray)
                                        {
                                            AsaGameObject itemObject = arkSavegame.GetObjectByGuid(Guid.Parse(objectReference.Value));

                                            if (itemObject != null)
                                            {
                                                
                                                var item = itemObject.AsItem();


                                                if (!item.IsEngram & !item.IsBlueprint)
                                                {
                                                    if(item.ClassName != "PrimalItem_PowerNodeCharge_C")
                                                        inventoryItems.Add(item);
                                                }
                                                
                                            }
                                        };
                                     
                                    }
                                }
                            }
                            else
                            {
                                //check for eggs *near* nests
                                if (s.ClassString.Contains("nest", StringComparison.CurrentCultureIgnoreCase))
                                {
                                    var eggInRange = arkSavegame.Objects.FirstOrDefault(x =>
                                        x.ClassString.Contains("egg", StringComparison.CurrentCultureIgnoreCase)
                                        && x.Location != null
                                        && Math.Abs((x.Location.X > s.Location.X) ? x.Location.X - s.Location.X : s.Location.X - x.Location.X) < 100
                                        && Math.Abs((x.Location.Y > s.Location.Y) ? x.Location.Y - s.Location.Y : s.Location.Y - x.Location.Y) < 100
                                    );

                                    if (eggInRange != null)
                                    {
                                        AsaObjectReference? itemRef = eggInRange.GetPropertyValue<AsaObjectReference?>("MyItem", 0, null);
                                        if (itemRef != null)
                                        {
                                            var itemId = Guid.Parse(itemRef.Value);
                                            var itemObj = arkSavegame.GetObjectByGuid(itemId);
                                            if (itemObj != null)
                                            {
                                                ContentItem eggItem = new ContentItem()
                                                {
                                                    ClassName = itemObj.ClassString,
                                                    Quantity = 1
                                                };

                                                string customName = itemObj.GetPropertyValue<string?>("CustomItemDescription", 0, "") ?? "";
                                                customName = customName.Replace("\n", " / ");
                                                customName = customName.Replace("Parents: /", "");
                                                eggItem.CustomName = customName;
                                                
                                                
                                              

                                                inventoryItems.Add(eggItem);
                                            }
                                        }
                                    }
                                }
                            }

                            if (inventoryItems.Count > 0) structure.Inventory.Items.AddRange(inventoryItems.ToArray());


                            return structure;
                        }

                        return new ContentStructure();
                        
                    }).Where(s=>!string.IsNullOrEmpty(s.ClassName)).ToList<ContentStructure>();

            

            MapStructures = new List<ContentStructure>();
            if(mapStructures!=null && mapStructures.Count > 0)
            {
                MapStructures.AddRange(mapStructures);
                mapStructures.Clear(); //no longer needed
            }


            
            endTicks = DateTime.Now.Ticks;
            timeTaken = TimeSpan.FromTicks(endTicks - startTicks);
            logWriter.Info($"Map structures parsed in: {timeTaken.ToString(@"mm\:ss")}.");


            //parse wild creatures
            startTicks = DateTime.Now.Ticks;
            OnUpdateProgress?.Invoke("ARK save file loaded. Parsing Wild Creatures...");
            WildCreatures = new List<ContentWildCreature>();
            
            ConcurrentBag<ContentWildCreature> wildBag = new ConcurrentBag<ContentWildCreature>();

            Parallel.ForEach(arkSavegame.Objects.Where(x=>x.IsWild()), new ParallelOptions { MaxDegreeOfParallelism = maxCores }, x =>
            //arkSavegame.Objects.AsParallel().Where(x => x.IsWild()).ForAll(x=>              
            //foreach(var x in arkSavegame.Objects.Where(o => o.IsWild()))
            {

                AsaObjectReference? statusCompRef = x.GetPropertyValue<AsaObjectReference?>("MyCharacterStatusComponent", 0, null) ?? x.GetPropertyValue<AsaObjectReference?>("MyDinoStatusComponent", 0, null);
                
                if (statusCompRef != null)
                {
                    Guid refGuid = Guid.Parse(statusCompRef.Value);
                    var statusComp = arkSavegame.GetObjectByGuid(refGuid);
                    if (statusComp != null)
                    {
                        var wildCreature = x.AsWildCreature(statusComp);
                        if (x.Location != null)
                        {
                            float latitude = (float)LoadedMap.LatShift + ((float)x.Location.Y / (float)LoadedMap.LatDiv);
                            float longitude = (float)LoadedMap.LonShift + ((float)x.Location.X / (float)LoadedMap.LonDiv);
                            wildCreature.Latitude = latitude;
                            wildCreature.Longitude = longitude;
                        }


                        wildBag.Add(wildCreature);
                    }
                }
            }
            );

            if(wildBag!=null && wildBag.Count > 0)
            {
                WildCreatures.AddRange(wildBag);
            }
            wildBag.Clear();//no longer needed

            
            endTicks = DateTime.Now.Ticks;
            timeTaken = TimeSpan.FromTicks(endTicks - startTicks);
            logWriter.Info($"Wild creatures parsed in: {timeTaken.ToString(@"mm\:ss")}.");


            //parse tamed creatures
            OnUpdateProgress?.Invoke("ARK save file loaded. Detecting tamed creatures...");
            var allTames = arkSavegame.Objects
                .Where(x => x.IsTamed()) 
                .GroupBy(x => (long)x.GetPropertyValue<int>("TargetingTeam")).Select(x => new { TribeId = x.Key, TribeName = x.First().GetPropertyValue<string>("TribeName") ?? x.First().GetPropertyValue<string>("TamerString"), Tames = x.ToList() }).ToList();

            /*
            var embyros = arkSavegame.Objects.Where(o => o.ClassString == "PrimalItemConsumable_Embryo_Base_C").ToList();
            foreach (var embryo in embyros)
            {
                AsaObjectReference? ownerInventoryRef = embryo.Properties.First(p => p.Name == "OwnerInventory")?.Value;
                if (ownerInventoryRef != null)
                {
                    var ownerInventory = arkSavegame.GetObjectByGuid(Guid.Parse(ownerInventoryRef.Value));
                    if (ownerInventory == null) continue;
                    if (ownerInventory.Names.Count == 0) continue;

                    AsaGameObject? ownerContainer = arkSavegame.Objects.First(o => o.Names[0] == ownerInventory.Names[1]);
                    if(ownerContainer==null) continue;

                    
                    var embryoCreature = new ContentTamedEmbryo(ownerContainer, embryo);



                }

            }

            */


            //parse player structures
            OnUpdateProgress?.Invoke("ARK save file loaded. Detecting player structures...");
            var allStructures = arkSavegame.Objects.Where(x => x.IsStructure() && x.GetPropertyValue<int>("TargetingTeam") >= 50_000).GroupBy(x => x.Names[0]).Select(s => s.First()).ToList();
            var playerStructures = allStructures.Where(x => x.GetPropertyValue<int>("TargetingTeam") >= 50_000).ToList();

            var tribeStructures = playerStructures
                                        .GroupBy(x => new { TribeId = x.GetPropertyValue<int>("TargetingTeam"), TribeName = x.GetPropertyValue<string>("OwnerName") ?? x.GetPropertyValue<string>("TamerString") })
                                        .Select(x => new { TribeId = x.Key.TribeId, TribeName = x.Key.TribeName, Structures = x.ToList() })
                                        .ToList();


            var abandonedStructures = allStructures.AsParallel().Where(x => x.GetPropertyValue<int>("TargetingTeam") < 50_0000 &!
                (
                x.ClassString.StartsWith("BeeHive_C")
                || x.ClassString.StartsWith("ArtifactCrate_")
                || x.ClassString.StartsWith("TributeTerminal_")
                || x.ClassString.Contains("Button_")
                || x.ClassString.StartsWith("SupplyCrate_")
                || x.ClassString.Contains("Nest_")
                || x.ClassString.Contains("Vein_")
                || x.ClassString.Contains("Beaver")
                )
            
            );

            var abandonedTribe = fileTribes.FirstOrDefault(t => t.TribeId == int.MinValue);
            if (abandonedTribe != null)
            {
                Parallel.ForEach(abandonedStructures, new ParallelOptions() { MaxDegreeOfParallelism = maxCores }, s =>
                //abandonedStructures.ForAll(
                    {
                        var structure = s.AsStructure();
                        structure.Latitude = (float)LoadedMap.LatShift + (structure.Y / (float)LoadedMap.LatDiv);
                        structure.Longitude = (float)LoadedMap.LonShift + (structure.X / (float)LoadedMap.LonDiv);
                        abandonedTribe.Structures.Add(structure);
                    }
                    );
            }

           

            //attempt to get missing tribe data from structures
            var missingStructureTribes = tribeStructures.AsParallel()
                .Where(x => !fileTribes.Any(t => t.TribeId == x.TribeId))
                .GroupBy(x => x.TribeId)
                .Select(x => x.First())
                .ToList();

            if (missingStructureTribes != null && missingStructureTribes.Count > 0)
            {
                missingStructureTribes.ForEach(tribe =>
                {

                    fileTribes.Add(new ContentTribe()
                    {
                        TribeId = tribe.TribeId,
                        TribeName = tribe.TribeName??"Unknown",
                        HasGameFile = false
                    });
                });

            }

            //attempt to get missing tribe data from tames
            var missingTameTribes = allTames
                .Where(x => !fileTribes.Any(t => t.TribeId == x.TribeId))
                .ToList();

            if (missingTameTribes != null && missingTameTribes.Count > 0)
            {
                missingTameTribes.ForEach(tribe =>
                {
                    fileTribes.Add(new ContentTribe()
                    {
                        TribeId = tribe.TribeId,
                        TribeName = tribe.TribeName??"Unknown",
                        HasGameFile = false
                    });

                });
            }

            var gamePlayers = arkSavegame.Objects.Where(o => o.IsPlayer() & !o.HasAnyProperty("MyDeathHarvestingComponent")).GroupBy(x => x.GetPropertyValue<long>("LinkedPlayerDataID")).Select(x => x.First()).ToList();
            var playersWithNoProfile = gamePlayers.Where(p => !fileProfiles.Any(f => f.Id == (long)(p.Properties.FirstOrDefault(pp => pp.Name == "LinkedPlayerDataID")?.Value ?? 0))).ToList();
            foreach (var playerObject in playersWithNoProfile)
            {
                AsaObjectReference? playerStatusRef = playerObject.GetPropertyValue<AsaObjectReference?>("MyCharacterStatusComponent", 0, null);
                if (playerStatusRef != null)
                {
                    var playerStatusComp = arkSavegame.GetObjectByGuid(Guid.Parse(playerStatusRef.Value));
                    var contentPlayer = playerObject.AsPlayer(playerStatusComp);
                    if (contentPlayer != null)
                    {
                        AsaLocation? playerLocation = arkSavegame.GetActorLocation(playerObject.Guid);
                        if (playerLocation != null)
                        {
                            contentPlayer.Latitude = (float)((float)LoadedMap.LatShift + (playerLocation.Y / (float)LoadedMap.LatDiv));
                            contentPlayer.Longitude = (float)((float)LoadedMap.LonShift + (playerLocation.X / (float)LoadedMap.LonDiv));
                        }


                        ContentTribe? playerTribe = fileTribes.FirstOrDefault(t => t.TribeId == contentPlayer.TargetingTeam);
                        if (playerTribe != null)
                        {
                            playerTribe.Players.Add(contentPlayer);
                        }

                        fileProfiles.Add(contentPlayer);
                    }
                }
            }

            startTicks = DateTime.Now.Ticks;
            OnUpdateProgress?.Invoke("ARK save file loaded. Parsing player data...");
            //load tribe player data
            var tribesWithPlayers = fileTribes.Where(x => x.Players.Count > 0);
            
            //Parallel.ForEach(tribesWithPlayers, fileTribe=>
            foreach(var fileTribe in tribesWithPlayers)
            {
                var tribePlayers = fileTribe.Players;

                //Parallel.ForEach(tribePlayers, player=>
                foreach(var player in tribePlayers)
                {
                    AsaGameObject? arkPlayer = gamePlayers.Find(x => (long)x.GetPropertyValue<ulong>("LinkedPlayerDataID") == player.Id);

                    if (arkPlayer != null)
                    {
                        AsaObjectReference? statusRef = arkPlayer.GetPropertyValue<AsaObjectReference?>("MyCharacterStatusComponent");
                        if(statusRef == null)
                        {
                            continue;
                        }

                        Guid statusId = Guid.Parse(statusRef.Value);
                        AsaGameObject? playerStatus = arkSavegame.GetObjectByGuid(statusId);
                        ContentPlayer contentPlayer = arkPlayer.AsPlayer(playerStatus);


                        if (arkPlayer.Location != null)
                        {
                            player.X = (float)arkPlayer.Location.X;
                            player.Y = (float)arkPlayer.Location.Y;
                            player.Z = (float)arkPlayer.Location.Z;
                            player.Latitude = (float)LoadedMap.LatShift + (player.Y / (float)LoadedMap.LatDiv);
                            player.Longitude = (float)LoadedMap.LonShift + (player.X / (float)LoadedMap.LonDiv);

                        }

                        player.LastTimeInGame = contentPlayer.LastTimeInGame;
                        player.LastActiveDateTime = GetApproxDateTimeOf(player.LastTimeInGame);
                        player.Gender = arkPlayer.ClassName.Name.Contains("Female") ? "Female" : "Male";
                        player.Level = contentPlayer.Level;
                        player.Stats = contentPlayer.Stats;


                        if (arkPlayer.GetPropertyValue<AsaObjectReference>("MyInventoryComponent") != null)
                        {
                            var inventoryRefId = arkPlayer.GetPropertyValue<AsaObjectReference?>("MyInventoryComponent",0,null)?.Value??"";
                            Guid inventoryId = Guid.Parse(inventoryRefId);
                            AsaGameObject? inventoryComponent = arkSavegame.GetObjectByGuid(inventoryId);
                            
                            ConcurrentBag<ContentItem> inventoryItems = new ConcurrentBag<ContentItem>();
                            if (inventoryComponent != null)
                            {
                                List<dynamic>? inventoryItemsArray = inventoryComponent.GetPropertyValue<dynamic>("InventoryItems",0,null);
                                if (inventoryItemsArray != null)
                                {
                                    foreach(var objectReference in inventoryItemsArray)
                                    {
                                        Guid itemId = Guid.Parse(objectReference.Value);
                                        AsaGameObject? itemObject = arkSavegame.GetObjectByGuid(itemId);

                                        if (itemObject != null)
                                        {
                                            var item = itemObject.AsItem();
                                            if (!item.IsEngram)
                                            {

                                                inventoryItems.Add(item);

                                            }
                                        }
                                    }
                                    
                                }

                                List<dynamic>? equippedItemsArray = inventoryComponent.GetPropertyValue<dynamic>("EquippedItems", 0, null);
                                if (equippedItemsArray != null)
                                {

                                    foreach(var objectReference in equippedItemsArray)
                                    {
                                        Guid itemId = Guid.Parse(objectReference.Value);
                                        AsaGameObject? itemObject = arkSavegame.GetObjectByGuid(itemId);

                                        if (itemObject != null)
                                        {
                                            var item = itemObject.AsItem();
                                            if (!item.IsEngram)
                                            {

                                                inventoryItems.Add(item);

                                            }
                                        }
                                    }

                                }
                            }

                            player.Inventory = new ContentInventory() { Items = inventoryItems.ToList() };
                            inventoryItems.Clear();

                        }
                    }

                }
                //);
            }
            //);

            endTicks = DateTime.Now.Ticks;
            timeTaken = TimeSpan.FromTicks(endTicks - startTicks);
            logWriter.Info($"Player data parsed in: {timeTaken.ToString(@"mm\:ss")}.");

            startTicks = DateTime.Now.Ticks;
            // allocate tribe tames
            OnUpdateProgress?.Invoke("ARK save file loaded. Parsing tame data...");
            var allPlayerTames = allTames.SelectMany(t=>t.Tames).ToList();

            
            Parallel.ForEach(allPlayerTames,  new ParallelOptions() { MaxDegreeOfParallelism = maxCores }, x=>
            //foreach(var x in allPlayerTames)
            {
                //find appropriate tribe to add to
                var teamId = x.GetPropertyValue<int>("TargetingTeam");
                var tribe = fileTribes.FirstOrDefault(t => t.TribeId == teamId) ?? fileTribes.FirstOrDefault(t => t.TribeId == int.MinValue); //tribe or abandoned

                AsaObjectReference? statusRef = x.GetPropertyValue<AsaObjectReference?>("MyCharacterStatusComponent") ?? x.GetPropertyValue<AsaObjectReference?>("MyDinoStatusComponent");
                if (statusRef != null)
                {
                    Guid statusGuid = Guid.Parse(statusRef.Value);
                    AsaGameObject? statusObject = arkSavegame.GetObjectByGuid(statusGuid);

                    if (statusObject != null)
                    {
                        ContentTamedCreature creature = x.AsTamedCreature(statusObject);

                        if (!string.IsNullOrEmpty(creature.ImprintedPlayerNetId))
                        {
                            var imprintPlayer = fileTribes.SelectMany(t => t.Players.Where(p => p.NetworkId.Equals(creature.ImprintedPlayerNetId, StringComparison.InvariantCultureIgnoreCase))).FirstOrDefault();
                            if (imprintPlayer != null)
                            {
                                creature.ImprintedPlayerId = imprintPlayer.Id;
                            }
                        }

                        if (float.IsNaN(creature.Y.GetValueOrDefault(0)))
                        {

                            creature.Latitude = 0;
                            creature.Longitude = 0;
                        }
                        else
                        {
                            creature.Latitude = (float)LoadedMap.LatShift + (creature.Y / (float)LoadedMap.LatDiv);
                            creature.Longitude = (float)LoadedMap.LonShift + (creature.X / (float)LoadedMap.LonDiv);

                            if (Math.Abs(creature.Latitude.GetValueOrDefault(0)) > 250 || Math.Abs(creature.Longitude.GetValueOrDefault(0)) > 250)
                            {
                                creature.Latitude = 0;
                                creature.Longitude = 0;
                            }
                        }

                        creature.TamedAtDateTime = GetApproxDateTimeOf(creature.TamedTimeInGame);
                        creature.LastAllyInRangeTime = GetApproxDateTimeOf(creature.LastAllyInRangeTimeInGame);
                        

                        //get inventory items
                        
                        ConcurrentBag<ContentItem> inventoryItems = new ConcurrentBag<ContentItem>();
                        AsaObjectReference? inventoryRef = x.GetPropertyValue<AsaObjectReference?>("MyInventoryComponent", 0, null);
                        if (inventoryRef != null)
                        {
                            Guid inventoryId = Guid.Parse(inventoryRef.Value);
                            AsaGameObject? inventoryComponent = arkSavegame.GetObjectByGuid(inventoryId);
                            if (inventoryComponent != null)
                            {




                                List<dynamic>? inventoryItemsArray = inventoryComponent.GetPropertyValue<dynamic>("InventoryItems");
                                if (inventoryItemsArray != null && inventoryItemsArray.Count > 0)
                                {
                                 
                                    foreach (var objectReference in inventoryItemsArray )
                                    {
                                        Guid itemId = Guid.Parse(objectReference.Value);
                                        AsaGameObject? itemObject = arkSavegame.GetObjectByGuid(itemId);

                                        if (itemObject != null)
                                        {
                                            var item = itemObject.AsItem();
                                            if (!item.IsEngram)
                                            {

                                                inventoryItems.Add(item);
                                            }
                                        }
                                    }
                                    


                                    

                                }

                                List<dynamic>? equippedItemsArray = inventoryComponent.GetPropertyValue<dynamic>("EquippedItems");

                                if (equippedItemsArray != null)
                                {

                                    if (x.ClassString == "TekStrider_Character_BP_C")
                                    {
                                        AsaGameObject rig1Object = equippedItemsArray[0];
                                        if (rig1Object != null)
                                        {
                                            var itemRig1 = rig1Object.AsItem();
                                            creature.Rig1 = itemRig1?.ClassName ?? "";
                                        }

                                        if (equippedItemsArray.Count > 1)
                                        {
                                            AsaGameObject rig2Object = equippedItemsArray[1];
                                            var itemRig2 = rig2Object.AsItem();
                                            creature.Rig2 = itemRig2?.ClassName ?? "";
                                        }

                                    }
                                    else
                                    {
                                        //Parallel.ForEach(equippedItemsArray, objectReference =>
                                        foreach (var objectReference in equippedItemsArray)
                                        {
                                            Guid itemId = Guid.Parse(objectReference.Value);
                                            AsaGameObject itemObject = arkSavegame.GetObjectByGuid(itemId);
                                            if (itemObject != null)
                                            {
                                                var item = itemObject.AsItem();
                                                if (!item.IsEngram)
                                                {

                                                    inventoryItems.Add(item);
                                                }
                                            }
                                        }
                                        //);
                                    }
                                }



                                List<dynamic>? inputItemsArray = inventoryComponent.GetPropertyValue<dynamic>("SortingInputs");

                                if (inputItemsArray != null)
                                {
                                    foreach (var inputItem in inputItemsArray)
                                    {
                                        ContentItem newItem = new ContentItem()
                                        {
                                            ClassName = inputItem.Value,
                                            Quantity = 1,
                                            IsInput=true
                                        };

                                        inventoryItems.Add(newItem);
                                    }
                                }

                                if (x.HasAnyProperty("FoliageGenerationInfo"))
                                {
                                    //oasisaur pool
                                    List<AsaProperty<dynamic>> foliageInfo = x.Properties.First(p=>p.Name == "FoliageGenerationInfo").Value as List<AsaProperty<dynamic>>;
                                    List<dynamic> foliageCountInfo = x.Properties.First(p => p.Name == "FoliageInventorySavedQuantities").Value as List<dynamic>;

                                    for (int i = 0; i < foliageInfo.Count; i++)
                                    {
                                        string foliageClassName = foliageInfo[i].Name;
                                        int foliageCount = foliageCountInfo[i];

                                        if (foliageCount > 0)
                                        {
                                            ContentItem invItem = new ContentItem(foliageClassName, foliageCount);
                                            inventoryItems.Add(invItem);

                                        }
                                    }
                                }



                                creature.Inventory = new ContentInventory() { Items = inventoryItems.ToList() };

                            }
                            else
                            {

                            }
                        }
                        inventoryItems.Clear();

                        if (tribe != null) tribe.Tames.Add(creature);
                    }
                }
            }
            );


            endTicks = DateTime.Now.Ticks;
            timeTaken = TimeSpan.FromTicks(endTicks - startTicks);
            logWriter.Info($"Tames parsed in: {timeTaken.ToString(@"mm\:ss")}.");

            var unclaimedTribe = fileTribes.First(x => x.TribeId == int.MinValue);
            var unclaimedBabies = unclaimedTribe.Tames.Where(x => x.IsBaby).ToList();
            if (unclaimedBabies != null && unclaimedBabies.Count > 0)
            {
                //Parallel.ForEach(unclaimedBabies, baby =>
                foreach(var baby in unclaimedBabies)
                {
                    if (baby.MotherId.HasValue)
                    {
                        //objectContainer.TryGetValue((int)baby.MotherId.Value, out GameObject babyMamma);
                        AsaGameObject? babyMamma = null;
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
                //);
            }


            //allocate tribe structures
            startTicks = DateTime.Now.Ticks;

            //var allTribeStructures = tribeStructures.AsParallel().SelectMany(x => x.Structures);
            //allTribeStructures.ForAll(x =>
            Parallel.ForEach(tribeStructures.SelectMany(x=>x.Structures),  new ParallelOptions() { MaxDegreeOfParallelism = maxCores }, x =>
            //foreach(var x in tribeStructures.SelectMany(x => x.Structures)) 
            {
                var teamId = x.GetPropertyValue<int>("TargetingTeam",0,0);
                var tribe = fileTribes.FirstOrDefault(t => t.TribeId == teamId) ?? fileTribes.FirstOrDefault(t => t.TribeId == int.MinValue); //tribe or abandoned

                logWriter.Debug($"Converting to ContentStructure: {x.ClassString}");

                ContentStructure structure = x.AsStructure();
                ConcurrentBag<ContentItem> inventoryItems = new ConcurrentBag<ContentItem>();

                structure.Latitude = (float)LoadedMap.LatShift + (structure.Y / (float)LoadedMap.LatDiv);
                structure.Longitude = (float)LoadedMap.LonShift + (structure.X / (float)LoadedMap.LonDiv);



                structure.CreatedDateTime = GetApproxDateTimeOf(structure.CreatedTimeInGame);
                if (structure.LastAllyInRangeTimeInGame != 0)
                {
                    structure.LastAllyInRangeTime = GetApproxDateTimeOf(structure.LastAllyInRangeTimeInGame);
                }


                AsaGameObject? paintingComponent = null;
                AsaObjectReference? paintingRef = x.GetPropertyValue<AsaObjectReference?>("PaintingComponent", 0, null);
                if (paintingRef != null)
                {
                    paintingComponent = arkSavegame.GetObjectByGuid(Guid.Parse(paintingRef.Value));
                    if (paintingComponent != null)
                    {
                        structure.UniquePaintingId = paintingComponent.GetPropertyValue<int>("UniquePaintingId", 0, 0);
                    }                    
                }

                //inventory
                logWriter.Debug($"Determining inventory status for: {structure.ClassName}");


                if (x.HasAnyProperty("SelectedResourceClass"))
                
                {
                    AsaObjectReference itemReference = x.GetPropertyValue<AsaObjectReference>("SelectedResourceClass", 0, null);
                    var itemClass = itemReference.Value;

                    ContentItem item = new ContentItem();
                    item.ClassName = itemClass;
                    item.Quantity = x.GetPropertyValue<int>("ResourceCount",0,0);
                    item.Rating = 0;
                    item.OwnerPlayerId = x.GetPropertyValue<int?>("OwningPlayerID",0,null)?? x.GetPropertyValue<int?>("OriginalPlacerPlayerID", 0, null)??0;

                    if (item.Quantity != 0) inventoryItems.Add(item);
                }

                if (x.GetPropertyValue<AsaObjectReference>("MyInventoryComponent") != null)
                {
                    var inventoryRefId = x.GetPropertyValue<AsaObjectReference?>("MyInventoryComponent", 0, null)?.Value ?? "";
                    Guid inventoryId = Guid.Parse(inventoryRefId);
                    AsaGameObject? inventoryComponent = arkSavegame.GetObjectByGuid(inventoryId);

                    if (inventoryComponent != null)
                    {
                        List<dynamic>? inventoryItemsArray = inventoryComponent.GetPropertyValue<dynamic>("InventoryItems", 0, null);
                        if (inventoryItemsArray != null)
                        {
                            Parallel.ForEach(inventoryItemsArray, new ParallelOptions() { MaxDegreeOfParallelism = maxCores}, objectReference =>
                            {
                                Guid itemId = Guid.Parse(objectReference.Value);
                                AsaGameObject? itemObject = arkSavegame.GetObjectByGuid(itemId);

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


                        List<dynamic>? inputItemsArray = inventoryComponent.GetPropertyValue<dynamic>("SortingInputs");

                        if (inputItemsArray != null)
                        {
                            foreach (var inputItem in inputItemsArray)
                            {
                                ContentItem newItem = new ContentItem()
                                {
                                    ClassName = inputItem.Value,
                                    Quantity = 1,
                                    IsInput = true
                                };

                                inventoryItems.Add(newItem);
                            }
                        }

                        List<dynamic>? eItemsArray = inventoryComponent.GetPropertyValue<dynamic>("EquippedItems", 0, null);
                        if (eItemsArray != null)
                        {
                            Parallel.ForEach(eItemsArray, new ParallelOptions() { MaxDegreeOfParallelism  =maxCores}, objectReference =>
                            {
                                Guid itemId = Guid.Parse(objectReference.Value);
                                AsaGameObject? itemObject = arkSavegame.GetObjectByGuid(itemId);

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
                    else
                    {

                    }


                    structure.Inventory = new ContentInventory() { Items = inventoryItems.ToList() };
                    inventoryItems.Clear();

                }

                if (tribe != null && !tribe.Structures.Contains(structure)) tribe.Structures.Add(structure);

            }
            );

            endTicks = DateTime.Now.Ticks;
            timeTaken = TimeSpan.FromTicks(endTicks - startTicks);
            logWriter.Info($"Player structures parsed in: {timeTaken.ToString(@"mm\:ss")}.");

            if (fileTribes!=null && fileTribes.Count > 0)
            {
                Tribes.AddRange(fileTribes);
            }



            startTicks = DateTime.Now.Ticks;
            DroppedItems = new List<ContentDroppedItem>();
            ConcurrentBag<ContentDroppedItem> droppedItems = new ConcurrentBag<ContentDroppedItem>();

            //..items
            Parallel.ForEach(arkSavegame.Objects.Where(o=> o.IsDroppedItem()), new ParallelOptions() { MaxDegreeOfParallelism = maxCores }, x =>
            //arkSavegame.Objects.AsParallel().Where(o=>o.IsDroppedItem()).ForAll(x =>
            {
                ContentDroppedItem droppedItem = x.AsDroppedItem();
                AsaObjectReference itemRef = x.GetPropertyValue<AsaObjectReference?>("MyItem", 0, null);

                if (itemRef != null)
                {
                    AsaGameObject? itemObject = arkSavegame.GetObjectByGuid(Guid.Parse(itemRef.Value));
                    if (itemObject != null)
                    {
                        droppedItem.ClassName = itemObject.ClassString;
                        droppedItem.IsDeathCache = itemObject.IsDeathItemCache();
                    }
                }
                droppedItem.Latitude = (float)LoadedMap.LatShift + (droppedItem.Y / (float)LoadedMap.LatDiv);
                droppedItem.Longitude = (float)LoadedMap.LonShift + (droppedItem.X / (float)LoadedMap.LonDiv);

                droppedItems.Add(droppedItem);
            }
            );
            if(droppedItems.Count > 0)
            {
                DroppedItems.AddRange(droppedItems);
            }

            endTicks = DateTime.Now.Ticks;
            timeTaken = TimeSpan.FromTicks(endTicks - startTicks);
            logWriter.Info($"Dropped items parsed in: {timeTaken.ToString(@"mm\:ss")}.");


            startTicks = DateTime.Now.Ticks;
            //.. corpses
            ConcurrentBag<ContentDroppedItem> droppedBodies = new ConcurrentBag<ContentDroppedItem>();
            Parallel.ForEach(arkSavegame.Objects.Where(x => x.IsPlayer() && x.HasAnyProperty("MyDeathHarvestingComponent")), new ParallelOptions() { MaxDegreeOfParallelism = maxCores }, x =>
            //arkSavegame.Objects.AsParallel().Where(x => x.IsPlayer() && x.HasAnyProperty("MyDeathHarvestingComponent")).ForAll(x =>
            {
                ContentDroppedItem droppedItem = x.AsDroppedItem();

                droppedItem.ClassName = x.ClassString;
                droppedItem.IsDeathCache = true;
                droppedItem.DroppedByTribeId = x.GetPropertyValue<int>("TargetingTeam", 0, 0);
                droppedItem.DroppedByPlayerId = (long)x.GetPropertyValue<ulong>("LinkedPlayerDataID", 0, 0);
                droppedItem.DroppedByName = x.GetPropertyValue<string>("PlayerName", 0, "")??"<Unknown>";
                droppedItem.Latitude = (float)LoadedMap.LatShift + (droppedItem.Y / (float)LoadedMap.LatDiv);
                droppedItem.Longitude = (float)LoadedMap.LonShift + (droppedItem.X / (float)LoadedMap.LonDiv);


                ConcurrentBag<ContentItem> corpseInventoryItems = new ConcurrentBag<ContentItem>();
                AsaObjectReference? inventoryRef = x.GetPropertyValue<AsaObjectReference?>("MyInventoryComponent", 0, null);
                if (inventoryRef != null)
                {
                    Guid inventoryId = Guid.Parse(inventoryRef.Value);
                    AsaGameObject? inventoryComponent = arkSavegame.GetObjectByGuid(inventoryId);
                    if (inventoryComponent != null)
                    {
                        List<dynamic>? inventoryItemsArray = inventoryComponent.GetPropertyValue<dynamic>("InventoryItems");
                        if (inventoryItemsArray != null && inventoryItemsArray.Count > 0)
                        {

                            Parallel.ForEach(inventoryItemsArray, new ParallelOptions() { MaxDegreeOfParallelism = maxCores }, objectReference =>
                            {
                                Guid itemId = Guid.Parse(objectReference.Value);
                                AsaGameObject? itemObject = arkSavegame.GetObjectByGuid(itemId);

                                if (itemObject != null)
                                {
                                    var item = itemObject.AsItem();
                                    if (!item.IsEngram)
                                    {

                                        corpseInventoryItems.Add(item);
                                    }
                                }
                            }
                            );


                            List<dynamic>? equippedItemsArray = inventoryComponent.GetPropertyValue<dynamic>("EquippedItems");

                            if (equippedItemsArray != null)
                            {
                                //Parallel.ForEach(equippedItemsArray, objectReference =>
                                foreach (var objectReference in equippedItemsArray)
                                {
                                    Guid itemId = Guid.Parse(objectReference.Value);
                                    AsaGameObject itemObject = arkSavegame.GetObjectByGuid(itemId);
                                    if (itemObject != null)
                                    {
                                        var item = itemObject.AsItem();
                                        if (!item.IsEngram)
                                        {

                                            corpseInventoryItems.Add(item);
                                        }
                                    }
                                }
                                //);
                            }

                            droppedItem.Inventory = new ContentInventory() { Items = corpseInventoryItems.ToList() };

                        }
                    }
                }
                corpseInventoryItems.Clear();

                droppedBodies.Add(droppedItem);                
            }
            );

            if(droppedBodies.Count > 0)
            {
                DroppedItems.AddRange(droppedBodies);                
            }

            endTicks = DateTime.Now.Ticks;
            timeTaken = TimeSpan.FromTicks(endTicks - startTicks);
            logWriter.Info($"Corpses parsed in: {timeTaken.ToString(@"mm\:ss")}.");

            startTicks = DateTime.Now.Ticks;
            //.. bags
            ConcurrentBag<ContentDroppedItem> droppedBags = new ConcurrentBag<ContentDroppedItem>();

            Parallel.ForEach(arkSavegame.Objects.Where(x => x.IsDeathItemCache()),  new ParallelOptions() { MaxDegreeOfParallelism = maxCores }, x =>
            //arkSavegame.Objects.AsParallel().Where(o => o.IsDeathItemCache()).ForAll(x =>
            {

                ContentDroppedItem droppedItem = x.AsDroppedItem();
                ConcurrentBag<ContentItem> inventoryItems = new ConcurrentBag<ContentItem>();
                droppedItem.ClassName = x.ClassString;
                droppedItem.IsDeathCache = true;

                droppedItem.Latitude = (float)LoadedMap.LatShift + (droppedItem.Y / (float)LoadedMap.LatDiv);
                droppedItem.Longitude = (float)LoadedMap.LonShift + (droppedItem.X / (float)LoadedMap.LonDiv);


                if (x.GetPropertyValue<AsaObjectReference>("MyInventoryComponent") != null)
                {
                    var inventoryRefId = x.GetPropertyValue<AsaObjectReference?>("MyInventoryComponent", 0, null)?.Value ?? "";
                    Guid inventoryId = Guid.Parse(inventoryRefId);
                    AsaGameObject? inventoryComponent = arkSavegame.GetObjectByGuid(inventoryId);

                    ConcurrentBag<ContentItem> itemInventoryItems = new ConcurrentBag<ContentItem>();
                    if (inventoryComponent != null)
                    {
                        List<dynamic>? inventoryItemsArray = inventoryComponent.GetPropertyValue<dynamic>("InventoryItems", 0, null);
                        if (inventoryItemsArray != null)
                        {
                            Parallel.ForEach(inventoryItemsArray, new ParallelOptions() { MaxDegreeOfParallelism = maxCores},  objectReference =>
                            {
                                Guid itemId = Guid.Parse(objectReference.Value);
                                AsaGameObject? itemObject = arkSavegame.GetObjectByGuid(itemId);

                                if (itemObject != null)
                                {
                                    var item = itemObject.AsItem();
                                    if (!item.IsEngram)
                                    {

                                        itemInventoryItems.Add(item);

                                    }
                                }
                            }
                            );
                        }
                    }

                    droppedItem.Inventory = new ContentInventory() { Items = itemInventoryItems.ToList() };
                    itemInventoryItems.Clear();
                }

                droppedBags.Add(droppedItem);

            });
            if(droppedBags!=null && droppedBags.Count > 0)
            {
                DroppedItems.AddRange(droppedBags.ToArray());
            }
            endTicks = DateTime.Now.Ticks;
            timeTaken = TimeSpan.FromTicks(endTicks - startTicks);
            logWriter.Info($"Drop bags parsed in: {timeTaken.ToString(@"mm\:ss")}.");

            //cleanup
            allStructures.Clear();
            allTames.Clear();
            playerStructures.Clear();
            tribeStructures.Clear();
            fileTribes?.Clear();
            fileProfiles.Clear();
        }

        private Stream GetAppropriateStream(string filename)
        {
            FileInfo fileInfo = new FileInfo(filename);
            if(fileInfo.Length > int.MaxValue)
            {
                return new FileStream(filename, FileMode.Open);
            }

            return new MemoryStream(File.ReadAllBytes(filename));            
        }

        public DateTime? GetApproxDateTimeOf(double? objectTime)
        {
            try
            {
                return objectTime.HasValue && objectTime.Value!=0
                && GameSeconds > 0 ? GameSaveTime.AddSeconds(objectTime.Value - GameSeconds) : (DateTime?)null;
            }
            catch
            {
                return (DateTime?)null;
            }

        }

        public bool Reload()
        {
            if(loadedTimestamp < File.GetLastWriteTimeUtc(loadedFilename))
            {
                LoadSaveGame(loadedFilename, string.Empty, loadedClusterFolder, profileDayLimit);
                return true;
            }

            return false;
        }






    }
}
