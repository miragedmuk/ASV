using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Types;

namespace SavegameToolkit {

    [JsonObject(MemberSerialization.OptIn)]
    public class HibernationEntry : GameObjectContainerMixin {

        [JsonProperty(Order = 0)]
        public float X { get; set; }
        [JsonProperty(Order = 1)]
        public float Y { get; set; }
        [JsonProperty(Order = 2)]
        public float Z { get; set; }

        [JsonProperty(Order = 3)]
        public byte UnkByte { get; set; }
        [JsonProperty(Order = 4)]
        public float UnkFloat { get; set; }

        [JsonProperty("Zones", Order = 5)]
        public List<ArkName> ZoneVolumes { get; } = new List<ArkName>();

        [JsonProperty(Order = 6)]
        public override List<GameObject> Objects { get; } = new List<GameObject>();

        [JsonProperty(Order = 7)]
        public int UnkInt1 { get; set; }

        [JsonProperty(Order = 8)]
        public int ClassIndex { get; set; }

        private List<string> nameTable;

        private int nameTableSize;

        private int objectsSize;

        private int propertiesStart;

        public HibernationEntry(ArkArchive archive, ReadingOptions options) {
            readBinary(archive, options);
        }

        private void readBinary(ArkArchive archive, ReadingOptions options) {
            X = archive.ReadFloat();
            Y = archive.ReadFloat();
            Z = archive.ReadFloat();
            UnkByte = archive.ReadByte();
            UnkFloat = archive.ReadFloat();

            if (options.HibernationObjectProperties) {
                ArkArchive nameArchive = archive.Slice(archive.ReadInt());
                readBinaryNameTable(nameArchive);
            } else {
                archive.SkipBytes(archive.ReadInt());
                nameTable = null;

                // Unknown data since the missed names are unrelated to the main nameTable
                archive.HasUnknownData = true;
            }

            ArkArchive objectArchive = archive.Slice(archive.ReadInt());
            readBinaryObjects(objectArchive, options);

            UnkInt1 = archive.ReadInt();
            ClassIndex = archive.ReadInt();
        }

        private void readBinaryNameTable(ArkArchive archive) {
            int version = archive.ReadInt();
            if (version != 3) {
                archive.DebugMessage($"Found unknown Version {version}", -4);
                throw new NotSupportedException();
            }

            int count = archive.ReadInt();
            nameTable = new List<string>(count);

            for (int index = 0; index < count; index++) {
                nameTable.Add(archive.ReadString());
            }

            int zoneCount = archive.ReadInt();

            for (int index = 0; index < zoneCount; index++) {
                ZoneVolumes.Add(archive.ReadName());
            }
        }

        private void readBinaryObjects(ArkArchive archive, ReadingOptions options) {
            int count = archive.ReadInt();

            Objects.Clear();
            Objects.Capacity = count;
            ObjectMap.Clear();
            for (int index = 0; index < count; index++) {
                addObject(new GameObject(archive), options.BuildComponentTree);
            }

            if (nameTable == null)
                return;
            archive.SetNameTable(nameTable, 0, true);

            for (int index = 0; index < count; index++) {
                Objects[index].LoadProperties(archive, index + 1 < count ? Objects[index + 1] : null, 0);
            }
        }


        public int GetSizeAndCollectNames() {
            // x y z unkFloat, unkByte, unkInt1 classIndex nameTableSize objectsSize
            const int size = sizeof(float) * 4 + 1 + sizeof(int) * 4;

            HashSet<string> names = new HashSet<string>();
            foreach (GameObject gameObject in Objects) {
                gameObject.CollectPropertyNames(name => names.Add(name.ToString()));
            }

            NameSizeCalculator objectSizer = ArkArchive.GetNameSizer(false);
            NameSizeCalculator propertiesSizer = ArkArchive.GetNameSizer(true, true);

            nameTableSize = sizeof(int) * 3;
            nameTable = new List<string>(names);

            nameTableSize += nameTable.Sum(ArkArchive.GetStringLength);
            nameTableSize += ZoneVolumes.Sum(name => objectSizer(name));

            objectsSize = sizeof(int);

            objectsSize += Objects.Sum(go => go.Size(objectSizer));

            propertiesStart = objectsSize;

            objectsSize += Objects.Sum(go => go.PropertiesSize(propertiesSizer));

            return size + nameTableSize + objectsSize;
        }

        public override GameObject this[int id] => id > 0 && id <= Objects.Count ? Objects[id - 1] : null;

        public override GameObject this[ObjectReference reference] {
            get {
                if (reference == null || !reference.IsId) {
                    return null;
                }

                if (reference.ObjectId > 0 && reference.ObjectId <= Objects.Count) {
                    return Objects[reference.ObjectId - 1];
                }

                return null;
            }
        }

    }

}
