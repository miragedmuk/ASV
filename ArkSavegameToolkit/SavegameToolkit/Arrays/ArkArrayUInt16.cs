using SavegameToolkit.Types;
using System;

namespace SavegameToolkit.Arrays {

    public class ArkArrayUInt16 : ArkArrayInt16 {

        public new static readonly ArkName TYPE = ArkName.ConstantPlain("UInt16Property");

        //private static long serialVersionUID = 1L;

        public override ArkName Type => TYPE;

    }

}
