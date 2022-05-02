using Newtonsoft.Json.Linq;

namespace SavegameToolkit.Data {

    public interface IExtraDataHandler {

        bool CanHandle(GameObject gameObject, int length);

        bool CanHandle(GameObject gameObject, JToken node);

        IExtraData ReadBinary(GameObject gameObject, ArkArchive archive, int length);

        IExtraData ReadJson(GameObject gameObject, JToken node);

    }

}
