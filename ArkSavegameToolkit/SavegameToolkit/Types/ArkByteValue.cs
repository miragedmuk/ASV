using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SavegameToolkit.Types {

    public class ArkByteValue : INameContainer {

        //public ArkByteValue() { }

        public ArkByteValue(byte byteValue) {
            ByteValue = byteValue;
        }

        public ArkByteValue(ArkName nameValue) {
            NameValue = nameValue;
        }

        public ArkByteValue(ArkArchive archive, bool name) {
            readBinary(archive, name);
        }

        public ArkByteValue(JToken node) {
            readJson(node);
        }

        public bool IsFromEnum() {
            return NameValue != null;
        }

        private byte byteValue;

        public byte ByteValue {
            get => byteValue;
            set {
                NameValue = null;
                byteValue = value;
            }
        }

        public ArkName NameValue { get; set; }

        private void readJson(JToken node) {
            if (node.Type == JTokenType.String) {
                NameValue = ArkName.From(node.Value<string>());
            } else {
                byteValue = node.Value<byte>();
            }
        }

        public void WriteJson(JsonTextWriter generator) {
            if (NameValue != null) {
                generator.WriteValue(NameValue.ToString());
            } else {
                generator.WriteValue(ByteValue);
            }
        }

        public int getSize(NameSizeCalculator nameSizer) {
            return NameValue != null ? nameSizer(NameValue) : 1;
        }

        private void readBinary(ArkArchive archive, bool name) {
            if (name) {
                NameValue = archive.ReadName();
            } else {
                byteValue = archive.ReadByte();
            }
        }

        public void WriteBinary(ArkArchive archive) {
            if (NameValue != null) {
                archive.WriteName(NameValue);
            } else {
                archive.WriteByte(ByteValue);
            }
        }

        public void CollectNames(NameCollector collector) {
            if (NameValue != null) {
                collector(NameValue);
            }
        }

        public override string ToString() {
            return $"ArkByteValue [{(NameValue != null ? $"nameValue={NameValue}" : $"byteValue={ByteValue}")}]";
        }

    }

}
