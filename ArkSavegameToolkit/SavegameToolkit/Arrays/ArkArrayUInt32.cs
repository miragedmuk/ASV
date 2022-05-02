using SavegameToolkit.Types;
using System;

namespace SavegameToolkit.Arrays {

    public class ArkArrayUInt32 : ArkArrayInt {

        public new static readonly ArkName TYPE = ArkName.ConstantPlain("UInt32Property");

        //private static long serialVersionUID = 1L;

        public override ArkName Type => TYPE;

    }

}
