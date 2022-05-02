using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Propertys;
using SavegameToolkit.Types;

namespace SavegameToolkit.Arrays {

    public class ArkArrayUnknown : ArkArrayBase<byte> {

        public override ArkName Type { get; }

        public ArkArrayUnknown(ArkArchive archive, int size, ArkName type) {
            AddRange(archive.ReadBytes(size));
            Type = type;
        }

        public ArkArrayUnknown(JToken node, ArkName type) {
            AddRange(node.ToObject<byte[]>());
            Type = type;
        }

        public override void Init(ArkArchive archive, PropertyArray property) {
            throw new System.NotImplementedException();
        }

        public override void Init(JArray node, PropertyArray property) {
            throw new System.NotImplementedException();
        }

        public override int CalculateSize(NameSizeCalculator nameSizer) {
            return Count;
        }

        public override void WriteJson(JsonTextWriter generator, WritingOptions writingOptions) {
            generator.WriteValue(ToArray());
        }

        public override void WriteBinary(ArkArchive archive) {
            archive.WriteBytes(ToArray());
        }

    }

}
