using SavegameToolkit.Types;
using System;

namespace SavegameToolkit.Propertys {

    public class PropertyUInt32 : PropertyInt {
        public new static readonly ArkName TYPE = ArkName.ConstantPlain("UInt32Property");
        public override ArkName Type => TYPE;

        public PropertyUInt32() { }

        public PropertyUInt32(string name, int value) : base(name, value) { }

        public PropertyUInt32(string name, int index, int value) : base(name, index, value) { }
    }

}
