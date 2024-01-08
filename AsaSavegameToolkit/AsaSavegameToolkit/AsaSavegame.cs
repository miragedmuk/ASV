using AsaSavegameToolkit.Extensions;
using AsaSavegameToolkit.Propertys;
using AsaSavegameToolkit.Structs;
using AsaSavegameToolkit.Types;
using Ionic.Zlib;
using Microsoft.Data.Sqlite;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;

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
        Dictionary<Guid,AsaGameObject> gameObects = new Dictionary<Guid, AsaGameObject>();
        List<AsaTribe> tribeData = new List<AsaTribe>();
        List<AsaProfile> profileData = new List<AsaProfile>();
        Dictionary<Guid, byte[]> gameData = new Dictionary<Guid, byte[]>();
        Dictionary<Guid, AsaLocation> actorLocations = new Dictionary<Guid, AsaLocation>();

        public double GameTime => gameTime;

        public AsaGameObject[] Objects
        {
            get
            {
                return gameObects.Values.ToArray();
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
                return gameObects[guid];
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

        public void Read(string filename)
        {
            long startTicks = DateTime.Now.Ticks;
            long endTicks = DateTime.Now.Ticks;

            saveFilename = filename;
            string savePath = Path.GetDirectoryName(saveFilename) ?? AppContext.BaseDirectory;

            sqlConnectionString = string.Concat("Data Source=", saveFilename);

            using (SqliteConnection connection = new SqliteConnection(string.Concat("Data Source=", saveFilename)))
            {
                connection.Open();

                readBaseData(connection);
                readGameData(connection);
                readActorLocations(connection);



                connection.Close();
                connection.Dispose();
            }
            SqliteConnection.ClearAllPools();
            GC.Collect();
            GC.WaitForPendingFinalizers();

            endTicks = DateTime.Now.Ticks;
            //time to read data from db.

            parseGameObjects();
            gameData.Clear(); //no longer needed, parsed into Objects as list of AsaGameObject

            GC.Collect();
            GC.WaitForPendingFinalizers();

            //addComponents();

            parseStoredCreatures(); //held in CustomItemData as byte array for mod version of cryopods
                                    //need to parse into AsaGameObjects and add to Objects list and review when
                                    //official introduces them to see if implemented the same/similar way.

            GC.Collect();
            GC.WaitForPendingFinalizers();

            readTribeFiles(savePath); // Search and parse and .arktribe file in the save directory
            readProfileFiles(savePath); // Search and parse and .arkprofile file in the save directory

            endTicks = DateTime.Now.Ticks;
            //total time load save data
        }

        private void addComponents()
        {
            long startTicks = DateTime.Now.Ticks;
            long endTicks = DateTime.Now.Ticks;

            var withParentNames = Objects.Where(o=>o.ParentNames.Any()).ToList();
            Parallel.ForEach(withParentNames, childObject =>
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

        private void readProfileFiles(string savePath)
        {
            long startTicks = DateTime.Now.Ticks;
            long endTicks = DateTime.Now.Ticks;

            ConcurrentBag<AsaProfile> profileFileBag = new ConcurrentBag<AsaProfile>();

            IEnumerable<string> profileFiles = Directory.EnumerateFiles(savePath, "*.arkprofile");
            Parallel.ForEach(profileFiles ,o =>
            //foreach(var o in profileFiles)
            {
                var profileData = new AsaProfile();
                profileData.Read(o);
                profileFileBag.Add(profileData);
            }
            );

            profileData = profileFileBag.ToList();

            endTicks = DateTime.Now.Ticks;
            //time to read profile data

        }

        private void readTribeFiles(string savePath)
        {
            long startTicks = DateTime.Now.Ticks;
            long endTicks = DateTime.Now.Ticks;

            ConcurrentBag<AsaTribe> tribeFileBag = new ConcurrentBag<AsaTribe>();

            var tribeFiles = Directory.EnumerateFiles(savePath, "*.arktribe");
            Parallel.ForEach(tribeFiles,o =>
            //foreach(var o in tribeFiles) 
            {
                var tribeData = new AsaTribe();
                tribeData.Read(o, new Dictionary<int, string>());
                tribeFileBag.Add(tribeData);
            }
            );

            tribeData = tribeFileBag.ToList();

            endTicks = DateTime.Now.Ticks;
            //time to read tribe file data
        }

        private void parseStoredCreatures()
        {
            long startTicks = DateTime.Now.Ticks;
            long endTicks = DateTime.Now.Ticks;

            ConcurrentDictionary<Guid,AsaGameObject> objectBag = new ConcurrentDictionary<Guid, AsaGameObject>();
            var pods = Objects.Where(o => o.ClassString.Contains("Cryo") && o.Properties.Any(p => p.Name.ToLower() == "customitemdatas")).ToList();
            Parallel.ForEach(pods, pod =>
            //foreach(var pod in pods)
            {
                var customDataList = pod.Properties.FirstOrDefault(p => p.Name == "CustomItemDatas")?.Value as List<dynamic>;

                if (customDataList != null)
                {
                    foreach(List<dynamic> customData in customDataList)
                    {
                        AsaProperty<dynamic> customBytes = customData.FirstOrDefault(p => ((AsaProperty<dynamic>)p).Name == "CustomDataBytes");
                        List<dynamic>? customProperties = customBytes?.Value;
                        AsaProperty<dynamic> customContainer = customProperties[0];

                        var byteListContainer = customContainer.Value;

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

                                        if (dataStore.Objects.Count > 0)
                                        {
                                            AsaGameObject? statusComponent = dataStore.Objects.FirstOrDefault(o => o.Value.ClassString.ToLower().Contains("statuscomponent")).Value;
                                            AsaGameObject? creatureComponent = dataStore.Objects.FirstOrDefault(o => o.Value.ClassString.ToLower().Contains("character")).Value;


                                            if (creatureComponent != null)
                                            {
                                                if (objectBag.ContainsKey(creatureComponent.Guid))
                                                {
                                                    creatureComponent.Guid = Guid.NewGuid();
                                                }
                                            }

                                            if (statusComponent != null)
                                            {
                                                if (objectBag.ContainsKey(statusComponent.Guid))
                                                {
                                                    //already added, give it a new guid
                                                    statusComponent.Guid = Guid.NewGuid();

                                                    //then assign this to the creature
                                                    if (creatureComponent != null)
                                                    {
                                                        creatureComponent.Properties.RemoveAll(p => p.Name == "MyCharacterStatusComponent");
                                                        creatureComponent.Properties.Add(new Propertys.AsaProperty<dynamic>("MyCharacterStatusComponent", "ObjectProperty", 0, 0, new AsaObjectReference(statusComponent.Guid)));
                                                    }
                                                }

                                            }
                                        }

                                        foreach (var o in dataStore.Objects)
                                        {

                                            if (actorLocations.ContainsKey(o.Key))
                                            {
                                                o.Value.Location = actorLocations[o.Key];
                                            }
                                            else if (actorLocations.ContainsKey(pod.Guid))
                                            {
                                                o.Value.Location = actorLocations[pod.Guid];
                                            }
                                            else
                                            {
                                                var podContainerRef = pod.Properties.FirstOrDefault(p => p.Name == "OwnerInventory");
                                                if (podContainerRef != null)
                                                {
                                                    AsaObjectReference containerId = podContainerRef.Value;
                                                    var podContainerInventory = GetObjectByGuid(Guid.Parse(containerId.Value));
                                                    if (podContainerInventory != null)
                                                    {
                                                        var podContainer = Objects.FirstOrDefault(o => o.Names[0] == podContainerInventory.Names[1]);
                                                        if (podContainer != null)
                                                        {
                                                            o.Value.Location = podContainer.Location;
                                                        }

                                                    }
                                                }
                                            }

                                            objectBag.TryAdd(o.Value.Guid, o.Value);
                                        }

                                    }
                                    
                                }
                                catch
                                {

                                }
                            }

                        }
                    }

                }


                
            }
            );

            if(objectBag.Count > 0)
            {
                objectBag.ToList().ForEach(p=>gameObects.Add(p.Key,p.Value));
            }
            objectBag.Clear();

            endTicks = DateTime.Now.Ticks;
            //time to parse stored creatures
            var timeTaken = TimeSpan.FromTicks(endTicks-startTicks);
            Debug.Print($"parseStoredCreatures took {TimeSpan.FromTicks(endTicks - startTicks).ToString(@"mm\:ss")}");
        }

        private byte[] AddPadding(byte[] data)
        {
            byte[] result;

            using (MemoryStream ms = new MemoryStream())
            {
                foreach (byte b in data)
                {

                    
                    
                    ms.WriteByte(b);

                }

                result = new byte[ms.Length];
                Array.Copy(ms.GetBuffer(), result, ms.Length);
            }

            return result;
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
                using (SqliteDataReader reader = commandHeader.ExecuteReader())
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
            saveVersion = archive.ReadShort();
            nameTableOffset = archive.ReadInt();
            gameTime = archive.ReadDouble();

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
                        gameData.Add(guid, valueBytes);
                    }
                }
            }

            endTicks = DateTime.Now.Ticks;
            //time to read game data
        }

        private void parseGameObjects()
        {
            if (gameData.Count == 0) return;
            gameObects.Clear();

            long startTicks = DateTime.Now.Ticks;
            long endTicks = DateTime.Now.Ticks;

            ConcurrentDictionary<Guid,AsaGameObject> asaGameObjectDictionary = new ConcurrentDictionary<Guid, AsaGameObject>();

            Parallel.ForEach(gameData, new ParallelOptions { MaxDegreeOfParallelism = Convert.ToInt32(Math.Ceiling((Environment.ProcessorCount * 0.75) * 1.0)) }, objectData =>
            //foreach(var objectData in gameData) 
            //gameData.AsParallel().ForAll(objectData =>
            {
                using (var ms = new MemoryStream(objectData.Value))
                {
                    using (AsaArchive archive = new AsaArchive(ms))
                    {
                        archive.NameTable = nameTable;
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

                
                gameObects = asaGameObjectDictionary.ToDictionary(kvp => kvp.Key,
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

        private byte[] ZlibCodecDecompress(byte[] compressed)
        {
            int outputSize = 2048;
            byte[] output = new Byte[outputSize];

            // If you have a ZLIB stream, set this to true.  If you have
            // a bare DEFLATE stream, set this to false.
            bool expectRfc1950Header = true;

            using (MemoryStream ms = new MemoryStream())
            {
                ZlibCodec compressor = new ZlibCodec();
                compressor.InitializeInflate(expectRfc1950Header);

                compressor.InputBuffer = compressed;
                compressor.AvailableBytesIn = compressed.Length;
                compressor.NextIn = 0;
                compressor.OutputBuffer = output;

                foreach (var f in new FlushType[] { FlushType.None, FlushType.Finish })
                {
                    int bytesToWrite = 0;
                    do
                    {
                        compressor.AvailableBytesOut = outputSize;
                        compressor.NextOut = 0;
                        compressor.Inflate(f);

                        bytesToWrite = outputSize - compressor.AvailableBytesOut;
                        if (bytesToWrite > 0)
                            ms.Write(output, 0, bytesToWrite);
                    }
                    while ((f == FlushType.None && (compressor.AvailableBytesIn != 0 || compressor.AvailableBytesOut == 0)) ||
                           (f == FlushType.Finish && bytesToWrite != 0));
                }

                compressor.EndInflate();

                return ms.ToArray();
            }
        }
    }
}
