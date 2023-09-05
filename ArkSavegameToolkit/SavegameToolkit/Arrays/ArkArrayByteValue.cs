using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Propertys;
using SavegameToolkit.Types;

namespace SavegameToolkit.Arrays {

    public class ArkArrayByteValue : ArkArrayBase<ArkByteValue> {

        //private static long serialVersionUID = 1L;

        public override void Init(ArkArchive archive, PropertyArray property) {
            int size = archive.ReadInt();

            for (int n = 0; n < size; n++) {
                Add(new ArkByteValue(archive.ReadName()));
            }
        }

        public override void Init(JArray node, PropertyArray property) {
            AddRange(node.Select(n => new ArkByteValue(ArkName.From(n.Value<string>()))));
        }

        public override ArkName Type => ArkArrayByteHandler.TYPE;

        public override int CalculateSize(NameSizeCalculator nameSizer) {
            return sizeof(int) + this.Sum(abv => nameSizer(abv.NameValue));
        }


        public override void CollectNames(NameCollector collector) {
            foreach (ArkByteValue bv in this) {
                collector(bv.NameValue);
            }
        }

    }

}
