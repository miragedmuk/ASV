using Newtonsoft.Json.Linq;
using SavegameToolkit.Propertys;
using SavegameToolkit.Types;
using System;

namespace SavegameToolkit.Arrays {

    public class ArkArrayByteHandler {

        public static readonly ArkName TYPE = ArkName.ConstantPlain("ByteProperty");

        public static IArkArray create(ArkArchive archive, PropertyArray property) {
            int size = archive.ReadInt();

            if (property.DataSize < size + 4) {
                throw new UnreadablePropertyException("Found Array of ByteProperty with unexpected size.");
            }

            archive.Position = archive.Position - 4;

            if (property.DataSize > size + 4) {
                ArkArrayByteValue arkArrayByteValue = new ArkArrayByteValue();
                arkArrayByteValue.Init(archive, property);
                return arkArrayByteValue;
            }

            ArkArrayUInt8 arkArrayUInt8 = new ArkArrayUInt8();
            arkArrayUInt8.Init(archive, property);
            return arkArrayUInt8;
        }

        public static IArkArray create(JArray node, PropertyArray property) {
            // Enum version will have null as first element
            if (node.Count > 0 && node.First.Type == JTokenType.Null) {
                ArkArrayByteValue arkArrayByteValue = new ArkArrayByteValue();
                arkArrayByteValue.Init(node, property);
                return arkArrayByteValue;
            }

            ArkArrayUInt8 arkArrayUInt8 = new ArkArrayUInt8();
            arkArrayUInt8.Init(node, property);
            return arkArrayUInt8;
        }

    }

}
