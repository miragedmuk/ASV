using SavegameToolkit.Propertys;
using SavegameToolkit.Types;
using System;

namespace SavegameToolkit.Arrays {

    public class ArkArrayBool : ArkArrayBase<bool> {

        public static readonly ArkName TYPE = ArkName.ConstantPlain("BoolProperty");

       //private static long serialVersionUID = 1L;

        public override void Init(ArkArchive archive, PropertyArray property) {
            int size = archive.ReadInt();

            for (int n = 0; n < size; n++) {
                Add(archive.ReadByte() != 0);
            }
        }

        public override ArkName Type => TYPE;

        public override int CalculateSize(NameSizeCalculator nameSizer) {
            return sizeof(int) + Count;
        }

        public override void WriteBinary(ArkArchive archive) {
            archive.WriteInt(Count);

            ForEach(b => archive.WriteByte((byte)(b ? 1 : 0)));
        }

    }

}
