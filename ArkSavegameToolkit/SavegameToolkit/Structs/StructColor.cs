using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SavegameToolkit.Structs {

    [JsonObject(MemberSerialization.OptIn)]
    public class StructColor : StructBase {

        [JsonProperty(Order = 0)]
        public byte B { get; private set; }
        [JsonProperty(Order = 1)]
        public byte G { get; private set; }
        [JsonProperty(Order = 2)]
        public byte R { get; private set; }
        [JsonProperty(Order = 3)]
        public byte A { get; private set; }

        public override void Init(ArkArchive archive) {
            B = archive.ReadByte();
            G = archive.ReadByte();
            R = archive.ReadByte();
            A = archive.ReadByte();
        }

        public override void Init(JObject node) {
            B = node.Value<byte>("b");
            G = node.Value<byte>("g");
            R = node.Value<byte>("r");
            A = node.Value<byte>("a");
        }

        public override void WriteJson(JsonTextWriter writer, WritingOptions writingOptions) {
            writer.WriteStartObject();

            if (B != 0) {
                writer.WriteField("b", B);
            }

            if (G != 0) {
                writer.WriteField("g", G);
            }

            if (R != 0) {
                writer.WriteField("r", R);
            }

            if (A != 0) {
                writer.WriteField("a", A);
            }

            writer.WriteEndObject();
        }

        public bool ShouldSerializeR() => Math.Abs(R) > 0f;
        public bool ShouldSerializeG() => Math.Abs(G) > 0f;
        public bool ShouldSerializeB() => Math.Abs(B) > 0f;
        public bool ShouldSerializeA() => Math.Abs(A) > 0f;

        public override void WriteBinary(ArkArchive archive) {
            archive.WriteByte(B);
            archive.WriteByte(G);
            archive.WriteByte(R);
            archive.WriteByte(A);
        }

        public override int Size(NameSizeCalculator nameSizer) => sizeof(byte) * 4;
    }

}
