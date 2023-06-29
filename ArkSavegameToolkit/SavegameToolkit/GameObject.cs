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

        [JsonProperty(Order = 0)]
        public int Id { get; set; }

        [JsonProperty(Order = 1)]
        public Guid Uuid { get; set; }

        [JsonProperty("Class", Order = 2)]
        public ArkName ClassName { get; set; }

        [JsonProperty("Item", Order = 3)]
        public bool IsItem { get; set; }

        [JsonProperty(Order = 4)]
        public readonly List<ArkName> Names = new List<ArkName>();

        [JsonProperty(Order = 5)]
        public bool FromDataFile { get; private set; }

        [JsonProperty(Order = 6)]
        public int DataFileIndex { get; private set; }

        [JsonProperty(Order = 7)]
        public LocationData Location { get; set; }

        public bool IsCryo {get; set;}
        public bool IsVivarium { get; set; }

        /// <summary>
        /// Cached propertiesSize, avoids calculating the size of properties twice
        /// </summary>
        private int propertiesSize;

        private int propertiesOffset;

        [JsonProperty(Order = 8)]
        public List<IProperty> Properties { get; } = new List<IProperty>();

        [JsonProperty("Extra", Order = 9)]
        public IExtraData ExtraData { get; set; }

        public GameObject Parent { get; set; }

        public readonly Dictionary<ArkName, GameObject> Components = new Dictionary<ArkName, GameObject>();

        public IEnumerable<ArkName> ParentNames => Names.Skip(1).ToList();

        public bool HasParentNames => Names.Count > 1;

        public GameObject() {}
     
        public GameObject(ArkArchive archive) : this() {
            readBinary(archive);
        }

        public GameObject(JObject node, bool loadProperties = true) : this() {
            readJson(node, loadProperties);
        }

        public string ClassString {
            get => ClassName?.ToString()??"";
            set => ClassName = ArkName.From(value);
        }

        public void WriteProperties(ArkArchive archive, int propertiesBlockOffset) {
            archive.Position = propertiesBlockOffset + propertiesOffset;

            Properties?.ForEach(p => p.WriteBinary(archive));

            archive.WriteName(ArkName.NameNone);

            if (ExtraData != null) {
                ExtraData.WriteBinary(archive);
            } else {
                throw new NotSupportedException("Cannot write binary data without known extra data");
            }
        }

        private void readJson(JObject node, bool loadProperties) {
            Uuid = new Guid(node.Value<string>("uuid") ?? Guid.Empty.ToString());
            uuidCache.Add(Uuid);
            ClassName = ArkName.From(node.Value<string>("class"));
            IsItem = node.Value<bool>("item");

            Names.Clear();
            JArray namesArray = node.Value<JArray>("names");
            if (namesArray != null) {
                foreach (string nameNode in namesArray.Values<string>()) {
                    Names.Add(ArkName.From(nameNode));
                }
            }

            FromDataFile = node.Value<bool>("fromDataFile");
            DataFileIndex = node.Value<int>("dataFileIndex");

            Location = node.TryGetValue("location", out JToken location) ? new LocationData(location) : null;

            Properties.Clear();
            if (loadProperties) {
                JArray properties = node.Value<JArray>("properties");

                if (properties != null) {
                    foreach (JToken propertyNode in properties) {
                        Properties.Add(PropertyRegistry.ReadJson((JObject)propertyNode));
                    }
                }

                JToken extra = node["extra"];
                ExtraData = extra != null ? ExtraDataRegistry.GetExtraData(this, extra) : null;
            } else {
                ExtraData = null;
            }
        }

        public void WriteJson(JsonTextWriter writer, WritingOptions writingOptions) {
            writer.WriteStartObject();

            writer.WriteField("id", Id);

            if (Uuid != Guid.Empty) {
                writer.WriteField("uuid", Uuid.ToString());
            }

            if (ClassName != null) {
                writer.WriteField("class", ClassName.ToString());
            }

            if (IsItem) {
                writer.WriteField("item", IsItem);
            }

            if (Names?.Any() == true) {
                writer.WriteArrayFieldStart("names");

                foreach (ArkName name in Names) {
                    writer.WriteValue(name.ToString());
                }

                writer.WriteEndArray();
            }

            if (FromDataFile) {
                writer.WriteField("fromDataFile", FromDataFile);
            }

            if (DataFileIndex != 0) {
                writer.WriteField("dataFileIndex", DataFileIndex);
            }

            if (Location != null) {
                writer.WritePropertyName("location");
                Location.WriteJson(writer);
            }

            if (Properties?.Any() == true) {
                if (writingOptions.Compact) {
                    writer.WriteObjectFieldStart("properties");
                } else {
                    writer.WriteArrayFieldStart("properties");
                }
                
                foreach (IProperty property in Properties) {
                    property.WriteJson(writer, writingOptions);
                }

                if (writingOptions.Compact) {
                    writer.WriteEndObject();
                } else {
                    writer.WriteEndArray();
                }
            }

            if (ExtraData != null) {
                writer.WritePropertyName("extra");
                ExtraData.WriteJson(writer, writingOptions);
            }

            writer.WriteEndObject();
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

        public int WriteBinary(ArkArchive archive, int offset) {
            if (Uuid != Guid.Empty) {
                archive.WriteBytes(Uuid.ToBytes());
            } else {
                archive.WriteLong(0);
                archive.WriteLong(0);
            }

            archive.WriteName(ClassName);
            archive.WriteBool(IsItem);

            if (Names != null) {
                archive.WriteInt(Names.Count);
                Names.ForEach(archive.WriteName);
            } else {
                archive.WriteInt(0);
            }

            archive.WriteBool(FromDataFile);
            archive.WriteInt(DataFileIndex);

            if (Location != null) {
                archive.WriteBool(true);
                Location.WriteBinary(archive);
            } else {
                archive.WriteBool(false);
            }

            propertiesOffset = offset;
            archive.WriteInt(propertiesOffset);
            archive.WriteInt(0);

            return offset + propertiesSize;
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
