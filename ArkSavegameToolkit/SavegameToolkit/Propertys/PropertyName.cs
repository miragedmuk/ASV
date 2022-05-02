using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Types;
using System;

namespace SavegameToolkit.Propertys {

    public class PropertyName : PropertyBase<ArkName> {
        public static readonly ArkName TYPE = ArkName.ConstantPlain("NameProperty");
        public override ArkName Type => TYPE;

        public PropertyName() { }

        public PropertyName(string name, ArkName value) : base(ArkName.From(name), 0, value) { }

        public PropertyName(string name, int index, ArkName value) : base(ArkName.From(name), index, value) { }

        public override void Init(ArkArchive archive, ArkName name) {
            base.Init(archive, name);
            Value = archive.ReadName();
        }

        public override void Init(JObject node) {
            base.Init(node);
            Value = ArkName.From(node.Value<string>("value"));
        }

        protected override void writeJsonValue(JsonTextWriter writer, WritingOptions writingOptions) {
            if (writingOptions.Compact) {
                writer.WriteValue(Value.ToString());
            } else {
                writer.WriteField("value", Value.ToString());
            }
        }

        protected override void writeBinaryValue(ArkArchive archive) => archive.WriteName(Value);

        protected override int calculateDataSize(NameSizeCalculator nameSizer) => nameSizer(Value);

        public override void CollectNames(NameCollector collector) {
            base.CollectNames(collector);
            collector(Value);
        }
    }

}
