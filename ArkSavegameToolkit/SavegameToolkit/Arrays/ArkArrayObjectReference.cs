using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Propertys;
using SavegameToolkit.Types;

namespace SavegameToolkit.Arrays {

    public class ArkArrayObjectReference : ArkArrayBase<ObjectReference> {

        public static readonly ArkName TYPE = ArkName.ConstantPlain("ObjectProperty");

        //private static long serialVersionUID = 1L;

        public override void Init(ArkArchive archive, PropertyArray property) {
            int size = archive.ReadInt();

            for (int n = 0; n < size; n++) {
                Add(new ObjectReference(archive, 8)); // Fixed size?
            }
        }

        public override void Init(JArray node, PropertyArray property) {
            AddRange(node.Select(n => new ObjectReference(n, 8)));
        }

        public override ArkName Type => TYPE;

        public override int CalculateSize(NameSizeCalculator nameSizer) {
            int size = sizeof(int);

            size += this.Sum(or => or.Size(nameSizer));

            return size;
        }

        public override void WriteJson(JsonTextWriter generator, WritingOptions writingOptions) {
            generator.WriteStartArray();

            ForEach(or => or.WriteJson(generator, writingOptions));

            generator.WriteEndArray();
        }

        public override void WriteBinary(ArkArchive archive) {
            archive.WriteInt(Count);

            ForEach(or => or.WriteBinary(archive));
        }

        public override void CollectNames(NameCollector collector) {
            ForEach(or => or.CollectNames(collector));
        }

    }

}
