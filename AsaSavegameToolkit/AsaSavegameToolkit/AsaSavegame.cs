using AsaSavegameToolkit.Extensions;
using AsaSavegameToolkit.Propertys;
using AsaSavegameToolkit.Structs;
using AsaSavegameToolkit.Types;
using Microsoft.Data.Sqlite;
using System.Collections.Concurrent;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace AsaSavegameToolkit
{
    public class AsaSavegame
    {
        short saveVersion = 0;
        double gameTime = 0;
        long nameTableOffset = 0;

        string saveFilename = string.Empty;
        string sqlConnectionString = string.Empty;
        Dictionary<int, string> nameTable = new Dictionary<int, string>();
        Dictionary<Guid,AsaGameObject> gameObjects = new Dictionary<Guid, AsaGameObject>();
        List<AsaTribe> tribeData = new List<AsaTribe>();
        List<AsaProfile> profileData = new List<AsaProfile>();
        Dictionary<Guid, byte[]> gameData = new Dictionary<Guid, byte[]>();
        Dictionary<Guid, AsaLocation> actorLocations = new Dictionary<Guid, AsaLocation>();

        public double GameTime => gameTime;

        public AsaGameObject[] Objects
        {
            get
            {
                return gameObjects.Values.ToArray();
            }
        }

        public AsaLocation? GetActorLocation(Guid id)
        {
            if(actorLocations.ContainsKey(id))
            {
                return actorLocations[id];
            }
            return null;
        }

        public AsaGameObject? GetObjectByGuid(Guid guid)
        {
            try
            {
                return gameObjects[guid];
            }
            catch
            {
                return null;
            }           
            
        }

        public AsaTribe[] Tribes
        {
            get
            {
                return tribeData.ToArray();
            }
        }

        public AsaProfile[] Profiles
        {
            get
            {
                return profileData.ToArray();
            }
        }

        public List<string> DataFiles = new List<string>();

        public void Read(string filename, int maxCores)
        {
            long startTicks = DateTime.Now.Ticks;
            long endTicks = DateTime.Now.Ticks;

            saveFilename = filename;
            string savePath = Path.GetDirectoryName(saveFilename) ?? AppContext.BaseDirectory;

            sqlConnectionString = string.Concat("Data Source=", saveFilename, ";Filename=", saveFilename, ";Mode=ReadOnly");

            using (SqliteConnection connection = new SqliteConnection(sqlConnectionString))
            {
                connection.Open();

                readBaseData(connection);
                readGameData(connection);
                readActorLocations(connection);
                readStoredTribesAndPlayers(connection);

                connection.Close();
                connection.Dispose();
            }
            SqliteConnection.ClearAllPools();
            GC.Collect();
            GC.WaitForPendingFinalizers();

            endTicks = DateTime.Now.Ticks;
            //time to read data from db.

            parseGameObjects(maxCores);


            gameData.Clear(); //no longer needed, parsed into Objects as list of AsaGameObject

            GC.Collect();
            GC.WaitForPendingFinalizers();

            //addComponents();

            parseStoredCreatures(maxCores); //held in CustomItemData as byte array with some custom compression



            GC.Collect();
            GC.WaitForPendingFinalizers();

            if(tribeData.Count == 0)
            {
                //not loaded from .ark, load from .arktribe files
                readTribeFiles(savePath, maxCores); // Search and parse and .arktribe file in the save directory
            }

            if (profileData.Count == 0)
            {
                //not loaded from .ark, load from .arkprofile files
                readProfileFiles(savePath, maxCores); // Search and parse and .arkprofile file in the save directory
            }            

            endTicks = DateTime.Now.Ticks;
            //total time load save data
        }

        private void addComponents(int maxCores)
        {
            long startTicks = DateTime.Now.Ticks;
            long endTicks = DateTime.Now.Ticks;

            var withParentNames = Objects.Where(o=>o.ParentNames.Any()).ToList();
            Parallel.ForEach(withParentNames, new ParallelOptions() {MaxDegreeOfParallelism = maxCores },  childObject =>
            {
                //Parallel.ForEach(childObject.ParentNames, parentName =>
                foreach (var parentName in childObject.ParentNames)
                {
                    var parentObject = Objects.FirstOrDefault(o => o.Names[0] == parentName);
                    if (parentObject != null)
                    {
                        parentObject.AddComponent(childObject);
                    }
                }
                //);
            }
            );

            endTicks = DateTime.Now.Ticks;
            //time to add components

        }

        private void readProfileFiles(string savePath, int maxCores)
        {
            long startTicks = DateTime.Now.Ticks;
            long endTicks = DateTime.Now.Ticks;

            ConcurrentBag<AsaProfile> profileFileBag = new ConcurrentBag<AsaProfile>();

            IEnumerable<string> profileFiles = Directory.EnumerateFiles(savePath, "*.arkprofile");
            Parallel.ForEach(profileFiles, new ParallelOptions() {  MaxDegreeOfParallelism = maxCores}, o =>
            //foreach(var o in profileFiles)
            {
                try
                {

                    var profileData = new AsaProfile();
                    profileData.Read(o);
                    profileFileBag.Add(profileData);

                }
                catch 
                { 

                }

            }
            );

            profileData = profileFileBag.ToList();



            endTicks = DateTime.Now.Ticks;
            //time to read profile data

        }

        private void readTribeFiles(string savePath, int maxCores)
        {
            long startTicks = DateTime.Now.Ticks;
            long endTicks = DateTime.Now.Ticks;

            ConcurrentBag<AsaTribe> tribeFileBag = new ConcurrentBag<AsaTribe>();

            var tribeFiles = Directory.EnumerateFiles(savePath, "*.arktribe");
            Parallel.ForEach(tribeFiles, new ParallelOptions() { MaxDegreeOfParallelism = maxCores }, o =>
            //foreach(var o in tribeFiles) 
            {
                try
                {
                    var tribeData = new AsaTribe();
                    tribeData.Read(o, new Dictionary<int, string>());
                    tribeFileBag.Add(tribeData);
                }
                catch
                {

                }

            }
            );

            tribeData = tribeFileBag.ToList();

            endTicks = DateTime.Now.Ticks;
            //time to read tribe file data
        }

        private void parseStoredCreatures(int maxCores)
        {
            long startTicks = DateTime.Now.Ticks;
            long endTicks = DateTime.Now.Ticks;

            ConcurrentDictionary<Guid,AsaGameObject> objectBag = new ConcurrentDictionary<Guid, AsaGameObject>();

            var inventoryContainers = Objects.Where(o => o.Properties.Any(p => p.Name.Equals("MyInventoryComponent"))).ToList();

            var pods = Objects.Where(o => (o.ClassString.Contains("Cryo") || o.ClassString.Contains("Dinoball")) && o.Properties.Any(p => p.Name.ToLower() == "customitemdatas"));
            Parallel.ForEach(pods, new ParallelOptions() { MaxDegreeOfParallelism = maxCores }, pod =>
            //foreach(var pod in pods)
            {
                var customDataList = pod.Properties.Find(p => p.Name == "CustomItemDatas")?.Value as List<dynamic>;

                if (customDataList != null)
                {
                    foreach(List<dynamic> customData in customDataList)
                    {
                        AsaProperty<dynamic> customBytes = customData.Find(p => ((AsaProperty<dynamic>)p).Name == "CustomDataBytes");
                        List<dynamic>? customProperties = customBytes?.Value;
                        AsaProperty<dynamic> customContainer = customProperties[0];

                        var byteListContainer = customContainer.Value;
                        AsaGameObject creatureObject = null;
                        AsaGameObject statusObject = null;

                        Guid inventoryGuid = Guid.NewGuid();
                        List<Guid> inventoryItems = new List<Guid>();

                        for (int i = 0; i < byteListContainer.Count; i++)
                        {
                            List<dynamic> byteList = byteListContainer[i];
                            List<dynamic> byteObjectData = (byteList.First() as AsaProperty<dynamic>).Value;

                            if (byteObjectData.Count > 0)
                            {
                                byte[] dataBytes = new byte[byteObjectData.Count];
                                for (int x = 0; x < byteObjectData.Count; x++)
                                {
                                    dataBytes[x] = byteObjectData[x];
                                }


                                try
                                {
                                    if(i == 0)
                                    {
                                        var dataStore = new AsaDataStore(dataBytes);


                                        if(dataStore.Objects.Count == 0)
                                        {
                                            break;
                                        }

                                        
                                        statusObject = dataStore.Objects.FirstOrDefault(c => c.Value.ClassName.Name.Contains("statuscomponent", StringComparison.CurrentCultureIgnoreCase)).Value;
                                        if (statusObject == null)
                                        {
                                            statusObject = dataStore.Objects.FirstOrDefault(c => c.Value.ClassName.Name.Contains("status", StringComparison.CurrentCultureIgnoreCase)).Value;
                                        }
                                        creatureObject = dataStore.Objects.First(c => c.Key != statusObject.Guid).Value;

                                        var podContainerRef = pod.Properties.Find(p => p.Name == "OwnerInventory");
                                        if (podContainerRef != null)
                                        {
                                            AsaObjectReference containerId = podContainerRef.Value;
                                            var podContainerInventory = GetObjectByGuid(Guid.Parse(containerId.Value));
                                            if (podContainerInventory != null)
                                            {
                                                
                                                var podContainer = inventoryContainers.Find(o =>  o.Names[0].Equals( podContainerInventory.Names[1]));
                                                if (podContainer != null)
                                                {
                                                    creatureObject.Location = podContainer.Location;
                                                    if(creatureObject.Properties.Any(c=>c.Name == "TargetingTeam") && podContainer.Properties.Any(p => p.Name == "TargetingTeam"))
                                                    {
                                                        creatureObject.Properties.RemoveAll(p => p.Name == "TargetingTeam");
                                                        creatureObject.Properties.Add(podContainer.Properties.First(p => p.Name == "TargetingTeam"));
                                                    }

                                                    if (creatureObject.Properties.LongCount(c => c.Name == "TribeName") > 0)
                                                    {
                                                        creatureObject.Properties.RemoveAll(p => p.Name == "TribeName");
                                                    }


                                                }
                                                
                                            }
                                        }


                                        foreach (var o in dataStore.Objects)
                                        {
                                            if (actorLocations.ContainsKey(pod.Guid))
                                            {
                                                o.Value.Location = actorLocations[pod.Guid];
                                            }

                                            objectBag.TryAdd(o.Value.Guid, o.Value);
                                        }




                                    }
                                    else
                                    {
                                        if (dataBytes.Length < 8) continue;

                                        List<AsaProperty<dynamic>> properties = new List<AsaProperty<dynamic>>();
                                        //skins/costumes/inventory
                                        using(Stream stream = new MemoryStream(dataBytes)) 
                                        { 
                                            using(AsaArchive dataArchive = new AsaArchive(stream))
                                            {
                                                var archiveVersion = dataArchive.ReadInt();
                                                AsaProperty<dynamic>? prop = null;
                                                try
                                                {
                                                    prop = AsaPropertyRegistry.ReadProperty(dataArchive);                                                
                                                }catch
                                                {

                                                }

                                                while(prop!=null)
                                                {
                                                    properties.Add(prop);
                                                    try
                                                    {
                                                        prop = AsaPropertyRegistry.ReadProperty(dataArchive);
                                                    }
                                                    catch
                                                    {
                                                        break;
                                                    }                                                   
                                                }
                                            }
                                        
                                        }

                                        if(properties.Count > 0)
                                        {
                                            properties.Add(new AsaProperty<dynamic>("OwnerInventory", "ObjectProperty", 0, 0, new AsaObjectReference(inventoryGuid)));
                                            AsaGameObject asaObject = new AsaGameObject(properties);
                                            inventoryItems.Add(asaObject.Guid);
                                            objectBag.TryAdd(asaObject.Guid, asaObject);
                                        }
                                    }
                                    
                                }
                                catch
                                {

                                }
                            }

                        }


                        if(inventoryItems.Count > 0)
                        {
                            //InventoryItems
                            var inventoryItemReferences = new List<object>();
                            foreach (var itemGuid in inventoryItems)
                            {
                                inventoryItemReferences.Add(new AsaObjectReference(itemGuid));    
                            }
                            var inventoryItemContainer = new AsaProperty<dynamic>("InventoryItems", "ArrayProperty", 0, 0, inventoryItemReferences);


                            List<AsaProperty<dynamic>> inventoryProperties = new List<AsaProperty<dynamic>>();
                            
                            inventoryProperties.Add(inventoryItemContainer);
                            inventoryProperties.Add(new AsaProperty<dynamic>("bInitializedMe", "BoolProperty", 0, 0, true));
                            inventoryProperties.Add(new AsaProperty<dynamic>("ItemArchetype", "ObjectProperty", 0, 0, new AsaObjectReference("PrimalInventor yBP_StoredCreature")));

                            var inventoryComponent = new AsaGameObject(inventoryGuid, inventoryProperties);
                            objectBag.TryAdd(inventoryGuid, inventoryComponent);

                            if (creatureObject != null)
                            {
                                creatureObject.Properties.Add(new AsaProperty<dynamic>("MyInventoryComponent", "ObjectProperty", 0, 0, new AsaObjectReference(inventoryGuid)));
                            }                          
                            

                        }

                    }

                }


                
            }
            );

            if(objectBag.Count > 0)
            {
                objectBag.ToList().ForEach(p=>gameObjects.Add(p.Key,p.Value));
            }
            objectBag.Clear();

            endTicks = DateTime.Now.Ticks;
            //time to parse stored creatures
            var timeTaken = TimeSpan.FromTicks(endTicks-startTicks);
            Debug.Print($"parseStoredCreatures took {TimeSpan.FromTicks(endTicks - startTicks).ToString(@"mm\:ss")}");
        }

        private void readStoredTribesAndPlayers(SqliteConnection connection)
        {
            tribeData = new List<AsaTribe>();
            profileData = new List<AsaProfile>();

            using (SqliteCommand commandCustom = new SqliteCommand("SELECT value from custom WHERE key = 'GameModeCustomBytes'"))
            {
                commandCustom.Connection = connection;
                using (SqliteDataReader readerCustom = commandCustom.ExecuteReader())
                {
                    while (readerCustom.Read())
                    {
                        byte[] customObjects = GetSqlBytes(readerCustom, 0);
                        using (MemoryStream ms = new MemoryStream(customObjects))
                        {
                            using (AsaArchive archive = new AsaArchive(ms))
                            {
                                var ds = new AsaTribeStore(archive);
                                if (ds.Tribes.Count > 0)
                                {
                                    tribeData.AddRange(ds.Tribes);
                                }
                                if (ds.Profiles.Count > 0)
                                {
                                    profileData.AddRange(ds.Profiles);
                                }
                            }
                        }

                        break;
                    }
                }
            }
        }

         private void readActorLocations(SqliteConnection connection)
         {
            long startTicks = DateTime.Now.Ticks;
            long endTicks = DateTime.Now.Ticks;

            using (SqliteCommand commandLocations = new SqliteCommand("SELECT value from custom WHERE key = 'ActorTransforms'"))
            {
                commandLocations.Connection = connection;
                using (SqliteDataReader readerLocations = commandLocations.ExecuteReader())
                {
                    while (readerLocations.Read())
                    {
                        byte[] locationObjects = GetSqlBytes(readerLocations, 0);
                        using (MemoryStream ms = new MemoryStream(locationObjects))
                        {
                            using (AsaArchive archive = new AsaArchive(ms))
                            {
                                Guid objectId = GuidExtensions.ToGuid(archive.ReadBytes(16));
                                while (objectId != Guid.Empty)
                                {
                                    var locX = archive.ReadDouble();
                                    var locY = archive.ReadDouble();
                                    var locZ = archive.ReadDouble();

                                    var locPitch = archive.ReadDouble();
                                    var locYaw = archive.ReadDouble();
                                    var locRoll = archive.ReadDouble();

                                    archive.SkipBytes(8);

                                    actorLocations.Add(objectId, new AsaLocation(locX, locY, locZ, locPitch, locYaw, locRoll));

                                    //next
                                    objectId = GuidExtensions.ToGuid(archive.ReadBytes(16));
                                }
                            }
                        }

                        break;
                    }
                }
            }

            endTicks = DateTime.Now.Ticks;
            //time to read actor location data
        }

        private void readBaseData(SqliteConnection connection)
        {
            long startTicks = DateTime.Now.Ticks;
            long endTicks = DateTime.Now.Ticks;

            using (SqliteCommand commandHeader = new SqliteCommand("SELECT value from custom WHERE key = 'SaveHeader'"))
            {
                commandHeader.Connection = connection;

                //read header
                using ( SqliteDataReader reader = commandHeader.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var dataBytes = GetSqlBytes(reader, 0);
                        using (MemoryStream ms = new MemoryStream(dataBytes))
                        {
                            using (AsaArchive archive = new AsaArchive(ms))
                            {
                                readHeader(archive);
                                readParts(archive);
                                readNametable(archive);
                            }
                        }

                    }
                }
            }

            endTicks = DateTime.Now.Ticks;
            //time to read header information
        }
        private void readHeader(AsaArchive archive)
        {
            var unknownInt1 = 0;
            var unknownInt2 = 0;
            
            saveVersion = archive.ReadShort();
            nameTableOffset = archive.ReadInt();
            gameTime = archive.ReadDouble();

            if (saveVersion > 11)
            {
                unknownInt1 = archive.ReadInt(); //582
            }

        }

        private void readParts(AsaArchive archive)
        {
            DataFiles.Clear();

            var dataFileCount = archive.ReadInt();
            while (dataFileCount-- > 0)
            {
                var nameString = archive.ReadString();
                var recordTerminator = archive.ReadInt(); // seems to always be -1

                DataFiles.Add(nameString);
            }

            //next looks to me more map/data file names as per previous but can't work it out....
            var unknown1 = archive.ReadInt();
            var unknown2 = archive.ReadInt();
        }

        private void readNametable(AsaArchive archive)
        {
            nameTable.Clear();

            archive.Position = nameTableOffset;

            var nameCount = archive.ReadInt();

            while (nameCount-- > 0)
            {
                var nameIndex = archive.ReadInt();
                var nameString = archive.ReadString();

                if (nameString.Any(s => s == '.'))
                {
                    nameString = nameString.Substring(nameString.LastIndexOf('.') + 1);
                }

                nameTable.Add(nameIndex, nameString);
            }
        }


        private void readGameData(SqliteConnection connection)
        {
            long startTicks = DateTime.Now.Ticks;
            long endTicks = DateTime.Now.Ticks;

            using (SqliteCommand commandData = new SqliteCommand("SELECT key, value FROM game"))
            {
                commandData.Connection = connection;
                using (SqliteDataReader readerData = commandData.ExecuteReader())
                {
                    while (readerData.Read())
                    {
                        byte[] keyBytes = GetSqlBytes(readerData, 0);
                        Guid guid = GuidExtensions.ToGuid(keyBytes);

                        byte[] valueBytes = GetSqlBytes(readerData, 1);
                        try
                        {
                            gameData.Add(guid, valueBytes);
                        }
                        catch
                        {

                        }
                        
                    }
                }
            }

            endTicks = DateTime.Now.Ticks;
            //time to read game data
        }

        private void parseGameObjects(int maxCores)
        {
            if (gameData.Count == 0) return;
            gameObjects.Clear();

            long startTicks = DateTime.Now.Ticks;
            long endTicks = DateTime.Now.Ticks;

            ConcurrentDictionary<Guid,AsaGameObject> asaGameObjectDictionary = new ConcurrentDictionary<Guid, AsaGameObject>();

            Parallel.ForEach(gameData, new ParallelOptions { MaxDegreeOfParallelism = maxCores }, objectData =>
            //foreach(var objectData in gameData) 
            //gameData.AsParallel().ForAll(objectData =>
            {
                using (var ms = new MemoryStream(objectData.Value))
                {
                    using (AsaArchive archive = new AsaArchive(ms))
                    {
                        archive.NameTable = nameTable;
                        archive.SaveVersion = saveVersion;
                        var gameObject = new AsaGameObject(objectData.Key, archive);

                        if (actorLocations.ContainsKey(objectData.Key))
                        {
                            gameObject.Location = actorLocations[objectData.Key];
                        }

                        if (asaGameObjectDictionary.ContainsKey(gameObject.Guid))
                        {
                            gameObject.Guid = Guid.NewGuid();
                        }

                        asaGameObjectDictionary.TryAdd(gameObject.Guid, gameObject);
                    }
                }
            }
            );

            if (asaGameObjectDictionary.Count > 0)
            {

                
                gameObjects = asaGameObjectDictionary.ToDictionary(kvp => kvp.Key,
                                                          kvp => kvp.Value); 
            }
            asaGameObjectDictionary.Clear();

            endTicks = DateTime.Now.Ticks;
            Debug.Print($"parseGameObjects took {TimeSpan.FromTicks(endTicks - startTicks).ToString(@"mm\:ss")}");
            //time to parse game objects
        }


        private byte[] GetSqlBytes(SqliteDataReader reader, int fieldIndex)
        {
            const int CHUNK_SIZE = 2 * 1024;
            byte[] buffer = new byte[CHUNK_SIZE];
            long bytesRead;
            long fieldOffset = 0;
            using (MemoryStream stream = new MemoryStream())
            {
                while ((bytesRead = reader.GetBytes(fieldIndex, fieldOffset, buffer, 0, buffer.Length)) > 0)
                {
                    stream.Write(buffer, 0, (int)bytesRead);
                    fieldOffset += bytesRead;
                }
                return stream.ToArray();
            }
        
        }
    }
}
