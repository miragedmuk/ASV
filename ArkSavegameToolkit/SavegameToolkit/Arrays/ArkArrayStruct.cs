using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Propertys;
using SavegameToolkit.Structs;
using SavegameToolkit.Types;

namespace SavegameToolkit.Arrays
{

    public class ArkArrayStruct : ArkArrayBase<IStruct>
    {

        public static readonly ArkName TYPE = ArkName.ConstantPlain("StructProperty");

        //private static long serialVersionUID = 1L;

        private static readonly ArkName color = ArkName.ConstantPlain("Color");

        private static readonly ArkName vector = ArkName.ConstantPlain("Vector");

        private static readonly ArkName linearColor = ArkName.ConstantPlain("LinearColor");

        private static readonly ArkName customItemDatas = ArkName.ConstantPlain("CustomItemDatas");

        public override void Init(ArkArchive archive, PropertyArray property)
        {
            int size = archive.ReadInt();

            ArkName structType = StructRegistry.MapArrayNameToTypeName(property.Name);

            // In versions 11 and above, CustomItemDatas properties seem to be redirected into separate archives. This
            // is likely due to ARK writing different save file segments in memory first to circumvent internal 2GB
            // limits on in-memory writes.
            // The redirector seems to be implemented in a similar way to "plain" structs like Vectors, Quats, Colours.
            // If the conditions match, let's take a detour here.
            if (archive.SaveVersion > 10 && structType == null && property.Name == customItemDatas)
            {
                for (int n = 0; n < size; n++)
                {
                    StructCustomItemDataRef cidRef = new StructCustomItemDataRef();
                    cidRef.Init(archive);
                    Add(cidRef);
                }
                return;
            }

            if (structType == null)
            {
                if (size * 4 + 4 == property.DataSize)
                {
                    structType = color;
                }
                else if (size * 12 + 4 == property.DataSize)
                {
                    structType = vector;
                }
                else if (size * 16 + 4 == property.DataSize)
                {
                    structType = linearColor;
                }
            }

            for (int n = 0; n < size; n++)
            {
                try
                {
                    Add(StructRegistry.ReadBinary(archive, structType));
                }
                catch
                {

                }
                 
            }
        }

        public override ArkName Type => TYPE;

        public override int CalculateSize(NameSizeCalculator nameSizer)
        {
            int size = sizeof(int);

            size += this.Sum(s => s.Size(nameSizer));

            return size;
        }

        

        public override void CollectNames(NameCollector collector)
        {
            ForEach(spl => spl.CollectNames(collector));
        }

    }

}