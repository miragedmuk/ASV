using Newtonsoft.Json.Linq;
using SavegameToolkit.Types;
using System;

namespace SavegameToolkit.Propertys {

    public class PropertyDouble : PropertyBase<double> {
        public static readonly ArkName TYPE = ArkName.ConstantPlain("DoubleProperty");
        public override ArkName Type => TYPE;

        public PropertyDouble() { }

        public PropertyDouble(string name, double value) : base(ArkName.From(name), 0, value) { }

        public PropertyDouble(string name, int index, double value) : base(ArkName.From(name), index, value) { }

        public override void Init(ArkArchive archive, ArkName name) {
            base.Init(archive, name);
            Value = archive.ReadDouble();
        }

        public override void Init(JObject node) {
            base.Init(node);
            Value = node.Value<double>("value");
        }

        protected override void writeBinaryValue(ArkArchive archive) => archive.WriteDouble(Value);

        protected override int calculateDataSize(NameSizeCalculator nameSizer) => sizeof(double);
    }

}
