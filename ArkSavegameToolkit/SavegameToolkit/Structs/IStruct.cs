using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SavegameToolkit.Structs {

    public interface IStruct : INameContainer {

        bool IsNative { get; }
        int Size(NameSizeCalculator nameSizer);

        void Init(ArkArchive archive);
        
    }

}
