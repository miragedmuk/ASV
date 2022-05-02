using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SavegameToolkit.Structs {
    [JsonObject(MemberSerialization.OptIn)]
    public class StructVector2D : StructBase {

        [JsonProperty(Order = 0)]
        public float X { get; private set; }
        [JsonProperty(Order = 1)]
        public float Y { get; private set; }

        public override void Init(ArkArchive archive) {
            X = archive.ReadFloat();
            Y = archive.ReadFloat();
        }

        public override void Init(JObject node) {
            X = node.Value<float>("x");
            Y = node.Value<float>("y");
        }

        public override void WriteJson(JsonTextWriter generator, WritingOptions writingOptions) {
            generator.WriteStartObject();

            if (Math.Abs(X) > 0f) {
                generator.WriteField("x", X);
            }
            if (Math.Abs(Y) > 0f) {
                generator.WriteField("y", Y);
            }

            generator.WriteEndObject();
        }

        public bool ShouldSerializeX() => Math.Abs(X) > 0f;
        public bool ShouldSerializeY() => Math.Abs(Y) > 0f;

        public override void WriteBinary(ArkArchive archive) {
            archive.WriteFloat(X);
            archive.WriteFloat(Y);
        }

        public override int Size(NameSizeCalculator nameSizer) => sizeof(float) * 2;
    }
}
