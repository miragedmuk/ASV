using Newtonsoft.Json.Linq;
using System;

namespace SavegameToolkit.Data {

    public class ExtraDataCharacterHandler : IExtraDataHandler {
        private static readonly ExtraDataCharacter instance = new ExtraDataCharacter();

        public bool CanHandle(GameObject gameObject, int length) {
            if ((gameObject.ClassString.Contains("_Character_") || gameObject.ClassString.StartsWith("PlayerPawnTest_")) && length == 8)
                return true;
            if ((gameObject.ClassString == "Pteroteuthis_Char_BP_C" || gameObject.ClassString == "Pteroteuthis_Char_BP_Surface_C") && length == 8) {
                return true;
            }

            return false;
        }

        public bool CanHandle(GameObject gameObject, JToken node) {
            if ((gameObject.ClassString.Contains("_Character_") || gameObject.ClassString.StartsWith("PlayerPawnTest_")) && node.Type == JTokenType.Null) {
                return true;
            }
            if ((gameObject.ClassString == "Pteroteuthis_Char_BP_C" || gameObject.ClassString == "Pteroteuthis_Char_BP_Surface_C") && node.Type == JTokenType.Null) {
                return true;
            }

            return false;
        }

        public IExtraData ReadBinary(GameObject gameObject, ArkArchive archive, int length) {
            int shouldBeZero = archive.ReadInt();
            if (shouldBeZero != 0) {
                throw new UnexpectedDataException($"Expected int after properties to be 0 but found {shouldBeZero} at {archive.Position - 4:X4}");
            }

            int shouldBeOne = archive.ReadInt();
            if (shouldBeOne != 1) {
                throw new UnexpectedDataException($"Expected int after properties to be 1 but found {shouldBeOne} at {archive.Position - 4:X4}");
            }

            return instance;
        }

        public IExtraData ReadJson(GameObject gameObject, JToken node) {
            return instance;
        }
    }

}
