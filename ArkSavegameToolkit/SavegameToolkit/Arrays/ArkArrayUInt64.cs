using SavegameToolkit.Types;
using System;

namespace SavegameToolkit.Arrays {

    public class ArkArrayUInt64 : ArkArrayInt64 {

        public new static readonly ArkName TYPE = ArkName.ConstantPlain("UInt64Property");

        //private static long serialVersionUID = 1L;

        public override ArkName Type => TYPE;

    }

}
