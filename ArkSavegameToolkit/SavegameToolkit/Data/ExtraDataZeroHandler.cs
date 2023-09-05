using Newtonsoft.Json.Linq;
using System;

namespace SavegameToolkit.Data {

    public class ExtraDataZeroHandler : IExtraDataHandler {

        private static readonly ExtraDataZero instance = new ExtraDataZero();

        public bool CanHandle(GameObject gameObject, int length) {
            return length == 4;
        }

        public bool CanHandle(GameObject gameObject, JToken node) {
            return node.Type == JTokenType.Null;
        }

        public IExtraData ReadBinary(GameObject gameObject, ArkArchive archive, int length) {
            int shouldBeZero = archive.ReadInt();
            if (shouldBeZero != 0) {
                throw new UnexpectedDataException(
                        $"Expected int after properties to be 0 but found {shouldBeZero} at {archive.Position- 4:X4}");
            }

            return instance;
        }

    }

}
