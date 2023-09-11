using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SavegameToolkit.Structs {

    [JsonObject(MemberSerialization.OptIn)]
    public class StructLinearColor : StructBase {

        [JsonProperty(Order = 0)]
        public float R { get; private set; }
        [JsonProperty(Order = 1)]
        public float G { get; private set; }
        [JsonProperty(Order = 2)]
        public float B { get; private set; }
        [JsonProperty(Order = 3)]
        public float A { get; private set; }

        public override void Init(ArkArchive archive) {
            R = archive.ReadFloat();
            G = archive.ReadFloat();
            B = archive.ReadFloat();
            A = archive.ReadFloat();
        }


        public bool ShouldSerializeR() => Math.Abs(R) > 0f;
        public bool ShouldSerializeG() => Math.Abs(G) > 0f;
        public bool ShouldSerializeB() => Math.Abs(B) > 0f;
        public bool ShouldSerializeA() => Math.Abs(A) > 0f;


        public override int Size(NameSizeCalculator nameSizer) => sizeof(float) * 4;
    }

}
