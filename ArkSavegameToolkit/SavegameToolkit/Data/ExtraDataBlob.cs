using Newtonsoft.Json;

namespace SavegameToolkit.Data {
    public class ExtraDataBlob : IExtraData {

        public byte[] Data { get; set; }

        public int CalculateSize(NameSizeCalculator nameSizer) {
            return Data?.Length ?? 0;
        }

    }
}
