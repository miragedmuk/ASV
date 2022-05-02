using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SavegameToolkit.Types {

    [JsonObject(MemberSerialization.OptIn)]
    public class LocationData {

        [JsonProperty(Order = 0)]
        public float X { get; private set; }

        [JsonProperty(Order = 1)]
        public float Y { get; private set; }

        [JsonProperty(Order = 2)]
        public float Z { get; private set; }

        [JsonProperty(Order = 3)]
        public float Pitch { get; private set; }

        [JsonProperty(Order = 4)]
        public float Yaw { get; private set; }

        [JsonProperty(Order = 5)]
        public float Roll { get; private set; }

        public static int Size => sizeof(float) * 6;

        public LocationData(ArkArchive archive) {
            readBinary(archive);
        }

        public LocationData(JToken node) {
            readJson(node);
        }

        public override string ToString() {
            return $"LocationData [X={X}, Y={Y}, Z={Z}, Pitch={Pitch}, Yaw={Yaw}, Roll={Roll}]";
        }

        private void readJson(JToken node) {
            X = node.Value<float>("x");
            Y = node.Value<float>("y");
            Z = node.Value<float>("z");
            Pitch = node.Value<float>("pitch");
            Yaw = node.Value<float>("yaw");
            Roll = node.Value<float>("roll");
        }

        public void WriteJson(JsonTextWriter writer) {
            writer.WriteStartObject();
            if (Math.Abs(X) > 0f) {
                writer.WriteField("x", X);
            }
            if (Math.Abs(Y) > 0f) {
                writer.WriteField("y", Y);
            }
            if (Math.Abs(Z) > 0f) {
                writer.WriteField("z", Z);
            }
            if (Math.Abs(Pitch) > 0f) {
                writer.WriteField("pitch", Pitch);
            }
            if (Math.Abs(Yaw) > 0f) {
                writer.WriteField("yaw", Yaw);
            }
            if (Math.Abs(Roll) > 0f) {
                writer.WriteField("roll", Roll);
            }
            writer.WriteEndObject();
        }

        public bool ShouldSerializeX() => Math.Abs(X) > 0;
        public bool ShouldSerializeY() => Math.Abs(Y) > 0;
        public bool ShouldSerializeZ() => Math.Abs(Z) > 0;
        public bool ShouldSerializePitch() => Math.Abs(Pitch) > 0;
        public bool ShouldSerializeYaw() => Math.Abs(Yaw) > 0;
        public bool ShouldSerializeRoll() => Math.Abs(Roll) > 0;

        private void readBinary(ArkArchive archive) {
            X = archive.ReadFloat();
            Y = archive.ReadFloat();
            Z = archive.ReadFloat();
            Pitch = archive.ReadFloat();
            Yaw = archive.ReadFloat();
            Roll = archive.ReadFloat();
        }

        public void WriteBinary(ArkArchive archive) {
            archive.WriteFloat(X);
            archive.WriteFloat(Y);
            archive.WriteFloat(Z);
            archive.WriteFloat(Pitch);
            archive.WriteFloat(Yaw);
            archive.WriteFloat(Roll);
        }

        public void Skip(ArkArchive archive) {
            archive.SkipBytes(sizeof(float) * 6);
        }

    }

}
