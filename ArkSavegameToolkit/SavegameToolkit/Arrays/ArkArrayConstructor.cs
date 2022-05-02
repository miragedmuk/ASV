using Newtonsoft.Json.Linq;
using SavegameToolkit.Propertys;

namespace SavegameToolkit.Arrays {

    public class ArkArrayConstructor {

        public delegate IArkArray Binary(ArkArchive archive, PropertyArray property);

        public delegate IArkArray Json(JArray node, PropertyArray property);
        
        public Binary BinaryConstructor { get; }
        public Json JsonConstructor { get; }

        public ArkArrayConstructor(Binary binaryConstructor, Json jsonConstructor) {
            BinaryConstructor = binaryConstructor;
            JsonConstructor = jsonConstructor;
        }

    }

}