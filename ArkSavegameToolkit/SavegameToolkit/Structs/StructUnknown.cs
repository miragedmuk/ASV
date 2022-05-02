using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Propertys;

namespace SavegameToolkit.Structs {
    public class StructUnknown : StructBase {
        private readonly byte[] value;

        public StructUnknown(ArkArchive archive, int dataSize) {
            value = archive.ReadBytes(dataSize);
        }

        public StructUnknown(JToken node) {
            try {
                value = node.ToObject<byte[]>();
            } catch (FormatException ex) {
                throw new UnreadablePropertyException(ex);
            }
        }

        public override void Init(ArkArchive archive) => throw new NotImplementedException();

        public override void Init(JObject node) => throw new NotImplementedException();

        public override void WriteJson(JsonTextWriter generator, WritingOptions writingOptions) => generator.WriteValue(value);

        public override void WriteBinary(ArkArchive archive) => archive.WriteBytes(value);

        public override int Size(NameSizeCalculator nameSizer) => value.Length;
    }
}
