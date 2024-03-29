﻿using System;
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


        public bool ShouldSerializeR() => Math.Abs(R) > 0f;
        public bool ShouldSerializeG() => Math.Abs(G) > 0f;
        public bool ShouldSerializeB() => Math.Abs(B) > 0f;
        public bool ShouldSerializeA() => Math.Abs(A) > 0f;

        public override int Size(NameSizeCalculator nameSizer) => sizeof(byte) * 4;
    }

}
