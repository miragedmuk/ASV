using Newtonsoft.Json.Linq;
using SavegameToolkit.Types;
using System;

namespace SavegameToolkit.Propertys {

    public class PropertyInt : PropertyBase<int> {
        public static readonly ArkName TYPE = ArkName.ConstantPlain("IntProperty");
        public override ArkName Type => TYPE;

        public PropertyInt() { }

        public PropertyInt(string name, int value) : base(ArkName.From(name), 0, value) { }

        public PropertyInt(string name, int index, int value) : base(ArkName.From(name), index, value) { }

        public override void Init(ArkArchive archive, ArkName name) {
            base.Init(archive, name);
            Value = archive.ReadInt();
        }

        public override void Init(JObject node) {
            base.Init(node);
            Value = node.Value<int>("value");
        }

        protected override int calculateDataSize(NameSizeCalculator nameSizer) => sizeof(int);
    }

}
