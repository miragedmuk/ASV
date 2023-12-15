using AsaSavegameToolkit.Extensions;
using AsaSavegameToolkit.Structs;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            saveFilename = filename;
            string savePath = Path.GetDirectoryName(saveFilename) ?? AppContext.BaseDirectory;

            sqlConnectionString = string.Concat("Data Source=", saveFilename);

            using (SqliteConnection connection = new SqliteConnection(string.Concat("Data Source=", saveFilename)))
            {
                connection.Open();

                readBaseData(connection);
                readGameData(connection);
                readActorLocations(connection);

                parseGameObjects();
                gameData.Clear(); //no longer needed, parsed into Objects as list of AsaGameObject
                //addComponents();

                parseStoredCreatures(); //held in CustomItemData as byte array for mod version of cryopods
                                        //need to parse into AsaGameObjects and add to Objects list and review when
                                        //official introduces them to see if implemented the same/similar way.

                readTribeFiles(savePath); // Search and parse and .arktribe file in the save directory
                readProfileFiles(savePath); // Search and parse and .arkprofile file in the save directory

            }
        }

        private void addComponents()
        {
            var withParentNames = Objects.Where(o=>o.ParentNames.Any()).ToList();
            foreach (var childObject in withParentNames)
            {
                Parallel.ForEach(childObject.ParentNames, parentName =>
                //foreach(var parentName in childObject.ParentNames)
                {
                    var parentObject = Objects.FirstOrDefault(o => o.Names[0] ==  parentName);
                    if (parentObject != null)
                    {
                        parentObject.AddComponent(childObject);
                    }
                }
                );
            }
        }

        private void readProfileFiles(string savePath)
        {
            ConcurrentBag<AsaProfile> profileFileBag = new ConcurrentBag<AsaProfile>();

            var profileFiles = Directory.EnumerateFiles(savePath, "*.arkprofile");
            Parallel.ForEach(profileFiles, o =>
            {
                var profileData = new AsaProfile();
                profileData.Read(o);
                profileFileBag.Add(profileData);
            }
            );

            profileData = profileFileBag.ToList();
        }

        private void readTribeFiles(string savePath)
        {
            ConcurrentBag<AsaTribe> tribeFileBag = new ConcurrentBag<AsaTribe>();

            var tribeFiles = Directory.EnumerateFiles(savePath, "*.arktribe");
            Parallel.ForEach(tribeFiles, o =>
            //foreach(var o in tribeFiles) 
            {
                var tribeData = new AsaTribe();
                tribeData.Read(o, new Dictionary<int, string>());
                tribeFileBag.Add(tribeData);
            }
            );

            tribeData = tribeFileBag.ToList();
        }

        private void parseStoredCreatures()
        {



        }

        private void readActorLocations(SqliteConnection connection)
        {
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
        }

        private void readBaseData(SqliteConnection connection)
        {

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
        }

        private void parseGameObjects()
        {
            if (gameData.Count == 0) return;
            gameObects.Clear();


            ConcurrentDictionary<Guid,AsaGameObject> asaGameObjectDictionary = new ConcurrentDictionary<Guid, AsaGameObject>();
//          ConcurrentBag<AsaGameObject> asaGameObjects = new ConcurrentBag<AsaGameObject>();

            Parallel.ForEach(gameData, new ParallelOptions { MaxDegreeOfParallelism = Convert.ToInt32(Math.Ceiling((Environment.ProcessorCount * 0.75) * 1.0)) }, objectData =>
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

                        asaGameObjectDictionary.TryAdd(objectData.Key,gameObject);

                    }
                }
            }
            );


            if (asaGameObjectDictionary.Count > 0)
            {

                var newDictionary = asaGameObjectDictionary.ToDictionary(kvp => kvp.Key,
                                                          kvp => kvp.Value,
                                                          asaGameObjectDictionary.Comparer);

                gameObects = newDictionary;
            }
            asaGameObjectDictionary.Clear();

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
