using Newtonsoft.Json;

namespace SavegameToolkit.Data {

    public class ExtraDataZero : IExtraData {

        public int CalculateSize(NameSizeCalculator nameSizer) {
            return 4;
        }

        public void WriteJson(JsonTextWriter generator, WritingOptions writingOptions) {
            generator.WriteNull();
        }

        public void WriteBinary(ArkArchive archive) {
            archive.WriteInt(0);
        }

    }

}
