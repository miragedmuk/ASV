using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SavegameToolkit.Types {

    [JsonObject(MemberSerialization.OptIn)]
    public class EmbeddedData {

        public EmbeddedData() { }

        public EmbeddedData(ArkArchive archive) {
            readBinary(archive);
        }
        public string Path { get; set; }

        public byte[][][] Data { get; set; }

        public int Size {
            get {
                int size = ArkArchive.GetStringLength(Path) + 4;

                if (Data == null)
                    return size;
                size += Data.Length * 4;
                foreach (byte[][] partData in Data) {
                    if (partData != null) {
                        size += partData.Length * 4;
                        size += partData.Sum(blobData => blobData.Length);
                    }
                }

                return size;
            }
        }

        private void readBinary(ArkArchive archive) {
            Path = archive.ReadString();

            int partCount = archive.ReadInt();

            Data = new byte[partCount][][];
            for (int part = 0; part < partCount; part++) {
                int blobCount = archive.ReadInt();
                byte[][] partData = new byte[blobCount][];

                for (int blob = 0; blob < blobCount; blob++) {
                    int blobSize = archive.ReadInt() * 4; // Array of 32 bit values
                    partData[blob] = archive.ReadBytes(blobSize);
                }

                Data[part] = partData;
            }
        }

        public static void Skip(ArkArchive archive) {
            archive.SkipString();

            int partCount = archive.ReadInt();
            for (int part = 0; part < partCount; part++) {
                int blobCount = archive.ReadInt();
                for (int blob = 0; blob < blobCount; blob++) {
                    int blobSize = archive.ReadInt() * 4;
                    archive.Position = archive.Position + blobSize;
                }
            }
        }

    }

}
