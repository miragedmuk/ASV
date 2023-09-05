using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using SavegameToolkit.Data;
using SavegameToolkit.Propertys;
using SavegameToolkit.Types;

namespace SavegameToolkit {

    [JsonObject(MemberSerialization.OptIn)]
    public class GameObject : IPropertyContainer, INameContainer {
        private static readonly HashSet<Guid> uuidCache = new HashSet<Guid>();

        public int Id { get; set; }

        public Guid Uuid { get; set; }

        public ArkName ClassName { get; set; }

        public bool IsItem { get; set; }

        public readonly List<ArkName> Names = new List<ArkName>();

        public bool FromDataFile { get; private set; }

        public int DataFileIndex { get; private set; }

        public LocationData Location { get; set; }

        public bool IsCryo {get; set;}
        public bool IsVivarium { get; set; }


        private int propertiesSize;

        private int propertiesOffset;

        public List<IProperty> Properties { get; } = new List<IProperty>();

        public IExtraData ExtraData { get; set; }

        public GameObject Parent { get; set; }

        public readonly Dictionary<ArkName, GameObject> Components = new Dictionary<ArkName, GameObject>();

        public IEnumerable<ArkName> ParentNames => Names.Skip(1).ToList();

        public bool HasParentNames => Names.Count > 1;

        public GameObject() {}
     
        public GameObject(ArkArchive archive) : this() {
            readBinary(archive);
        }

        public string ClassString {
            get => ClassName?.ToString()??"";
            set => ClassName = ArkName.From(value);
        }


        // ReSharper disable UnusedMember.Global
        public bool ShouldSerializeId() => true;
        public bool ShouldSerializeUuid() => Uuid != Guid.Empty;
        public bool ShouldSerializeClassName() => ClassName != null;
        public bool ShouldSerializeIsItem() => IsItem;
        public bool ShouldSerializeNames() => Names?.Any() == true;
        public bool ShouldSerializeFromDataFile() => FromDataFile;
        public bool ShouldSerializeDataFileIndex() => DataFileIndex != 0;
        public bool ShouldSerializeLocation() => Location != null;
        public bool ShouldSerializeProperties() => Properties?.Any() == true;
        public bool ShouldSerializeExtraData() => ExtraData != null;
        // ReSharper restore UnusedMember.Global


        public int Size(NameSizeCalculator nameSizer) {
            // UUID item names.size() unkBool unkIndex (locationData!=null) propertiesOffset unkInt
            int size = 16 + sizeof(int) * 7;

            size += nameSizer(ClassName);

            if (Names != null) {
                size += Names.Sum(name => nameSizer(name));
            }

            if (Location != null) {
                size += LocationData.Size;
            }

            return size;
        }

        /// <summary>
        /// Calculates the size of the property block and caches the resulting value
        /// </summary>
        /// <param name="nameSizer"></param>
        /// <returns></returns>
        public int PropertiesSize(NameSizeCalculator nameSizer) {
            int size = nameSizer(ArkName.NameNone);

            size += Properties.Sum(p => p.CalculateSize(nameSizer));

            if (ExtraData != null) {
                size += ExtraData.CalculateSize(nameSizer);
            } else {
                throw new InvalidOperationException("Cannot write binary data without known extra data");
            }

            propertiesSize = size;
            return size;
        }

        private void readBinary(ArkArchive archive) {
            Uuid = archive.ReadBytes(16).ToGuid();
            uuidCache.Add(Uuid);

            ClassName = archive.ReadName();

            IsItem = archive.ReadBool();

            int nameCount = archive.ReadInt();

            Names.Clear();
            while (nameCount-- > 0) {
                Names.Add(archive.ReadName());
            }

            FromDataFile = archive.ReadBool();
            DataFileIndex = archive.ReadInt();

            bool hasLocationData = archive.ReadBool();

            if (hasLocationData) {
                Location = new LocationData(archive);
            }

            propertiesOffset = archive.ReadInt();

            int shouldBeZero = archive.ReadInt();
            if (shouldBeZero == 0)
                return;
            Debug.WriteLine($"Expected int after propertiesOffset to be 0 but found {shouldBeZero} at {archive.Position - 4:X4}");
            archive.HasUnknownData = true;
        }

        public void LoadProperties(ArkArchive archive, GameObject next, int propertiesBlockOffset) {
            int offset = propertiesBlockOffset + propertiesOffset;
            long nextOffset = propertiesBlockOffset + next?.propertiesOffset ?? archive.Limit;

            archive.Position = offset;
            long position = offset;

            Properties.Clear();
            try {
                IProperty property = PropertyRegistry.ReadBinary(archive);

                while (property != null) {
                    position = archive.Position;
                    Properties.Add(property);
                    property = PropertyRegistry.ReadBinary(archive);
                }
            } catch (UnreadablePropertyException upe) {
                archive.HasUnknownNames = true;

                archive.Position = position;
                ExtraDataBlob blob = new ExtraDataBlob {
                        Data = archive.ReadBytes((int)(nextOffset - position))
                };
                ExtraData = blob;

                Debug.WriteLine($"Error while reading property at {position:X4} from GameObject {Id} caused by:");
                Debug.WriteLine(upe);
                return;
            }

            long distance = nextOffset - archive.Position;

            try
            {
                ExtraData = distance > 0 ? ExtraDataRegistry.GetExtraData(this, archive, (int)distance) : null;
            }
            catch
            {

            }
            
        }

        
        public void CollectNames(NameCollector collector) {
            collector(ClassName);

            Names?.ForEach(name => collector(name));

            Properties.ForEach(property => property.CollectNames(collector));
            collector(ArkName.NameNone);

            if (ExtraData is INameContainer container) {
                container.CollectNames(collector);
            }
        }

        public void CollectBaseNames(NameCollector collector) {
            collector(ClassName);

            Names?.ForEach(name => collector(name));
        }

        public void CollectPropertyNames(NameCollector collector) {
            Properties.ForEach(property => property.CollectNames(collector));
            collector(ArkName.NameNone);

            if (ExtraData is INameContainer container) {
                container.CollectNames(collector);
            }
        }

        public void AddComponent(GameObject component)
        {
            try
            {
                Components.Add(component.Names[0], component);
            }
            catch (Exception ex)
            {
                //component by name already exists, ignore duplicate
            }            
        }

        public static void ClearUUIDCache() => uuidCache.Clear();

        private class GameObjectContractResolver : DefaultContractResolver {
            public static readonly GameObjectContractResolver Instance = new GameObjectContractResolver();

            protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) {
                JsonProperty property = base.CreateProperty(member, memberSerialization);

                if (property.DeclaringType == typeof(List<ArkName>)) {
                    
                }

                return property;
            }

        }


    }

}
