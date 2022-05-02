using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Types;

namespace SavegameToolkit.Propertys {

    [JsonObject(MemberSerialization.OptIn)]
    public abstract class PropertyBase<T> : IProperty<T> {
        public ArkName Name { get; private set; }
        [JsonProperty("Name", Order = 0)]
        public string NameString => Name.ToString();

        public abstract ArkName Type { get; }
        [JsonProperty("Type", Order = 1)]
        public string TypeString => Type.ToString();

        [JsonProperty(Order = 2)]
        public int Index { get; private set; }

        [JsonProperty(Order = 3)]
        public T Value { get; protected set; }

        [JsonProperty(Order = 4)]
        public int DataSize { get; private set; }

        protected PropertyBase() { }

        protected PropertyBase(ArkName name, int index, T value) {
            Name = name;
            Index = index;
            Value = value;
        }

        public virtual void Init(ArkArchive archive, ArkName name) {
            Name = name;
            DataSize = archive.ReadInt();
            Index = archive.ReadInt();
        }

        public virtual void Init(JObject node) {
            Name = ArkName.From(node.Value<string>("name"));
            DataSize = node.Value<int>("size");
            Index = node.Value<int>("index");
        }

        /// <summary>
        /// Calculates the value for the dataSize field
        /// </summary>
        /// <param name="nameSizer">function to calculate the size of a name in bytes in the current context</param>
        /// <returns>value of dataSize field</returns>
        protected abstract int calculateDataSize(NameSizeCalculator nameSizer);

        /// <summary>
        /// Calculates additional space required to serialize fields of this property.
        /// </summary>
        /// <param name="nameSizer"></param>
        /// <returns></returns>
        protected virtual int calculateAdditionalSize(NameSizeCalculator nameSizer) => 0;

        /// <inheritdoc />
        /// <summary>
        /// Side-effect: calling this function will change the value of the dataSize field.
        /// This makes sure that the value can be used by the write function without having to calculate it twice</summary>
        /// <param name="nameSizer"></param>
        /// <returns></returns>
        public int CalculateSize(NameSizeCalculator nameSizer) {
            // dataSize index
            int size = sizeof(int) * 2;
            DataSize = calculateDataSize(nameSizer);

            size += nameSizer(Name);
            size += nameSizer(Type);
            size += calculateAdditionalSize(nameSizer);
            size += DataSize;

            return size;
        }

        public void WriteBinary(ArkArchive archive) {
            archive.WriteName(Name);
            archive.WriteName(Type);
            archive.WriteInt(DataSize);
            archive.WriteInt(Index);

            writeBinaryValue(archive);
        }

        protected abstract void writeBinaryValue(ArkArchive archive);

        /// <summary>
        /// Determines if the dataSize cannot be calculated and thus needs to be recorded.
        /// Used when writing the JSON representation of the property
        /// <code>true</code> if dataSize needs to be recorded
        /// </summary>
        protected virtual bool isDataSizeNeeded => false;

        public void WriteJson(JsonTextWriter writer, WritingOptions writingOptions) {
            if (writingOptions.Compact) {
                writer.WritePropertyName($"{Name}{(Index != 0 ? ":" + Index : string.Empty)}");
                writeJsonValue(writer, writingOptions);
                return;
            }

            writer.WriteStartObject();

            writer.WriteField("name", Name.ToString());
            writer.WriteField("type", Type.ToString());
            if (isDataSizeNeeded && DataSize != 0) {
                writer.WriteField("size", DataSize);
            }

            if (Index != 0) {
                writer.WriteField("index", Index);
            }

            writeJsonValue(writer, writingOptions);

            writer.WriteEndObject();
        }

        protected virtual void writeJsonValue(JsonTextWriter writer, WritingOptions writingOptions) {
            if (writingOptions.Compact) {
                writer.WriteValue(Value);
            } else {
                writer.WriteField("value", Value);
            }
        }

        public virtual void CollectNames(NameCollector collector) {
            collector(Name);
            collector(Type);
        }

        public override string ToString() => $"{GetType().Name} [name={Name}{(Index != 0 ? $", index={Index}" : "")}, value={Value}{(DataSize > 0 ? $", dataSize={DataSize}" : "")}]";
    }

}
