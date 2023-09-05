using Newtonsoft.Json;

namespace SavegameToolkit.Data {
    public class ExtraDataCharacter : IExtraData {
        public int CalculateSize(NameSizeCalculator nameSizer) => 8;

    }
}
