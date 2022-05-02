using Newtonsoft.Json.Linq;
using SavegameToolkit.Types;
using System;

namespace SavegameToolkit.Propertys {

    public class PropertyInt8 : PropertyBase<sbyte> {
        public static readonly ArkName TYPE = ArkName.ConstantPlain("Int8Property");
        public override ArkName Type => TYPE;

        public PropertyInt8() { }

        public PropertyInt8(string name, sbyte value) : base(ArkName.From(name), 0, value) { }

        public PropertyInt8(string name, int index, sbyte value) : base(ArkName.From(name), index, value) { }

        public override void Init(ArkArchive archive, ArkName name) {
            base.Init(archive, name);
            Value = archive.ReadSByte();
        }

        public override void Init(JObject node) {
            base.Init(node);
            Value = node.Value<sbyte>("value");
        }

        protected override void writeBinaryValue(ArkArchive archive) => archive.WriteSByte(Value);

        protected override int calculateDataSize(NameSizeCalculator nameSizer) => sizeof(byte);
    }

}
