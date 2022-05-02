using Newtonsoft.Json.Linq;
using SavegameToolkit.Types;
using System;

namespace SavegameToolkit.Propertys {

    public class PropertyString : PropertyBase<string> {
        public static readonly ArkName TYPE = ArkName.ConstantPlain("StrProperty");
        public override ArkName Type => TYPE;

        public PropertyString() { }

        public PropertyString(string name, string value) : base(ArkName.From(name), 0, value) { }

        public PropertyString(string name, int index, string value) : base(ArkName.From(name), index, value) { }

        public override void Init(ArkArchive archive, ArkName name) {
            base.Init(archive, name);
            Value = archive.ReadString();
        }

        public override void Init(JObject node) {
            base.Init(node);
            Value = node.Value<string>("value");
        }

        protected override void writeBinaryValue(ArkArchive archive) => archive.WriteString(Value);

        protected override int calculateDataSize(NameSizeCalculator nameSizer) => ArkArchive.GetStringLength(Value);
    }

}
