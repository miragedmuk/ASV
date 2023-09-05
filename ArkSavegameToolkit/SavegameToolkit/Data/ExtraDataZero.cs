using Newtonsoft.Json;

namespace SavegameToolkit.Data {

    public class ExtraDataZero : IExtraData {

        public int CalculateSize(NameSizeCalculator nameSizer) {
            return 4;
        }


    }

}
