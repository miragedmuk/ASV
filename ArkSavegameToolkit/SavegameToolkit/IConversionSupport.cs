using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SavegameToolkit {

    public interface IConversionSupport {
        void ReadBinary(ArkArchive archive, ReadingOptions options);

        void WriteBinary(ArkArchive archive, WritingOptions options);

        int CalculateSize();

        void ReadJson(JToken node, ReadingOptions options);

        void WriteJson(JsonTextWriter generator, WritingOptions options);
    }

}
