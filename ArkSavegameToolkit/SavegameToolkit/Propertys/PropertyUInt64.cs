using SavegameToolkit.Types;
using System;

namespace SavegameToolkit.Propertys {

    public class PropertyUInt64 : PropertyInt64 {
        public new static readonly ArkName TYPE = ArkName.ConstantPlain("UInt64Property");
        public override ArkName Type => TYPE;

        public PropertyUInt64() { }

        public PropertyUInt64(string name, long value) : base(name, value) { }

        public PropertyUInt64(string name, int index, long value) : base(name, index, value) { }
    }

}
