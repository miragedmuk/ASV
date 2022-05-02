using Newtonsoft.Json;

namespace SavegameToolkit.Data {
    public class ExtraDataCharacter : IExtraData {
        public int CalculateSize(NameSizeCalculator nameSizer) => 8;

        public void WriteJson(JsonTextWriter generator, WritingOptions writingOptions) => generator.WriteNull();

        public void WriteBinary(ArkArchive archive) {
            archive.WriteInt(0);
            archive.WriteInt(1);
        }
    }
}
