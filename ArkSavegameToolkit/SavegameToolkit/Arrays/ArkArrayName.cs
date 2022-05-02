using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Propertys;
using SavegameToolkit.Types;

namespace SavegameToolkit.Arrays {
    public class ArkArrayName: ArkArrayBase<ArkName> {

         public static readonly ArkName TYPE = ArkName.ConstantPlain("NameProperty");

        //private static long serialVersionUID = 1L;

        public override void Init(ArkArchive archive, PropertyArray property) {
            int size = archive.ReadInt();

            for (int n = 0; n < size; n++) {
                Add(archive.ReadName());
            }
        }

        public override void Init(JArray node, PropertyArray property) {
            AddRange(node.Select(n => ArkName.From(n.Value<string>())));
        }

        public override ArkName Type => TYPE;

        public override int CalculateSize(NameSizeCalculator nameSizer) {
            int size = sizeof(int);

            size += this.Sum(name => nameSizer(name));

            return size;
        }

        public override void WriteJson(JsonTextWriter writer, WritingOptions writingOptions) {
            //JsonSerializer.CreateDefault().Serialize(writer, this.Select(name => name.ToString()).ToArray());
            writer.WriteStartArray();

            foreach (ArkName value in this) {
                writer.WriteValue(value.ToString());
            }

            writer.WriteEndArray();
        }

        public override void WriteBinary(ArkArchive archive) {
            archive.WriteInt(Count);

            ForEach(archive.WriteName);
        }

        public override void CollectNames(NameCollector collector) {
            foreach (ArkName arkName in this) {
                collector(arkName);
            }
        }

    }
}
