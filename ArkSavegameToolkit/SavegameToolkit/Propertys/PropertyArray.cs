using System;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Arrays;
using SavegameToolkit.Types;

namespace SavegameToolkit.Propertys {

    public class PropertyArray : PropertyBase<IArkArray> {
        public static readonly ArkName TYPE = ArkName.ConstantPlain("ArrayProperty");
        public override ArkName Type => TYPE;

        public PropertyArray() { }

        public PropertyArray(string name, IArkArray value) : base(ArkName.From(name), 0, value) { }

        public PropertyArray(string name, int index, IArkArray value) : base(ArkName.From(name), index, value) { }

        public override void Init(ArkArchive archive, ArkName name) {
            base.Init(archive, name);

            ArkName arrayType = archive.ReadName();

            long position = archive.Position;

            try {
                Value = ArkArrayRegistry.ReadBinary(archive, arrayType, this);

                if (Value == null) {
                    throw new UnreadablePropertyException("ArkArrayRegistry returned null");
                }
            } catch (UnreadablePropertyException upe) {
                archive.Position = position;

                Value = new ArkArrayUnknown(archive, DataSize, arrayType);

                archive.HasUnknownNames = true;
                Debug.WriteLine($"Reading ArrayProperty of type {arrayType} with name {name} as byte blob because:");
                Debug.WriteLine(upe.Message);
                Debug.WriteLine(upe.StackTrace);
            }
        }

        public override void Init(JObject node) {
            base.Init(node);
            ArkName arrayType = ArkName.From(node.Value<string>("arrayType"));

            try {
                node["value"].ToObject<byte[]>();
                Value = new ArkArrayUnknown(node["value"], arrayType);
            } catch (Exception ex) when (ex is FormatException || ex is OverflowException || ex is JsonReaderException) {
                Value = ArkArrayRegistry.ReadJson(node.Value<JArray>("value"), arrayType, this);
            }
        }

        public IArkArray<T> GetTypedValue<T>() => Value is T ? (IArkArray<T>)Value : null;

        protected override void writeBinaryValue(ArkArchive archive) {
            archive.WriteName(Value.Type);
            Value.WriteBinary(archive);
        }

        protected override void writeJsonValue(JsonTextWriter generator, WritingOptions writingOptions) {
            if (!writingOptions.Compact) {
                generator.WriteField("arrayType", Value.Type.ToString());
                generator.WritePropertyName("value");
            }
            Value.WriteJson(generator, writingOptions);
        }

        protected override int calculateAdditionalSize(NameSizeCalculator nameSizer) => nameSizer(Value.Type);

        protected override int calculateDataSize(NameSizeCalculator nameSizer) => Value.CalculateSize(nameSizer);

        public override void CollectNames(NameCollector collector) {
            base.CollectNames(collector);
            collector(Value.Type);
            Value.CollectNames(collector);
        }

        protected override bool isDataSizeNeeded => Value is ArkArrayStruct;
    }

}
