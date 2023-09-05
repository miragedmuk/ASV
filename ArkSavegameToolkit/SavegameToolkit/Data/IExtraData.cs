using System;
using Newtonsoft.Json;

namespace SavegameToolkit.Data {

    public interface IExtraData {
        int CalculateSize(NameSizeCalculator nameSizer);

    }



}
