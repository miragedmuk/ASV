using System;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Structs;
using SavegameToolkit.Types;

namespace SavegameToolkit.Propertys {

    public class PropertyStruct : PropertyBase<IStruct> {
        public static readonly ArkName TYPE = ArkName.ConstantPlain("StructProperty");
        public override ArkName Type => TYPE;

        private ArkName structType;

        public PropertyStruct() { }

        public PropertyStruct(string name, IStruct value, ArkName structType) : base(ArkName.From(name), 0, value) {
            this.structType = structType;
        }

        public PropertyStruct(string name, int index, IStruct value, ArkName structType) : base(ArkName.From(name), index, value) {
            this.structType = structType;
        }

        public override void Init(ArkArchive archive, ArkName name) {
            base.Init(archive, name);
            structType = archive.ReadName();

            long position = archive.Position;
            try {
                Value = StructRegistry.ReadBinary(archive, structType);

                if (Value == null) {
                    throw new UnreadablePropertyException("StructRegistry returned null");
                }
            } catch (UnreadablePropertyException upe) {
                archive.Position = position;

                Value = new StructUnknown(archive, DataSize);

                archive.HasUnknownNames = true;
                Debug.WriteLine($"Reading StructProperty of type {structType} with name {name} as byte blob because:");
                Debug.WriteLine(upe.Message);
                Debug.WriteLine(upe.StackTrace);
            }
        }

        public override void Init(JObject node) {
            base.Init(node);
            structType = ArkName.From(node.Value<string>("structType"));

            Value = node["unknown"] != null && node["unknown"].Type != JTokenType.Null ? new StructUnknown(node["unknown"]) : StructRegistry.ReadJson(node["value"], structType);
        }

        protected override void writeBinaryValue(ArkArchive archive) {
            archive.WriteName(structType);
            Value.WriteBinary(archive);
        }

        protected override void writeJsonValue(JsonTextWriter generator, WritingOptions writingOptions) {
            if (!writingOptions.Compact) {
                generator.WriteField("structType", structType.ToString());

                generator.WritePropertyName(Value is StructUnknown ? "unknown" : "value");
            }
            Value.WriteJson(generator, writingOptions);
        }

        protected override int calculateAdditionalSize(NameSizeCalculator nameSizer) => nameSizer(structType);

        protected override int calculateDataSize(NameSizeCalculator nameSizer) => Value.Size(nameSizer);

        public override void CollectNames(NameCollector collector) {
            base.CollectNames(collector);
            collector(structType);
            Value.CollectNames(collector);
        }
    }

}
