using SavegameToolkit.Propertys;
using SavegameToolkit.Types;
using System;

namespace SavegameToolkit.Arrays {

    public class ArkArrayInt64 : ArkArrayBase<long> {

        public static readonly ArkName TYPE = ArkName.ConstantPlain("Int64Property");

        //private static long serialVersionUID = 1L;

        public override void Init(ArkArchive archive, PropertyArray property) {
            int size = archive.ReadInt();

            for (int n = 0; n < size; n++) {
                Add(archive.ReadLong());
            }
        }

        public override ArkName Type => TYPE;

        public override int CalculateSize(NameSizeCalculator nameSizer) {
            return sizeof(int) + Count * sizeof(long);
        }

        public override void WriteBinary(ArkArchive archive) {
            archive.WriteInt(Count);

            ForEach(archive.WriteLong);
        }

    }

}
