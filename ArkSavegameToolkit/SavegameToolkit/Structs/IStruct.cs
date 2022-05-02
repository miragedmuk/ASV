using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SavegameToolkit.Structs {

    public interface IStruct : INameContainer {

        bool IsNative { get; }
        void WriteJson(JsonTextWriter generator, WritingOptions writingOptions);
        void WriteBinary(ArkArchive archive);
        int Size(NameSizeCalculator nameSizer);

        void Init(ArkArchive archive);
        void Init(JObject node);
    }

}
