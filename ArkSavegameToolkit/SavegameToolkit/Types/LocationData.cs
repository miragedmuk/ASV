using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SavegameToolkit.Types {

    public class LocationData {

        public float X { get; private set; }

        public float Y { get; private set; }

        public float Z { get; private set; }

        public float Pitch { get; private set; }

        public float Yaw { get; private set; }

        public float Roll { get; private set; }

        public static int Size => sizeof(float) * 6;

        public LocationData(ArkArchive archive) {
            readBinary(archive);
        }


        public override string ToString() {
            return $"LocationData [X={X}, Y={Y}, Z={Z}, Pitch={Pitch}, Yaw={Yaw}, Roll={Roll}]";
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
