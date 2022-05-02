using SavegameToolkit.Propertys;
using SavegameToolkit.Types;
using System;

namespace SavegameToolkit.Arrays {

    public class ArkArrayFloat : ArkArrayBase<float> {

        public static readonly ArkName TYPE = ArkName.ConstantPlain("FloatProperty");

        //private static long serialVersionUID = 1L;

        public override void Init(ArkArchive archive, PropertyArray property) {
            int size = archive.ReadInt();

            for (int n = 0; n < size; n++) {
                Add(archive.ReadFloat());
            }
        }

        public override ArkName Type => TYPE;

        public override int CalculateSize(NameSizeCalculator nameSizer) {
            return sizeof(int) + Count * sizeof(float);
        }

        public override void WriteBinary(ArkArchive archive) {
            archive.WriteInt(Count);

            ForEach(archive.WriteFloat);
        }

    }

}
