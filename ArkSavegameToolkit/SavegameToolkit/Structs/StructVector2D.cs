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

        public bool ShouldSerializeX() => Math.Abs(X) > 0f;
        public bool ShouldSerializeY() => Math.Abs(Y) > 0f;

        public override int Size(NameSizeCalculator nameSizer) => sizeof(float) * 2;
    }
}
