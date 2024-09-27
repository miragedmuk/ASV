using System.Collections;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Net.Mail;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Xml;
using Microsoft.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Arrays;
using SavegameToolkit.Propertys;
using SavegameToolkit.Structs;
using SavegameToolkit.Types;


namespace SavegameToolkit
{

    public class ArkSavegame : GameObjectContainerMixin, IConversionSupport
    {
        
        public short SaveVersion { get; private set; }
        public DateTime FileTime { get; set; } = DateTime.Now;
        public float GameTime { get; private set; }
        public int SaveCount { get; private set; }
        public List<string> OldNameList { get; private set; }
        public List<string> DataFiles { get; } = new List<string>();
        public List<EmbeddedData> EmbeddedData { get; } = new List<EmbeddedData>();
        public Dictionary<int, List<string[]>> DataFilesObjectMap { get; } = new Dictionary<int, List<string[]>>();
        public override List<GameObject> Objects { get; } = new List<GameObject>();
        
        public List<Tuple<long,long>> StoredDataOffsets = new List<Tuple<long,long>>();
        
        private ChunkedStore TribeDataStore { get; set; } = new ChunkedStore();
        private ChunkedStore PlayerDataStore { get; set; } = new ChunkedStore();


        private int hibernationOffset;
        private int nameTableOffset;
        private int propertiesBlockOffset;
        private int hibernationV8Unknown1;
        private int hibernationV8Unknown2;
        private int hibernationV8Unknown3;
        private int hibernationV8Unknown4;
        private int hibernationUnknown1;
        private int hibernationUnknown2;
        private readonly List<string> hibernationClasses = new List<string>();
        private readonly List<int> hibernationIndices = new List<int>();

        public List<HibernationEntry> HibernationEntries { get; } = new List<HibernationEntry>();
        public List<GameObject> Tribes { get; } = new List<GameObject>();
        public List<GameObject> Profiles { get; } = new List<GameObject>();

        public bool HasUnknownNames => OldNameList != null;

        public bool HasUnknownData { get; set; }


        #region storedCreatures

        private void extractBinaryObjectStoredCreatures(ReadingOptions options)
        {
            if (!options.StoredCreatures) return;

            if(SaveVersion == 11)
            {
                //v11 has completely different cryopod creature storage 
                




                
                return;
            }

            
            //pre v11 - do the original cryopod creature data load
            long identifyStart = DateTime.Now.Ticks;
            var validStored = Objects.Where(o =>
                    (o.ClassName.Name.Contains("Cryopod") || o.ClassString.Contains("SoulTrap_") || o.ClassString.Contains("Vivarium_"))
                    && o.GetPropertyValue<IArkArray, ArkArrayStruct>("CustomItemDatas") is ArkArrayStruct customItemDatas
                    && customItemDatas?.FirstOrDefault(cd => ((StructPropertyList)cd).GetTypedProperty<PropertyName>("CustomDataName").Value.Name == "Dino") is StructPropertyList customDinoData
                    && customDinoData?.GetTypedProperty<PropertyStruct>("CustomDataBytes")?.Value is StructPropertyList customDataBytes
                    && customDataBytes?.GetTypedProperty<PropertyArray>("ByteArrays")?.Value != null
            ).ToList();

            long identifyEnd = DateTime.Now.Ticks;
            var timeTaken2 = TimeSpan.FromTicks(identifyEnd - identifyStart);
            Console.WriteLine($"Stored containers identified in {timeTaken2.ToString()}");

            //narrow our search list down for inventory components to help improve performance
            var inventoryContainers = Objects.Where(x => x.GetPropertyValue<ObjectReference>("MyInventoryComponent") != null).ToList();

            
            //var deadPods = validStored.Where(s=>s.GetPropertyValue<float>("SavedDurability", 0,0) <= 0).ToList();

            ConcurrentBag <Tuple<GameObject, GameObject>> cbStored = new ConcurrentBag<Tuple<GameObject, GameObject>>();
            //foreach (var storedPod in validStored)
            Parallel.ForEach(validStored, storedPod =>
            {
                ArkArrayStruct customItemDatas = storedPod.GetPropertyValue<IArkArray, ArkArrayStruct>("CustomItemDatas");
                StructPropertyList customDinoData = (StructPropertyList)customItemDatas?.FirstOrDefault(cd => ((StructPropertyList)cd).GetTypedProperty<PropertyName>("CustomDataName").Value.Name == "Dino");
                PropertyStruct customDataBytes = customDinoData?.Properties.FirstOrDefault(p => p.NameString == "CustomDataBytes") as PropertyStruct;

                PropertyArray byteArrays = (customDataBytes?.Value as StructPropertyList)?.Properties.FirstOrDefault(property => property.NameString == "ByteArrays") as PropertyArray;
                ArkArrayStruct byteArraysValue = byteArrays?.Value as ArkArrayStruct;
                if ((byteArraysValue?.Any() ?? false))
                {
                    ArkArrayUInt8 creatureBytes = ((byteArraysValue?[0] as StructPropertyList)?.Properties.FirstOrDefault(p => p.NameString == "Bytes") as PropertyArray)?.Value as ArkArrayUInt8;
                    if (creatureBytes != null)
                    {
                        using (var cryoStream = new MemoryStream(creatureBytes.ToArray<byte>()))
                        {
                            using (ArkArchive cryoArchive = new ArkArchive(cryoStream))
                            {
                                // number of serialized objects
                                int objCount = cryoArchive.ReadInt();
                                if (objCount != 0)
                                {
                                    var storedGameObjects = new List<GameObject>(objCount);
                                    for (int oi = 0; oi < objCount; oi++)
                                    {
                                        storedGameObjects.Add(new GameObject(cryoArchive));
                                    }

                                    foreach (var ob in storedGameObjects)
                                    {
                                        try
                                        {
                                            ob.LoadProperties(cryoArchive, new GameObject(), 0);
                                        }
                                        catch
                                        {
                                            //ignore and continue

                                        }
                                        
                                    }

                                    if(storedGameObjects!=null && storedGameObjects.Count > 0) 
                                    {
                                        var creatureObject = storedGameObjects[0];
                                        GameObject statusObject = storedGameObjects.FirstOrDefault(o => o.ClassString.Contains("DinoCharacterStatus"));
                                        if (statusObject == null)
                                        {
                                            statusObject = storedGameObjects.FirstOrDefault(o => o.ClassString.Contains("status", StringComparison.CurrentCultureIgnoreCase));
                                        }

                                        if(statusObject!= null)
                                        {

                                            // assume the first object is the creature object
                                            string creatureActorId = creatureObject.Names[0].ToString();

                                            if (storedPod.ClassString.Contains("Vivarium"))
                                            {
                                                //vivarium
                                                creatureObject.IsInVivarium = true;
                                            }
                                            else
                                            {
                                                creatureObject.IsInCryo = true;
                                            }

                                            // the tribe name is stored in `TamerString`, non-cryoed creatures have the property `TribeName` for that.
                                            if (creatureObject.GetPropertyValue<string>("TribeName")?.Length == 0 && creatureObject.GetPropertyValue<string>("TamerString")?.Length > 0)
                                                creatureObject.Properties.Add(new PropertyString("TribeName", creatureObject.GetPropertyValue<string>("TamerString")));



                                            //get parent of cryopod owner inventory
                                            var podParentRef = storedPod.GetPropertyValue<ObjectReference>("OwnerInventory");
                                            if (podParentRef != null)
                                            {
                                                var podParent = inventoryContainers.FirstOrDefault(o => o.GetPropertyValue<ObjectReference>("MyInventoryComponent")?.ObjectId == podParentRef.ObjectId);

                                                //determine if we need to re-team the podded animal
                                                if (podParent != null)
                                                {
                                                    if (podParent.ClassString.Contains("_Vivarium"))
                                                    {
                                                        creatureObject.IsInCryo = false;
                                                        creatureObject.IsInVivarium = true;
                                                    }

                                                    creatureObject.Location = podParent.Location;

                                                    int obTeam = creatureObject.GetPropertyValue<int>("TargetingTeam");
                                                    int containerTeam = podParent.GetPropertyValue<int>("TargetingTeam");
                                                    if (obTeam != containerTeam)
                                                    {
                                                        var propertyIndex = creatureObject.Properties.FindIndex(i => i.NameString == "TargetingTeam");
                                                        if (propertyIndex != -1)
                                                        {
                                                            creatureObject.Properties.RemoveAt(propertyIndex);
                                                        }
                                                        creatureObject.Properties.Add(new PropertyInt("TargetingTeam", containerTeam));


                                                        if (creatureObject.HasAnyProperty("TamingTeamID"))
                                                        {
                                                            creatureObject.Properties.RemoveAt(creatureObject.Properties.FindIndex(i => i.NameString == "TamingTeamID"));
                                                            creatureObject.Properties.Add(new PropertyInt("TamingTeamID", containerTeam));
                                                        }

                                                    }
                                                }
                                            }
                                            cbStored.Add(new Tuple<GameObject, GameObject>(creatureObject, statusObject));

                                        }
                                    }

                                    
                                }

                            }
                        }                         
                    }
                }
            }
            );

            long propertyEnd = DateTime.Now.Ticks;
            var timeTaken3 = TimeSpan.FromTicks(propertyEnd - identifyEnd);
            Console.WriteLine($"Properties loaded in {timeTaken3.ToString()}");

            if (cbStored != null && cbStored.Count > 0)
            {
                foreach (var t in cbStored)
                {
                    var creatureObject = t.Item1;
                    var statusObject = t.Item2;


                    addObject(statusObject, false);

                    if (statusObject != null)
                    {
                        var statusComponentRef = creatureObject.GetTypedProperty<PropertyObject>("MyCharacterStatusComponent");
                        if(statusComponentRef != null)
                        {
                            statusComponentRef.Value.ObjectId = statusObject.Id;
                        }
                        
                    }

                    addObject(creatureObject, false);
                }

            }
            long addEnd = DateTime.Now.Ticks;
            var timeTaken4 = TimeSpan.FromTicks(addEnd - propertyEnd);
            Console.WriteLine($"Objects added in {timeTaken4.ToString()}");
        }



        class StoredOffsetItemPointer
        {
            public GameObject ParentObject { get; set; }
            public long ObjectOffset { get; set;}
        }


        private void readBinaryStoredObjects(ArkArchive archive, ReadingOptions options)
        {

            if (!options.StoredCreatures) return;

            

            var validStored = Objects.AsParallel()
                .Where(o =>
                        (o.ClassString.Contains("Cryopod") || o.ClassString.Contains("SoulTrap_") || o.ClassString.Contains("Vivarium_"))
                        && o.GetTypedProperty<PropertyArray>("CustomItemDatas") !=null 
                )
                .ToList();


            //create and initialise dictionary to hold the offset data.
            Dictionary<int, List<StoredOffsetItemPointer>> storedItemsWithOffsets = new Dictionary<int, List<StoredOffsetItemPointer>>();
            for(int i = 0; i < StoredDataOffsets.Count; i++)
            {
                storedItemsWithOffsets.Add(i, new List<StoredOffsetItemPointer>());
            }

            validStored.ForEach(x =>
            {
                if (!(x.Properties.First(p => p.NameString == "CustomItemDatas") is PropertyArray customData)) return;

                long cryoDataOffset = 0;
                int dataFile = 1;
                try
                {
                    if (
                        archive.SaveVersion > 10
                        && customData.Value is ArkArrayStruct redirectors
                        && redirectors.All(r => r is StructCustomItemDataRef)
                        )
                    {
                        // cryopods use the first redirector, soulballs use the second
                        var redirectorIndex = x.ClassString.Contains("cryopod", StringComparison.InvariantCultureIgnoreCase) ? 0 : 1;
                        if(redirectorIndex < redirectors.Count)
                        {
                            cryoDataOffset = ((StructCustomItemDataRef)redirectors[redirectorIndex]).Position;
                            dataFile = ((StructCustomItemDataRef)redirectors[redirectorIndex]).StoreDataIndex;

                            //store to be read-in forward-only for performance.
                            storedItemsWithOffsets[dataFile].Add(new StoredOffsetItemPointer() { ParentObject = x, ObjectOffset = cryoDataOffset });
                        }
                    }
                }
                catch
                {
                    //ignore, issue reading this cryo's data.
                }
            });
            validStored = null;
            

            
            // parse stored data in offset order, adding parsed objects to list
            // to allow the slower re-parenting and addition to the Objects collection
            // to be done after the file read.
            List<Tuple<GameObject,GameObject,GameObject,GameObject>> addedCryoObjects = new List<Tuple<GameObject,GameObject, GameObject, GameObject>>();
            for(int fileIndex = 0; fileIndex < storedItemsWithOffsets.Count; fileIndex++)
            {
                if (storedItemsWithOffsets[fileIndex].Count > 0)
                {
                    var sortedOffsetItems = storedItemsWithOffsets[fileIndex].OrderBy(o=>o.ObjectOffset).ToList();

                    for (int x = 0; x < sortedOffsetItems.Count; x++)
                    {
                        var storedObject = sortedOffsetItems[x];
                        var offsetData = StoredDataOffsets[fileIndex];

                        var storedOffset = offsetData.Item1 + storedObject.ObjectOffset;
                        long nextOffset = offsetData.Item1 + offsetData.Item2;
                        if (x < sortedOffsetItems.Count - 1)
                        {
                            int nextItemIndex = x + 1;
                            var nextItem = sortedOffsetItems[nextItemIndex];
                            nextOffset = nextItem.ObjectOffset + offsetData.Item1;
                        }

                        archive.Position = storedOffset;
                        ArkCryoStore testStore = new ArkCryoStore(archive);
                        if (testStore.Objects.Any())
                        {
                            try
                            {
                                testStore.LoadProperties(archive);

                                //Store all required GameObjects to correctly read in this cryo creature
                                addedCryoObjects.Add(new Tuple<GameObject, GameObject, GameObject, GameObject>(storedObject.ParentObject, testStore.CreatureComponent, testStore.StatusComponent, testStore.InventoryComponent));

                            }
                            catch (Exception exProperty)
                            {

                            }
                            

                        }
                    }
                }
            }

            //limit Object filter to inventory containers only
            var inventoryContainers = Objects.AsParallel().Where(x => x.GetPropertyValue<ObjectReference?>("MyInventoryComponent") != null).ToList();
            if(addedCryoObjects.Count > 0)
            {
                Parallel.ForEach(addedCryoObjects, cryoObjects =>
                {
                    var cryoObject = cryoObjects.Item1;
                    var dinoComponent = cryoObjects.Item2;
                    var dinoCharacterStatusComponent = cryoObjects.Item3;
                    var dinoInventoryComponent = cryoObjects.Item4;

                    if (dinoComponent == null) return;

                    dinoComponent.IsInCryo = !cryoObject.ClassString.Contains("vivarium", StringComparison.InvariantCultureIgnoreCase);
                    dinoComponent.IsInVivarium = cryoObject.ClassString.Contains("vivarium", StringComparison.InvariantCultureIgnoreCase);

                    // the tribe name is stored in `TamerString`, non-cryoed creatures have the property `TribeName` for that.
                    if (dinoComponent.GetPropertyValue<string>("TribeName",0,"").Length == 0 && dinoComponent.GetPropertyValue<string>("TamerString",0,"").Length > 0)
                    {
                        dinoComponent.Properties.Add(new PropertyString("TribeName", dinoComponent.GetPropertyValue<string>("TamerString")));
                    }
                    


                    //get parent of cryopod owner inventory
                    var podParentRef = cryoObject.GetPropertyValue<ObjectReference>("OwnerInventory");
                    if (podParentRef != null)
                    {
                        var podParent = inventoryContainers.FirstOrDefault(o => o.GetPropertyValue<ObjectReference?>("MyInventoryComponent")?.ObjectId == podParentRef.ObjectId);

                        //determine if we need to re-team the podded animal
                        if (podParent != null)
                        {
                            if (podParent.ClassString.Contains("vivarium", StringComparison.InvariantCultureIgnoreCase))
                            {
                                dinoComponent.IsInCryo = false;
                                dinoComponent.IsInVivarium = true;
                            }

                            dinoComponent.Location = podParent.Location;

                            int obTeam = dinoComponent.GetPropertyValue<int>("TargetingTeam");
                            int containerTeam = podParent.GetPropertyValue<int>("TargetingTeam");
                            if (obTeam != containerTeam)
                            {
                                var propertyIndex = dinoComponent.Properties.FindIndex(i => i.NameString == "TargetingTeam");
                                if (propertyIndex != -1)
                                {
                                    dinoComponent.Properties.RemoveAt(propertyIndex);
                                }
                                dinoComponent.Properties.Add(new PropertyInt("TargetingTeam", containerTeam));


                                if (dinoComponent.GetPropertyValue<int>("TamingTeamID", 0, -1) > 0)
                                {
                                    dinoComponent.Properties.RemoveAt(dinoComponent.Properties.FindIndex(i => i.NameString == "TamingTeamID"));
                                    dinoComponent.Properties.Add(new PropertyInt("TamingTeamID", containerTeam));
                                }

                            }
                        }
                    }

                    if (dinoCharacterStatusComponent != null)
                    {

                        addObject(dinoCharacterStatusComponent, false);

                        var statusComponentRef = dinoComponent.GetTypedProperty<PropertyObject>("MyCharacterStatusComponent");
                        if (statusComponentRef != null) statusComponentRef.Value.ObjectId = dinoCharacterStatusComponent.Id;

                        dinoComponent.AddComponent(dinoCharacterStatusComponent);

                    }

                    if (dinoInventoryComponent != null)
                    {

                        addObject(dinoInventoryComponent, false);

                        var inventoryComponentRef = dinoComponent.GetTypedProperty<PropertyObject>("MyInventoryComponent");
                        if (inventoryComponentRef != null) inventoryComponentRef.Value.ObjectId = dinoInventoryComponent.Id;

                        dinoComponent.AddComponent(dinoInventoryComponent);
                    }


                    addObject(dinoComponent, false);

                }
                );


            }

        }

        #endregion

        #region tribe profile extraction



        private DateTime? GetApproxDateTimeOf(DateTime saveTime, double? objectTime)
        {
            try
            {
                return objectTime.HasValue
                && GameTime  > 0 ? saveTime.AddSeconds(objectTime.Value - GameTime) : (DateTime?)null;
            }
            catch
            {
                return (DateTime?)null;
            }

        }



        public void ExtractStoredArkTribes(ArkArchive archive, string exportFolder)
        {
            if (!Directory.Exists(exportFolder)) Directory.CreateDirectory(exportFolder);

            if (TribeDataStore != null && TribeDataStore.IndexChunks.Count > 0)
            {
                for (int tribeFileIndex = 0; tribeFileIndex < TribeDataStore.IndexChunks.Count; tribeFileIndex++)
                {
                    long storedIndexOffset = StoredDataOffsets[tribeFileIndex].Item1 + TribeDataStore.IndexChunks[tribeFileIndex].ArchiveOffset;
                    long storedIndexSize = TribeDataStore.IndexChunks[tribeFileIndex].Size;
                    long storedDataOffset = StoredDataOffsets[tribeFileIndex].Item1 + TribeDataStore.DataChunks[tribeFileIndex].ArchiveOffset;


                    archive.Position = storedIndexOffset;
                    long indexLimit = storedIndexSize + storedIndexOffset;

                    List<Tuple<long, long, long>> tribeOffsets = new List<Tuple<long, long, long>>();

                    while (archive.Position < indexLimit)
                    {
                        long tribeId = archive.ReadLong();
                        long tribeOffset = archive.ReadLong();
                        long tribeSize = archive.ReadLong();

                        long tribeDataOffset = storedDataOffset + tribeOffset;
                        tribeOffsets.Add(new Tuple<long,long,long>(tribeId, tribeDataOffset,tribeSize));
                    }

                    foreach (var tribeOffset in tribeOffsets)
                    {
                        long tribeId = tribeOffset.Item1;
                        if(tribeId > 0)
                        {
                            archive.Position = tribeOffset.Item2;
                            byte[] tribeData = archive.ReadBytes((int)tribeOffset.Item3);
                            File.WriteAllBytes(Path.Combine(exportFolder, string.Concat(tribeId.ToString(), ".arktribe")), tribeData);

                        }


                    }
                }

            }


        }
        public void ExtractStoredArkProfiles(ArkArchive archive, string exportFolder)
        {
            if (!Directory.Exists(exportFolder)) Directory.CreateDirectory(exportFolder);


            if (PlayerDataStore != null && PlayerDataStore.IndexChunks.Count > 0)
            {
                for (int PlayerFileIndex = 0; PlayerFileIndex < PlayerDataStore.IndexChunks.Count; PlayerFileIndex++)
                {
                    long storedIndexOffset = StoredDataOffsets[PlayerFileIndex].Item1 + PlayerDataStore.IndexChunks[PlayerFileIndex].ArchiveOffset;
                    long storedIndexSize = PlayerDataStore.IndexChunks[PlayerFileIndex].Size;
                    long storedDataOffset = StoredDataOffsets[PlayerFileIndex].Item1 + PlayerDataStore.DataChunks[PlayerFileIndex].ArchiveOffset;


                    archive.Position = storedIndexOffset;
                    long indexLimit = storedIndexSize + storedIndexOffset;

                    List<Tuple<long, long, long>> PlayerOffsets = new List<Tuple<long, long, long>>();

                    while (archive.Position < indexLimit)
                    {
                        long playerFileId = archive.ReadLong();
                        long playerOffset = archive.ReadLong();
                        long playerSize = archive.ReadLong();

                        long PlayerDataOffset = storedDataOffset + playerOffset;
                        PlayerOffsets.Add(new Tuple<long, long, long>(playerFileId, PlayerDataOffset, playerSize));
                    }

                    foreach (var PlayerOffset in PlayerOffsets)
                    {
                        if (PlayerOffset.Item1 <= 0) continue;

                        string playerFilename = PlayerOffset.Item1.ToString();
                        archive.Position = PlayerOffset.Item2;

                        ArkStoreProfile storedProfile = new ArkStoreProfile();
                        storedProfile.ReadBinary(archive, new ReadingOptions());

                        var playerObject = storedProfile.Profile;
                        if(playerObject!=null)
                        {
                            if (!playerObject.HasAnyProperty("MyData")) continue;

                            var playerData = (StructPropertyList)playerObject.GetTypedProperty<PropertyStruct>("MyData").Value;
                            var lastLoginTime = playerData.GetPropertyValue<double>("LoginTime");
                            DateTime lastLoginTimestamp = GetApproxDateTimeOf(FileTime, lastLoginTime) ?? DateTime.Now;
                            var dayDifference = (int)FileTime.Subtract(lastLoginTimestamp).Days;

                            if (dayDifference < 30)
                            {
                                archive.Position = PlayerOffset.Item2;
                                byte[] PlayerData = archive.ReadBytes((int)PlayerOffset.Item3);

                                string profileExportFilename = Path.Combine(exportFolder, string.Concat(playerFilename, ".arkprofile"));
                                File.WriteAllBytes(profileExportFilename, PlayerData);;
                                File.SetLastWriteTimeUtc(profileExportFilename, lastLoginTimestamp.ToUniversalTime());
                            }
                        }
                        

                    }
                }

            }

        }


        #endregion


        #region readBinary

        public void ReadBinary(ArkArchive archive, ReadingOptions options)
        {
            long startRead = DateTime.Now.Ticks;

            readBinaryHeader(archive);

            if (SaveVersion > 5)
            {
                // Name table is located after the objects block, but will be needed to read the objects block
                readBinaryNameTable(archive);
            }

            readBinaryDataFiles(archive, options);
            readBinaryEmbeddedData(archive, options);
            readBinaryDataFilesObjectMap(archive, options);
            readBinaryObjects(archive, options);
            readBinaryObjectProperties(archive, options);

            if (SaveVersion > 6)
            {
             
                readBinaryHibernation(archive, options);
            }

            if (SaveVersion > 10)
            {
                readBinaryStoredObjects(archive, options);
                readBinaryStoredTribes(archive, options);
                readBinaryStoredProfiles(archive, options);

            }
            else
            {
                extractBinaryObjectStoredCreatures(options);
            }


            long endRead = DateTime.Now.Ticks;
            var timeTaken = TimeSpan.FromTicks(endRead - startRead);
            Console.WriteLine($"Read ended in {timeTaken.ToString()}");


            OldNameList = archive.HasUnknownNames ? archive.NameTable : null;
            HasUnknownData = archive.HasUnknownData;
        }

        private void readBinaryHeader(ArkArchive archive)
        {
            SaveVersion = archive.ReadShort();
            archive.SaveVersion  = SaveVersion;


            if (SaveVersion < 5 || SaveVersion > 12)
            {
                throw new NotSupportedException("Found unknown Version " + SaveVersion);
            }

            if (SaveVersion > 6)
            {
                if(SaveVersion > 10 )
                {
                    //read in stored data file offsets
                    for(int x = 0; x < 4; x++)
                    {
                        var storedOffset = new Tuple<long,long>(archive.ReadLong(), archive.ReadLong());
                        StoredDataOffsets.Add(storedOffset);
                    }
                }

                hibernationOffset = archive.ReadInt();
                int shouldBeZero = archive.ReadInt();
                if (shouldBeZero != 0)
                {
                   
                   throw new NotSupportedException("The stuff at this position should be zero: " + (archive.Position - 4).ToString("X4"));
                }
            }
            else
            {
                hibernationOffset = 0;
            }

            if (SaveVersion > 5)
            {
                nameTableOffset = archive.ReadInt();
                propertiesBlockOffset = archive.ReadInt();


            }
            else
            {
                nameTableOffset = 0;              
                propertiesBlockOffset = 0;
            }


            GameTime = archive.ReadFloat();
            SaveCount = SaveVersion > 8 ? archive.ReadInt() : 0;
        }

        private void readBinaryNameTable(ArkArchive archive)
        {
            long position = archive.Position;

            archive.Position = nameTableOffset;
            int nameCount = archive.ReadInt();

            List<string> nameTable = new List<string>(nameCount);
            for (int n = 0; n < nameCount; n++)
            {
                var stringValue = archive.ReadString();
                nameTable.Add(stringValue);
            }


            archive.SetNameTable(nameTable);

            archive.Position = position;
        }

        private void readBinaryDataFiles(ArkArchive archive, ReadingOptions options)
        {
            int count = archive.ReadInt();

            DataFiles.Clear();
            if (options.DataFiles)
            {
                for (int n = 0; n < count; n++)
                {
                    DataFiles.Add(archive.ReadString());
                }
            }
            else
            {
                archive.HasUnknownData = true;
                for (int n = 0; n < count; n++)
                {
                    archive.SkipString();
                }
            }
        }

        private void readBinaryEmbeddedData(ArkArchive archive, ReadingOptions options)
        {
            int count = archive.ReadInt();

            EmbeddedData.Clear();
            if (options.EmbeddedData)
            {
                for (int n = 0; n < count; n++)
                {
                    EmbeddedData.Add(new EmbeddedData(archive));
                }
            }
            else
            {
                archive.HasUnknownData = true;
                for (int n = 0; n < count; n++)
                {
                    Types.EmbeddedData.Skip(archive);
                }
            }
        }

        private void readBinaryDataFilesObjectMap(ArkArchive archive, ReadingOptions options)
        {
            DataFilesObjectMap.Clear();
            if (options.DataFilesObjectMap)
            {
                int dataFilesCount = archive.ReadInt();
                for (int n = 0; n < dataFilesCount; n++)
                {
                    int level = archive.ReadInt();
                    int count = archive.ReadInt();
                    string[] names = new string[count];
                    for (int index = 0; index < count; index++)
                    {
                        names[index] = archive.ReadString();
                    }

                    if (!DataFilesObjectMap.ContainsKey(level) || DataFilesObjectMap[level] == null)
                    {
                        DataFilesObjectMap.Add(level, new List<string[]> { names });
                    }
                }
            }
            else
            {
                archive.HasUnknownData = true;
                int count = archive.ReadInt();
                for (int entry = 0; entry < count; entry++)
                {
                    archive.SkipBytes(4);
                    int stringCount = archive.ReadInt();
                    for (int stringIndex = 0; stringIndex < stringCount; stringIndex++)
                    {
                        archive.SkipString();
                    }
                }
            }
        }

        private void readBinaryObjects(ArkArchive archive, ReadingOptions options)
        {
            if (options.GameObjects)
            {
                int count = archive.ReadInt();


                Objects.Clear();
                ObjectMap.Clear();
                while (count-- > 0)
                {
                    var newObject = new GameObject(archive);
                    addObject(newObject, options.BuildComponentTree);
                }
            }
            else
            {
                archive.HasUnknownData = true;
                archive.HasUnknownNames = true;
            }

        }


        private void readBinaryObjectProperties(ArkArchive archive, ReadingOptions options)
        {
            if (options.GameObjects && options.GameObjectProperties)
            {
                IEnumerable<int> stream = Enumerable.Range(0, Objects.Count);

                if (options.ObjectFilter != null)
                {
                    stream = stream.Where(n => options.ObjectFilter(Objects[n]));
                }

                foreach (int n in stream)
                    readBinaryObjectPropertiesImpl(n, archive);

                if (options.ObjectFilter != null)
                {
                    archive.HasUnknownData = true;
                    archive.HasUnknownNames = true;
                }
            }
            else
            {
                archive.HasUnknownData = true;
                archive.HasUnknownNames = true;
            }
        }

        private void readBinaryObjectPropertiesImpl(int n, ArkArchive archive)
        {
            Objects[n].LoadProperties(archive, (n < Objects.Count - 1) ? Objects[n + 1] : null, propertiesBlockOffset);
        }

        private void readBinaryStoredTribes(ArkArchive archive, ReadingOptions options)
        {
            if (!options.StoredTribes) return;

            Tribes.Clear();

            if (TribeDataStore!=null && TribeDataStore.IndexChunks.Count > 0)
            {
                for(int tribeFileIndex  = 0; tribeFileIndex < TribeDataStore.IndexChunks.Count; tribeFileIndex++)
                {
                    long storedIndexOffset = StoredDataOffsets[tribeFileIndex].Item1 + TribeDataStore.IndexChunks[tribeFileIndex].ArchiveOffset;
                    long storedIndexSize = TribeDataStore.IndexChunks[tribeFileIndex].Size;
                    long storedDataOffset = StoredDataOffsets[tribeFileIndex].Item1 + TribeDataStore.DataChunks[tribeFileIndex].ArchiveOffset;
                    

                    archive.Position = storedIndexOffset;
                    long indexLimit = storedIndexSize + storedIndexOffset;

                    List<long> tribeOffsets = new List<long>();
                    while(archive.Position < indexLimit)
                    {
                        long tribeId = archive.ReadLong();
                        long tribeOffset = archive.ReadLong();
                        long tribeSize = archive.ReadLong();
                        
                        long tribeDataOffset = storedDataOffset + tribeOffset;
                        tribeOffsets.Add(tribeDataOffset);
                    }

                    foreach(var tribeOffset in tribeOffsets)
                    {
                        archive.Position = tribeOffset;
                        ArkStoreTribe storedTribe = new ArkStoreTribe();
                        storedTribe.ReadBinary(archive, options);

                        Tribes.AddRange(storedTribe.Objects);
                    }
                }

            }
        }

        private void readBinaryStoredProfiles(ArkArchive archive, ReadingOptions options)
        {
            if (!options.StoredProfiles) return;

            Profiles.Clear();

            int lastStoredIndexWithData = StoredDataOffsets.Count-1;
            while(lastStoredIndexWithData-- >= 0)
            {
                if (StoredDataOffsets[lastStoredIndexWithData].Item1 != archive.Limit)
                {
                    break;
                }
            }
            

            if (PlayerDataStore != null && PlayerDataStore.IndexChunks.Count > 0)
            {
                for (int playerFileIndex = 0; playerFileIndex < PlayerDataStore.IndexChunks.Count; playerFileIndex++)
                {

                    long storedIndexOffset = StoredDataOffsets[lastStoredIndexWithData].Item1 + PlayerDataStore.IndexChunks[playerFileIndex].ArchiveOffset;
                    long storedIndexSize = PlayerDataStore.IndexChunks[playerFileIndex].Size;
                    long storedDataOffset = StoredDataOffsets[playerFileIndex].Item1 + PlayerDataStore.DataChunks[playerFileIndex].ArchiveOffset;


                    archive.Position = storedIndexOffset;
                    long indexLimit = storedIndexSize + storedIndexOffset;

                    List<Tuple<long,long>> playerOffsets = new List<Tuple<long, long>>();
                    while (archive.Position < indexLimit)
                    {
                        long playerId = archive.ReadLong();
                        long playerOffset = archive.ReadLong();
                        long playerSize = archive.ReadLong();

                        long playerDataOffset = storedDataOffset + playerOffset;
                        playerOffsets.Add(new Tuple<long,long>(playerId, playerDataOffset));
                        
                    }

                    foreach (var playerOffset in playerOffsets)
                    {
                        archive.Position = playerOffset.Item2;
                        ArkStoreProfile storedProfile = new ArkStoreProfile();
                        storedProfile.ReadBinary(archive, options);

                        if (!storedProfile.Profile.HasAnyProperty("MyData")) continue;

                        var playerData = (StructPropertyList)storedProfile.Profile.GetTypedProperty<PropertyStruct>("MyData").Value;
                        var lastLoginTime = playerData.GetPropertyValue<double>("LastLoginTime");
                        DateTime lastLoginTimestamp = GetApproxDateTimeOf(FileTime, lastLoginTime) ?? DateTime.Now;


                        var dayDifference = (int)FileTime.Subtract(lastLoginTimestamp).Days;
                        if (dayDifference <= options.StoredProfileLastLoggedInDayFilter)
                        {
                            storedProfile.Profile.Properties.Add(new PropertyInt64("ProfileFilename", playerOffset.Item1));

                            //only include those logged in within last 30 days of save
                            Profiles.Add(storedProfile.Profile);
                        }
                        
                    }
                }
            }
        }

        private void readBinaryHibernation(ArkArchive archive, ReadingOptions options)
        {
            if (!options.Hibernation)
            {
                hibernationClasses.Clear();
                hibernationIndices.Clear();
                HibernationEntries.Clear();
                archive.HasUnknownData = true;
                return;
            }

            archive.Position = hibernationOffset;

            if (SaveVersion > 7)
            {
                hibernationV8Unknown1 = archive.ReadInt();
                hibernationV8Unknown2 = archive.ReadInt();
                hibernationV8Unknown3 = archive.ReadInt();
                hibernationV8Unknown4 = archive.ReadInt();
            }

            // in Ark version 349.10 new unknown bytes appeared, the save version remained at 9. This is a workaround to handle these values.
            // it's assumed there are two new int32, making it a total of 6 unknown int32 along with the 4 version8 int32, the first two are -1 and 2, and all of these 6 int32 are repeated once.
            if (SaveVersion > 8 && hibernationV8Unknown1 == -1 && hibernationV8Unknown2 == 2)
            {
                // Move back by those four integers, so we can use ChunkedStore
                long backupPos = archive.Position;

                try
                {
                    archive.Position -= sizeof(int) * 4;

                    TribeDataStore = new ChunkedStore();
                    PlayerDataStore = new ChunkedStore();

                    TribeDataStore.ReadBinary(archive, options);
                    PlayerDataStore.ReadBinary(archive, options);

                }
                catch
                {
                    archive.Position = backupPos;
                }

            }

            // No hibernate section if we reached the nameTable
            if (archive.Position == nameTableOffset)
            {
                return;
            }


            hibernationUnknown1 = archive.ReadInt();
            hibernationUnknown2 = archive.ReadInt();

            int hibernatedClassesCount = archive.ReadInt();

            hibernationClasses.Clear();
            hibernationClasses.Capacity = hibernatedClassesCount;
            for (int index = 0; index < hibernatedClassesCount; index++)
            {
                hibernationClasses.Add(archive.ReadString());
            }

            int hibernatedIndicesCount = archive.ReadInt();

            if (hibernatedIndicesCount != hibernatedClassesCount)
            {
                archive.DebugMessage("hibernatedClassesCount does not match hibernatedIndicesCount");
                throw new NotSupportedException();
            }

            hibernationIndices.Clear();
            hibernationIndices.Capacity = hibernatedIndicesCount;
            for (int index = 0; index < hibernatedIndicesCount; index++)
            {
                hibernationIndices.Add(archive.ReadInt());
            }

            int hibernatedObjectsCount = archive.ReadInt();

            HibernationEntries.Clear();
            HibernationEntries.Capacity = hibernatedObjectsCount;
            for (int index = 0; index < hibernatedObjectsCount; index++)
            {
                HibernationEntries.Add(new HibernationEntry(archive, options));
            }
        }

        #endregion

    }

}
