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

        public EmbeddedData(JObject node) {
            readJson(node);
        }

        [JsonProperty(Order = 0)]
        public string Path { get; set; }

        [JsonProperty(Order = 1)]
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

        private void readJson(JObject node) {
            Path = node.Value<string>("path");

            JArray dataValue = node.Value<JArray>("data");

            if (dataValue != null) {
                Data = new byte[dataValue.Count][][];
                for (int part = 0; part < dataValue.Count; part++) {
                    JArray partArray = dataValue.Value<JArray>(part);
                    Data[part] = new byte[partArray.Count][];
                    for (int blob = 0; blob < partArray.Count; blob++) {
                        Data[part][blob] = partArray[blob].ToObject<byte[]>();
                    }
                }
            }
        }

        public void WriteJson(JsonTextWriter writer) {
            //JsonSerializer.CreateDefault().Serialize(writer, this);
            writer.WriteStartObject();

            writer.WriteField("path", Path);

            writer.WriteArrayFieldStart("data");
            foreach (byte[][] baa in Data) {
                writer.WriteStartArray();
                foreach (byte[] ba in baa) {
                    writer.WriteValue(ba);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndArray();

            writer.WriteEndObject();
        }

        public void WriteBinary(ArkArchive archive) {
            archive.WriteString(Path);

            if (Data != null) {
                archive.WriteInt(Data.Length);
                foreach (byte[][] partData in Data) {
                    archive.WriteInt(partData.Length);
                    foreach (byte[] blobData in partData) {
                        archive.WriteInt(blobData.Length / 4);
                        archive.WriteBytes(blobData);
                    }
                }
            } else {
                archive.WriteInt(0);
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
