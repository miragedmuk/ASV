using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection.Metadata;
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
        public float GameTime { get; private set; }
        public int SaveCount { get; private set; }
        public List<string> OldNameList { get; private set; }
        public List<string> DataFiles { get; } = new List<string>();
        public List<EmbeddedData> EmbeddedData { get; } = new List<EmbeddedData>();
        public Dictionary<int, List<string[]>> DataFilesObjectMap { get; } = new Dictionary<int, List<string[]>>();
        public override List<GameObject> Objects { get; } = new List<GameObject>();

        private int hibernationOffset;
        private int storedOffset;
        private int nameTableOffset;
        private int propertiesBlockOffset;
        private int hibernationV8Unknown1;
        private int hibernationV8Unknown2;
        private int hibernationV8Unknown3;
        private int hibernationV8Unknown4;
        private int hibernationV9_34910Unknown1;
        private int hibernationV9_34910Unknown2;
        private int hibernationV9Check1;
        private int hibernationV9Check2;
        private int hibernationV9Check3;
        private int hibernationV9Check4;
        private int hibernationV9Check5;
        private int hibernationV9Check6;
        private int hibernationUnknown1;
        private int hibernationUnknown2;
        private readonly List<string> hibernationClasses = new List<string>();
        private readonly List<int> hibernationIndices = new List<int>();

        public List<HibernationEntry> HibernationEntries { get; } = new List<HibernationEntry>();

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
                                        ob.LoadProperties(cryoArchive, new GameObject(), 0);
                                    }

                                    var creatureObject = storedGameObjects[0];
                                    var statusObject = storedGameObjects[1];

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


        private void readBinaryStoredObjects(ArkArchive archive, ReadingOptions options)
        {

            if (!options.StoredCreatures) return;

            var inventoryContainers = Objects.AsParallel().Where(x => x.GetPropertyValue<ObjectReference?>("MyInventoryComponent") != null).ToList();

            var validStored = Objects.AsParallel()
                .Where(o =>
                        (o.ClassString.Contains("Cryopod") || o.ClassString.Contains("SoulTrap_") || o.ClassString.Contains("Vivarium_"))
                        && o.GetTypedProperty<PropertyArray>("CustomItemDatas") !=null 
                )
                .ToList();



            List<CryoStoreData> storedOffsets = new List<CryoStoreData>();

            validStored.ForEach(x =>
            {
                if (!(x.Properties.First(p => p.NameString == "CustomItemDatas") is PropertyArray customData)) return;

                long cryoDataOffset = 0;
                if (
                    archive.SaveVersion > 10
                    && customData.Value is ArkArrayStruct redirectors
                    && redirectors.All(x => x is StructCustomItemDataRef)
                )
                {
                    // TODO: probably best to: in cryos, take first entry. in souls, take second.
                    cryoDataOffset = ((StructCustomItemDataRef)redirectors[0]).Position;
                }

                storedOffsets.Add(new CryoStoreData() { ParentObject = x, Offset = cryoDataOffset });
            });
            validStored = null;


            var sortedOffsets = storedOffsets.OrderBy(x => x.Offset).ToList();

            for(int x=0; x < sortedOffsets.Count; x++)
            {
                var storedObject = sortedOffsets[x];
                long nextOffset = x < sortedOffsets.Count-1 ? sortedOffsets[x + 1].Offset: archive.Limit;

                archive.Position = storedObject.Offset + storedOffset;
                storedObject.Data = archive.ReadBytes((int)(nextOffset - storedObject.Offset));
            }
            storedOffsets = new List<CryoStoreData>();//clear it down, no longer needed in memory.


            Parallel.ForEach(sortedOffsets, o =>
            {
                using(MemoryStream ms = new MemoryStream(o.Data))
                {
                    using(ArkArchive storedArchive = new ArkArchive(ms))
                    {
                        ArkCryoStore storeSummary = new ArkCryoStore(storedArchive);
                        storeSummary.LoadProperties(storedArchive);

                        var dinoComponent = storeSummary.CreatureComponent;
                        var dinoCharacterStatusComponent = storeSummary.StatusComponent;
                        var dinoInventoryComponent = storeSummary.InventoryComponent;


                        //re-map and add properties as appropriate
                        if (dinoComponent != null)
                        {
                            dinoComponent.IsInCryo = !o.ParentObject.ClassString.Contains("vivarium", StringComparison.InvariantCultureIgnoreCase);
                            dinoComponent.IsInVivarium = o.ParentObject.ClassString.Contains("vivarium", StringComparison.InvariantCultureIgnoreCase);

                            // the tribe name is stored in `TamerString`, non-cryoed creatures have the property `TribeName` for that.
                            if (dinoComponent.GetPropertyValue<string>("TribeName")?.Length == 0 && dinoComponent.GetPropertyValue<string>("TamerString")?.Length > 0)
                                dinoComponent.Properties.Add(new PropertyString("TribeName", dinoComponent.GetPropertyValue<string>("TamerString")));


                            //get parent of cryopod owner inventory
                            var podParentRef = o.ParentObject.GetPropertyValue<ObjectReference>("OwnerInventory");
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


                                        if (dinoComponent.GetPropertyValue<int?>("TamingTeamID") != null)
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

                            }

                            if (dinoInventoryComponent != null)
                            {

                                addObject(dinoInventoryComponent, false);

                                var inventoryComponentRef = dinoComponent.GetTypedProperty<PropertyObject>("MyInventoryComponent");
                                if (inventoryComponentRef != null) inventoryComponentRef.Value.ObjectId = dinoInventoryComponent.Id;
                            }


                            addObject(dinoComponent, false);

                        }
                    }

                }
            }
            );

            
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
                    storedOffset = (int)archive.ReadLong();
                    var storedDataSize = archive.ReadLong(); 
                    
                    var v11Unknown1 = archive.ReadLong(); //file size or some other pointer 
                    var v11Unknown2 = archive.ReadLong(); //0
                    var v11Unknown3 = archive.ReadLong(); //file size or some other pointer
                    var v11Unknown4 = archive.ReadLong(); //0
                    var v11Unknown5 = archive.ReadLong(); //file size or some other pointer
                    var v11Unknown6 = archive.ReadLong(); //0

                }
                else
                {
                    storedOffset = 0;
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
                archive.DebugMessage("non-zero unknown V9 fields, expecting duplicated set per 349.10");
                hibernationV9_34910Unknown1 = archive.ReadInt();
                hibernationV9_34910Unknown2 = archive.ReadInt();


                hibernationV9Check1 = archive.ReadInt();
                hibernationV9Check2 = archive.ReadInt();
                hibernationV9Check3 = archive.ReadInt();
                hibernationV9Check4 = archive.ReadInt();
                hibernationV9Check5 = archive.ReadInt();
                hibernationV9Check6 = archive.ReadInt();

                if (!(hibernationV8Unknown1 == hibernationV9Check1
                      && hibernationV8Unknown2 == hibernationV9Check2
                      && hibernationV8Unknown3 == hibernationV9Check3
                      && hibernationV8Unknown4 == hibernationV9Check4
                      && hibernationV9_34910Unknown1 == hibernationV9Check5
                      && hibernationV9_34910Unknown2 == hibernationV9Check6))
                {
                    if(SaveVersion > 10)
                    {
                        //TODO:// more data reads - is it always 112 bytes?
                        archive.SkipBytes(112);

                    }
                    else
                    {
                        throw new NotSupportedException("349.10 workaround for duplicate unknown hibernation bytes failed");
                    }
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
