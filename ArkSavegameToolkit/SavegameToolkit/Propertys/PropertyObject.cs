using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Types;
using System;

namespace SavegameToolkit.Propertys {

    public class PropertyObject : PropertyBase<ObjectReference> {
        public static readonly ArkName TYPE = ArkName.ConstantPlain("ObjectProperty");
        public override ArkName Type => TYPE;

        public PropertyObject() { }

        public PropertyObject(string name, ObjectReference value) : this(name, 0, value) { }

        public PropertyObject(string name, int index, ObjectReference value) : base(ArkName.From(name), index, value) { }

        public override void Init(ArkArchive archive, ArkName name) {
            base.Init(archive, name);
            Value = new ObjectReference(archive, DataSize);
        }

        public override void Init(JObject node) {
            base.Init(node);
            Value = new ObjectReference(node["value"], DataSize);
        }

        protected override void writeJsonValue(JsonTextWriter generator, WritingOptions writingOptions) {
            if (!writingOptions.Compact) {
                generator.WritePropertyName("value");
            }
            Value.WriteJson(generator, writingOptions);
        }

        protected override void writeBinaryValue(ArkArchive archive) => Value.WriteBinary(archive);

        protected override int calculateDataSize(NameSizeCalculator nameSizer) => Value.Size(nameSizer);

        protected override bool isDataSizeNeeded => true;

        public override void CollectNames(NameCollector collector) {
            base.CollectNames(collector);
            Value.CollectNames(collector);
        }
    }

}
