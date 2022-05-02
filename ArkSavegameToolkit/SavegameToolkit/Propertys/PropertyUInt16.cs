using SavegameToolkit.Types;
using System;

namespace SavegameToolkit.Propertys {

    public class PropertyUInt16 : PropertyInt16 {
        public new static readonly ArkName TYPE = ArkName.ConstantPlain("UInt16Property");
        public override ArkName Type => TYPE;

        public PropertyUInt16() { }

        public PropertyUInt16(string name, short value) : base(name, value) { }

        public PropertyUInt16(string name, int index, short value) : base(name, index, value) { }
    }

}
