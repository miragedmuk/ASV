using System;
using Newtonsoft.Json.Linq;

namespace SavegameToolkit.Data {

    public class ExtraDataFallbackHandler : IExtraDataHandler {
        public bool CanHandle(GameObject gameObject, int length) {
            return true;
        }

        public bool CanHandle(GameObject gameObject, JToken node) {
            try {
                node.ToObject<byte[]>();
                return true;
            } catch (FormatException) { }
            return false;
        }

        public IExtraData ReadBinary(GameObject gameObject, ArkArchive archive, int length) {
            ExtraDataBlob extraData = new ExtraDataBlob();

            archive.DebugMessage($"Unknown extended data for {gameObject.ClassString} with length {length}");
            extraData.Data = archive.ReadBytes(length);
            archive.HasUnknownNames = true;

            return extraData;
        }


    }

}
