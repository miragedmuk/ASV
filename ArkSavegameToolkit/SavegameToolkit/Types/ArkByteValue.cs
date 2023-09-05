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
