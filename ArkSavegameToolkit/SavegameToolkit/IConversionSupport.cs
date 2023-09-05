using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SavegameToolkit {

    public interface IConversionSupport {
        void ReadBinary(ArkArchive archive, ReadingOptions options);

    }

}
