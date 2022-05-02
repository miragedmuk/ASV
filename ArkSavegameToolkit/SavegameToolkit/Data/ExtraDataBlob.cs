using Newtonsoft.Json;

namespace SavegameToolkit.Data {
    public class ExtraDataBlob : IExtraData {

        public byte[] Data { get; set; }

        public int CalculateSize(NameSizeCalculator nameSizer) {
            return Data?.Length ?? 0;
        }

        public void WriteJson(JsonTextWriter generator, WritingOptions writingOptions) {
            generator.WriteValue(Data);
        }

        public void WriteBinary(ArkArchive archive) {
            if (Data != null) {
                archive.WriteBytes(Data);
            }
        }
    }
}
