using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Propertys;
using SavegameToolkit.Structs;
using SavegameToolkit.Types;

namespace SavegameToolkit.Arrays {

    public class ArkArrayStruct : ArkArrayBase<IStruct> {

        public static readonly ArkName TYPE = ArkName.ConstantPlain("StructProperty");

        //private static long serialVersionUID = 1L;

        private static readonly ArkName color = ArkName.ConstantPlain("Color");

        private static readonly ArkName vector = ArkName.ConstantPlain("Vector");

        private static readonly ArkName linearColor = ArkName.ConstantPlain("LinearColor");

        public override void Init(ArkArchive archive, PropertyArray property) {
            int size = archive.ReadInt();

            ArkName structType = StructRegistry.MapArrayNameToTypeName(property.Name);
            if (structType == null) {
                if (size * 4 + 4 == property.DataSize) {
                    structType = color;
                } else if (size * 12 + 4 == property.DataSize) {
                    structType = vector;
                } else if (size * 16 + 4 == property.DataSize) {
                    structType = linearColor;
                }
            }

            for (int n = 0; n < size; n++) {
                Add(StructRegistry.ReadBinary(archive, structType));
            }
        }


        public override ArkName Type => TYPE;

        public override int CalculateSize(NameSizeCalculator nameSizer) {
            int size = sizeof(int);

            size += this.Sum(s => s.Size(nameSizer));

            return size;
        }

        public override void CollectNames(NameCollector collector) {
            ForEach(spl => spl.CollectNames(collector));
        }

    }

}
