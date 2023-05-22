using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        [JsonProperty(Order = 0)]
        public short SaveVersion { get; private set; }

        /// <summary>
        /// How long has this map been running
        /// </summary>
        [JsonProperty(Order = 1)]
        public float GameTime { get; private set; }

        /// <summary>
        /// How often has this map-save been written
        /// </summary>
        [JsonProperty(Order = 2)]
        public int SaveCount { get; private set; }

        [JsonProperty("PreservedNames", Order = 3)]
        public List<string> OldNameList { get; private set; }

        [JsonProperty(Order = 4)]
        public List<string> DataFiles { get; } = new List<string>();

        [JsonProperty(Order = 5)]
        public List<EmbeddedData> EmbeddedData { get; } = new List<EmbeddedData>();

        [JsonProperty(Order = 6)]
        public Dictionary<int, List<string[]>> DataFilesObjectMap { get; } = new Dictionary<int, List<string[]>>();

        [JsonProperty(Order = 7)]
        public override List<GameObject> Objects { get; } = new List<GameObject>();

        private int hibernationOffset;

        private int nameTableOffset;

        private int propertiesBlockOffset;

        private int hibernationV8Unknown1;

        private int hibernationV8Unknown2;

        private int hibernationV8Unknown3;

        private int hibernationV8Unknown4;

        // Ark version 349.10 introduced two new unknown hibernation entries, the save version remained 9, though. Saving these is not supported.
        private int hibernationV9_34910Unknown1;
        private int hibernationV9_34910Unknown2;

        private int hibernationUnknown1;

        private int hibernationUnknown2;

        private readonly List<string> hibernationClasses = new List<string>();

        private readonly List<int> hibernationIndices = new List<int>();

        public List<HibernationEntry> HibernationEntries { get; } = new List<HibernationEntry>();

        public bool HasUnknownNames => OldNameList != null;

        public bool HasUnknownData { get; set; }

        private HashSet<string> nameTableForWriteBinary;

        #region storedCreatures

        private void extractBinaryObjectStoredCreatures(ReadingOptions options)
        {
            if (!options.StoredCreatures) return;

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

            ConcurrentBag<Tuple<GameObject, GameObject>> cbStored = new ConcurrentBag<Tuple<GameObject, GameObject>>();
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


                        var cryoStream = new System.IO.MemoryStream(creatureBytes.ToArray<byte>());

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
                                    ob.LoadProperties(cryoArchive, new GameObject(), 0);
                                }

                                var creatureObject = storedGameObjects[0];
                                var statusObject = storedGameObjects[1];

                                // assume the first object is the creature object
                                string creatureActorId = creatureObject.Names[0].ToString();

                                if (storedPod.ClassString.Contains("Vivarium"))
                                {
                                    //vivarium
                                    creatureObject.IsVivarium = true;
                                }
                                else
                                {
                                    creatureObject.IsCryo = true;
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
                                            creatureObject.IsCryo = false;
                                            creatureObject.IsVivarium = true;
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
            });

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
                        statusComponentRef.Value.ObjectId = statusObject.Id;
                    }

                    addObject(creatureObject, false);
                }

            }
            long addEnd = DateTime.Now.Ticks;
            var timeTaken4 = TimeSpan.FromTicks(addEnd - propertyEnd);
            Console.WriteLine($"Objects added in {timeTaken4.ToString()}");
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

            long endRead = DateTime.Now.Ticks;
            var timeTaken = TimeSpan.FromTicks(endRead - startRead);
            Console.WriteLine($"Read ended in {timeTaken.ToString()}");

            extractBinaryObjectStoredCreatures(options);


            OldNameList = archive.HasUnknownNames ? archive.NameTable : null;
            HasUnknownData = archive.HasUnknownData;
        }

        private void readBinaryHeader(ArkArchive archive)
        {
            SaveVersion = archive.ReadShort();

            if (SaveVersion < 5 || SaveVersion > 9)
            {
                throw new NotSupportedException("Found unknown Version " + SaveVersion);
            }

            if (SaveVersion > 6)
            {
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
                nameTable.Add(archive.ReadString());
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
                    addObject(new GameObject(archive), options.BuildComponentTree);
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

        private void readBinaryHibernation(ArkArchive archive, ReadingOptions options)
        {
            if (!options.Hibernation)
            {
                hibernationV8Unknown1 = 0;
                hibernationV8Unknown2 = 0;
                hibernationV8Unknown3 = 0;
                hibernationV8Unknown4 = 0;
                hibernationUnknown1 = 0;
                hibernationUnknown2 = 0;
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
                archive.DebugMessage("non-zero unknown V9 fields, expecting duplicated set per 349.10");
                hibernationV9_34910Unknown1 = archive.ReadInt();
                hibernationV9_34910Unknown2 = archive.ReadInt();
                if (!(hibernationV8Unknown1 == archive.ReadInt()
                      && hibernationV8Unknown2 == archive.ReadInt()
                      && hibernationV8Unknown3 == archive.ReadInt()
                      && hibernationV8Unknown4 == archive.ReadInt()
                      && hibernationV9_34910Unknown1 == archive.ReadInt()
                      && hibernationV9_34910Unknown2 == archive.ReadInt()))
                {
                    throw new NotSupportedException("349.10 workaround for duplicate unknown hibernation bytes failed");
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

        #region writeBinary

        public void WriteBinary(ArkArchive archive, WritingOptions options)
        {
            if (nameTableForWriteBinary != null)
            {
                archive.SetNameTable(OldNameList != null ? ((ListAppendingSet<string>)nameTableForWriteBinary).List : new List<string>(nameTableForWriteBinary));
            }

            writeBinaryHeader(archive);
            writeBinaryDataFiles(archive);
            writeBinaryEmbeddedData(archive);
            writeBinaryDataFilesObjectMap(archive);
            writeBinaryObjects(archive);

            if (SaveVersion > 6)
            {
                writeBinaryHibernation(archive);
            }

            if (SaveVersion > 5)
            {
                writeNameTable(archive);
            }

            writeBinaryProperties(archive, options);
        }

        public int CalculateSize()
        {
            // calculateHeaderSize checks for valid known versions
            NameSizeCalculator calculator = ArkArchive.GetNameSizer(SaveVersion > 5);

            int size = calculateHeaderSize();
            size += calculateDataFilesSize();
            size += calculateEmbeddedDataSize();
            size += calculateDataFilesObjectMapSize();
            size += calculateObjectsSize(calculator);

            if (SaveVersion > 6)
            {
                hibernationOffset = size;
                size += calculateHibernationSize();
            }

            if (SaveVersion > 5)
            {
                nameTableOffset = size;

                nameTableForWriteBinary = OldNameList != null ? new ListAppendingSet<string>(OldNameList) : new HashSet<string>();

                Objects.ForEach(o => o.CollectNames(arkName => nameTableForWriteBinary.Add(arkName.Name)));

                if (OldNameList != null)
                {
                    size += 4 + ((ListAppendingSet<string>)nameTableForWriteBinary).List.Sum(ArkArchive.GetStringLength);
                }
                else
                {
                    size += 4 + nameTableForWriteBinary.Sum(ArkArchive.GetStringLength);
                }
            }
            else
            {
                nameTableForWriteBinary = null;
            }

            propertiesBlockOffset = size;

            size += calculateObjectPropertiesSize(calculator);
            return size;
        }

        private void writeBinaryHeader(ArkArchive archive)
        {
            archive.WriteShort(SaveVersion);

            if (SaveVersion > 6)
            {
                archive.WriteInt(hibernationOffset);
                archive.WriteInt(0);
            }

            if (SaveVersion > 5)
            {
                archive.WriteInt(nameTableOffset);
                archive.WriteInt(propertiesBlockOffset);
            }

            archive.WriteFloat(GameTime);

            if (SaveVersion > 8)
            {
                archive.WriteInt(SaveCount);
            }
        }

        private void writeBinaryDataFiles(ArkArchive archive)
        {
            archive.WriteInt(DataFiles.Count);
            DataFiles.ForEach(archive.WriteString);
        }

        private void writeBinaryEmbeddedData(ArkArchive archive)
        {
            archive.WriteInt(EmbeddedData.Count);
            EmbeddedData.ForEach(ed => ed.WriteBinary(archive));
        }

        private void writeBinaryDataFilesObjectMap(ArkArchive archive)
        {
            archive.WriteInt(DataFilesObjectMap.Count);
            foreach (int key in DataFilesObjectMap.Keys)
            {
                foreach (string[] namesList in DataFilesObjectMap[key])
                {
                    archive.WriteInt(key);
                    archive.WriteInt(namesList.Length);
                    foreach (string name in namesList)
                    {
                        archive.WriteString(name);
                    }
                }
            }
        }

        private void writeBinaryObjects(ArkArchive archive)
        {
            archive.WriteInt(Objects.Count);

            // Position of properties data is absolute
            // or Position of properties data is relative to propertiesBlockOffset
            int currentOffset = SaveVersion == 5 ? propertiesBlockOffset : 0;

            foreach (GameObject gameObject in Objects)
            {
                currentOffset = gameObject.WriteBinary(archive, currentOffset);
            }
        }

        private void writeBinaryHibernation(ArkArchive archive)
        {
            archive.Position = hibernationOffset;
            if (SaveVersion > 7)
            {
                archive.WriteInt(hibernationV8Unknown1);
                archive.WriteInt(hibernationV8Unknown2);
                archive.WriteInt(hibernationV8Unknown3);
                archive.WriteInt(hibernationV8Unknown4);
            }

            if (!HibernationEntries.Any())
            {
                return;
            }

            archive.WriteInt(hibernationUnknown1);
            archive.WriteInt(hibernationUnknown2);

            archive.WriteInt(hibernationClasses.Count);
            hibernationClasses.ForEach(archive.WriteString);

            archive.WriteInt(hibernationIndices.Count);
            hibernationIndices.ForEach(archive.WriteInt);

            archive.WriteInt(HibernationEntries.Count);
            foreach (HibernationEntry hibernationEntry in HibernationEntries)
            {
                hibernationEntry.WriteBinary(archive);
            }
        }

        private void writeNameTable(ArkArchive archive)
        {
            archive.Position = nameTableOffset;
            List<string> nameTable = archive.NameTable;

            archive.WriteInt(nameTable.Count);
            nameTable.ForEach(archive.WriteString);
        }

        private void writeBinaryProperties(ArkArchive archive, WritingOptions writingOptions)
        {
            // Position of properties data is absolute
            // or Position of properties data is relative to propertiesBlockOffset
            int offset = SaveVersion == 5 ? 0 : propertiesBlockOffset;

            //if (options.isParallel()) {
            //    foreach (GameObject gameObject in Objects.AsParallel()) {
            //        gameObject.writeProperties(archive.Clone(), offset);
            //    }
            //} else {
            foreach (GameObject gameObject in Objects)
                gameObject.WriteProperties(archive, offset);
            //}
        }

        #endregion

        #region calculate sizes

        private int calculateHeaderSize()
        {
            if (SaveVersion < 5 || SaveVersion > 9)
            {
                throw new NotSupportedException("Version " + SaveVersion + " is unknown and cannot be written in binary form");
            }

            // saveVersion + gameTime
            int size = sizeof(short) + sizeof(float);

            if (SaveVersion > 5)
            {
                // nameTableOffset + propertiesBlockOffset
                size += sizeof(int) * 2;
            }

            if (SaveVersion > 6)
            {
                // hibernationOffset + shouldBeZero
                size += sizeof(int) * 2;
            }

            if (SaveVersion > 8)
            {
                // saveCount
                size += sizeof(int);
            }

            return size;
        }

        private int calculateDataFilesSize()
        {
            return 4 + DataFiles.Sum(ArkArchive.GetStringLength);
        }

        private int calculateEmbeddedDataSize()
        {
            return 4 + EmbeddedData.Sum(data => data.Size);
        }

        private int calculateDataFilesObjectMapSize()
        {
            int size = 4;
            foreach (List<string[]> namesListList in DataFilesObjectMap.Values)
            {
                size += namesListList.Count * 8;
                foreach (string[] namesList in namesListList)
                {
                    size += namesList.Sum(ArkArchive.GetStringLength);
                }
            }

            return size;
        }

        private int calculateObjectsSize(NameSizeCalculator nameSizer)
        {
            return 4 + Objects.AsParallel().Sum(o => o.Size(nameSizer));
        }

        private int calculateObjectPropertiesSize(NameSizeCalculator nameSizer)
        {
            return Objects.AsParallel().Sum(o => o.PropertiesSize(nameSizer));
        }

        private int calculateHibernationSize()
        {
            int size = SaveVersion > 7 ? sizeof(int) * 4 : 0;

            if (HibernationEntries.Count <= 0)
                return size;

            size += sizeof(int) * (5 + hibernationIndices.Count);
            size += hibernationClasses.Sum(ArkArchive.GetStringLength);
            size += HibernationEntries.Sum(hibernationEntry => hibernationEntry.GetSizeAndCollectNames());
            return size;
        }

        #endregion

        #region readJson

        public void ReadJson(JToken node, ReadingOptions options)
        {
            readJsonHeader(node);
            readJsonDataFiles(node, options);
            readJsonEmbeddedData(node, options);
            readJsonDataFilesObjectMap(node, options);
            readJsonObjects(node, options);
            readJsonHibernatedObjects(node, options);
        }

        private void readJsonHeader(JToken node)
        {
            SaveVersion = node.Value<short>("saveVersion");
            GameTime = node.Value<float>("gameTime");
            SaveCount = node.Value<int>("saveCount");

            JArray preservedNames = node.Value<JArray>("preservedNames");
            OldNameList = preservedNames?.Any() == true ? preservedNames.Values<string>().ToList() : null;
        }

        private void readJsonDataFiles(JToken node, ReadingOptions options)
        {
            DataFiles.Clear();
            if (!options.DataFiles)
                return;
            JArray dataFilesArray = node.Value<JArray>("dataFiles");
            if (dataFilesArray == null)
                return;
            DataFiles.Capacity = dataFilesArray.Count;
            DataFiles.AddRange(dataFilesArray.Values<string>());
        }

        private void readJsonEmbeddedData(JToken node, ReadingOptions options)
        {
            EmbeddedData.Clear();
            if (!options.EmbeddedData)
                return;
            JArray embeddedDataArray = node.Value<JArray>("embeddedData");
            if (embeddedDataArray == null)
                return;
            EmbeddedData.Capacity = embeddedDataArray.Count;
            EmbeddedData.AddRange(embeddedDataArray.Values<JObject>().Select(data => new EmbeddedData(data)));
        }

        private void readJsonDataFilesObjectMap(JToken node, ReadingOptions options)
        {
            DataFilesObjectMap.Clear();
            if (!options.DataFilesObjectMap)
                return;
            JObject dataFilesObjectMapObject = node.Value<JObject>("dataFilesObjectMap");
            if (dataFilesObjectMapObject == null)
                return;

            foreach (KeyValuePair<string, JToken> entry in dataFilesObjectMapObject)
            {
                List<string[]> objectNameList = ((JArray)entry.Value).Values<JArray>()
                        .Select(namesArray => namesArray.Values<string>().ToArray())
                        .ToList();
                DataFilesObjectMap[int.Parse(entry.Key)] = objectNameList;
            }
        }

        private void readJsonObjects(JToken node, ReadingOptions options)
        {
            Objects.Clear();
            ObjectMap.Clear();
            if (!options.GameObjects)
                return;
            JArray objectsArray = node.Value<JArray>("objects");
            if (objectsArray == null)
                return;
            Objects.Capacity = objectsArray.Count;
            foreach (JObject jObject in objectsArray.Values<JObject>())
            {
                addObject(new GameObject(jObject, options.GameObjectProperties), options.BuildComponentTree);
            }
        }

        private void readJsonHibernatedObjects(JToken node, ReadingOptions options)
        {
            hibernationClasses.Clear();
            hibernationIndices.Clear();
            HibernationEntries.Clear();
            JObject hibernation = node.Value<JObject>("hibernation");
            if (options.Hibernation && hibernation != null && hibernation.Type != JTokenType.Null)
            {
                hibernationV8Unknown1 = hibernation.Value<int>("v8Unknown1");
                hibernationV8Unknown2 = hibernation.Value<int>("v8Unknown2");
                hibernationV8Unknown3 = hibernation.Value<int>("v8Unknown3");
                hibernationV8Unknown4 = hibernation.Value<int>("v8Unknown4");
                hibernationUnknown1 = hibernation.Value<int>("unknown1");
                hibernationUnknown2 = hibernation.Value<int>("unknown2");

                JArray classesArray = hibernation.Value<JArray>("classes");
                if (classesArray != null)
                {
                    foreach (JToken clazz in classesArray)
                    {
                        hibernationClasses.Add(clazz.Value<string>());
                    }
                }

                JArray indicesArray = hibernation.Value<JArray>("indices");
                if (indicesArray != null)
                {
                    foreach (JToken index in indicesArray)
                    {
                        hibernationIndices.Add(index.Value<int>());
                    }
                }

                JArray entriesArray = hibernation.Value<JArray>("entries");
                if (entriesArray != null)
                {
                    foreach (JToken hibernatedObject in entriesArray)
                    {
                        HibernationEntries.Add(new HibernationEntry(hibernatedObject, options));
                    }
                }
            }
            else
            {
                hibernationV8Unknown1 = 0;
                hibernationV8Unknown2 = 0;
                hibernationV8Unknown3 = 0;
                hibernationV8Unknown4 = 0;
                hibernationUnknown1 = 0;
                hibernationUnknown2 = 0;
            }
        }

        #endregion

        #region writeJson

        /// <inheritdoc />
        /// <summary>
        /// Writes this class as json using <code>generator</code>.
        /// This method is valid only in an array context or in no context (see <see cref="M:Newtonsoft.Json.JsonTextWriter.WriteStartObject" />.
        /// Requires the current objects list to be correctly sorted, otherwise the written
        /// <see cref="T:SavegameToolkit.Types.ObjectReference" /> might be broken.
        /// </summary>
        /// <param name="writer"><see cref="T:Newtonsoft.Json.JsonTextWriter" /> to write with</param>
        /// <param name="writingOptions"></param>
        public void WriteJson(JsonTextWriter writer, WritingOptions writingOptions)
        {
            writer.WriteStartObject();

            writer.WriteField("saveVersion", SaveVersion);
            writer.WriteField("gameTime", GameTime);

            writer.WriteField("saveCount", SaveCount);

            if (!writingOptions.Compact && OldNameList != null && OldNameList.Any())
            {
                writer.WriteArrayFieldStart("preservedNames");

                foreach (string oldName in OldNameList)
                {
                    writer.WriteValue(oldName);
                }

                writer.WriteEndArray();
            }

            if (!writingOptions.Compact && DataFiles.Any())
            {
                writer.WriteArrayFieldStart("dataFiles");

                foreach (string dataFile in DataFiles)
                {
                    writer.WriteValue(dataFile);
                }

                writer.WriteEndArray();
            }

            if (!writingOptions.Compact && EmbeddedData.Any())
            {
                writer.WriteArrayFieldStart("embeddedData");

                foreach (EmbeddedData data in EmbeddedData)
                {
                    data.WriteJson(writer);
                }

                writer.WriteEndArray();
            }

            if (DataFilesObjectMap.Any())
            {
                writer.WriteObjectFieldStart("dataFilesObjectMap");

                foreach (KeyValuePair<int, List<string[]>> entry in DataFilesObjectMap)
                {
                    writer.WriteArrayFieldStart(entry.Key.ToString());
                    foreach (string[] namesList in entry.Value)
                    {
                        writer.WriteStartArray();
                        foreach (string name in namesList)
                        {
                            writer.WriteValue(name);
                        }

                        writer.WriteEndArray();
                    }

                    writer.WriteEndArray();
                }

                writer.WriteEndObject();
            }

            if (Objects.Any())
            {
                writer.WriteArrayFieldStart("objects");

                foreach (GameObject gameObject in Objects)
                {
                    gameObject.WriteJson(writer, writingOptions);
                }

                writer.WriteEndArray();
            }

            writer.WriteObjectFieldStart("hibernation");

            if (!writingOptions.Compact)
            {
                writer.WriteField("v8Unknown1", hibernationV8Unknown1);
                writer.WriteField("v8Unknown2", hibernationV8Unknown2);
                writer.WriteField("v8Unknown3", hibernationV8Unknown3);
                writer.WriteField("v8Unknown4", hibernationV8Unknown4);

                writer.WriteField("unknown1", hibernationUnknown1);
                writer.WriteField("unknown2", hibernationUnknown2);
            }

            if (!writingOptions.Compact && hibernationClasses.Any())
            {
                writer.WriteArrayFieldStart("classes");

                foreach (string hibernationClass in hibernationClasses)
                {
                    writer.WriteValue(hibernationClass);
                }

                writer.WriteEndArray();
            }

            if (!writingOptions.Compact && hibernationIndices.Any())
            {
                writer.WriteArrayFieldStart("indices");

                foreach (int hibernationIndex in hibernationIndices)
                {
                    writer.WriteValue(hibernationIndex);
                }

                writer.WriteEndArray();
            }

            if (HibernationEntries.Any())
            {
                writer.WriteArrayFieldStart("entries");

                foreach (HibernationEntry hibernationEntry in HibernationEntries)
                {
                    hibernationEntry.WriteJson(writer, writingOptions);
                }

                writer.WriteEndArray();
            }

            writer.WriteEndObject();

            writer.WriteEndObject();
        }

        #endregion
    }

}
