using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Propertys;

namespace SavegameToolkit {

    public class ArkLocalProfile : GameObjectContainerMixin, IConversionSupport, IPropertyContainer {

        private static readonly int UNKNOWN_DATA_2_SIZE = 0xc;

        public int LocalProfileVersion { get; set; }

        private byte[] unknownData;

        private byte[] unknownData2;

        private GameObject localProfile;
        public GameObject LocalProfile {
            get => localProfile;
            set {
                if (localProfile != null) {
                    int oldIndex = Objects.IndexOf(localProfile);
                    if (oldIndex > -1) {
                        Objects.RemoveAt(oldIndex);
                    }
                }

                localProfile = value;
                if (value != null && Objects.IndexOf(value) == -1) {
                    Objects.Insert(0, value);
                }
            }
        }

        public List<IProperty> Properties => localProfile.Properties;

        private int propertiesBlockOffset;

        public void ReadBinary(ArkArchive archive, ReadingOptions options) {
            LocalProfileVersion = archive.ReadInt();

            if (LocalProfileVersion != 1 && LocalProfileVersion != 3 && LocalProfileVersion != 4) {
                throw new NotSupportedException("Unknown Profile Version " + LocalProfileVersion);
            }

            if (LocalProfileVersion < 4) {
                int unknownDataSize = archive.ReadInt();

                unknownData = archive.ReadBytes(unknownDataSize);

                if (LocalProfileVersion == 3) {
                    unknownData2 = archive.ReadBytes(UNKNOWN_DATA_2_SIZE);
                }
            }

            int objectCount = archive.ReadInt();

            Objects.Clear();
            ObjectMap.Clear();
            for (int i = 0; i < objectCount; i++) {
                addObject(new GameObject(archive), options.BuildComponentTree);
            }

            for (int i = 0; i < objectCount; i++) {
                GameObject gameObject = Objects[i];
                if (gameObject.ClassString == "PrimalLocalProfile") {
                    localProfile = gameObject;
                }

                gameObject.LoadProperties(archive, i < objectCount - 1 ? Objects[i + 1] : null, 0);
            }
        }

        public void WriteBinary(ArkArchive archive, WritingOptions options) {
            archive.WriteInt(LocalProfileVersion);

            if (LocalProfileVersion < 4) {
                archive.WriteInt(unknownData.Length);
                archive.WriteBytes(unknownData);

                if (LocalProfileVersion == 3) {
                    archive.WriteBytes(unknownData2, 0, UNKNOWN_DATA_2_SIZE);
                }
            }

            archive.WriteInt(Objects.Count);

            foreach (GameObject gameObject in Objects) {
                propertiesBlockOffset = gameObject.WriteBinary(archive, propertiesBlockOffset);
            }

            foreach (GameObject gameObject in Objects) {
                gameObject.WriteProperties(archive, 0);
            }
        }

        public int CalculateSize() {
            int size;

            if (LocalProfileVersion > 3) {
                size = sizeof(int) * 2;
            } else {
                size = sizeof(int) * 3;

                if (LocalProfileVersion == 3) {
                    if (unknownData2 == null) {
                        unknownData2 = new byte[UNKNOWN_DATA_2_SIZE];
                    } else if (unknownData2.Length < UNKNOWN_DATA_2_SIZE) {
                        byte[] temp = new byte[UNKNOWN_DATA_2_SIZE];
                        unknownData2.CopyTo(temp, 0);
                        unknownData2 = temp;
                    }
                }

                size += unknownData.Length;

                if (LocalProfileVersion == 3) {
                    size += UNKNOWN_DATA_2_SIZE;
                }
            }

            NameSizeCalculator nameSizer = ArkArchive.GetNameSizer(false);

            size += Objects.Sum(o => o.Size(nameSizer));

            propertiesBlockOffset = size;

            size += Objects.Sum(o => o.PropertiesSize(nameSizer));
            return size;
        }

        public void ReadJson(JToken node, ReadingOptions options) {
            LocalProfileVersion = node.Value<int>("localProfileVersion");

            Objects.Clear();
            ObjectMap.Clear();
            JToken localProfileNode = node["localProfile"];
            if (localProfileNode != null && localProfileNode.Type != JTokenType.Null) {
                addObject(new GameObject((JObject)localProfileNode), options.BuildComponentTree);
                localProfile = Objects[0];
            }

            JToken objectsNode = node["objects"];
            if (objectsNode != null && objectsNode.Type != JTokenType.Null) {
                foreach (JToken objectNode in objectsNode) {
                    addObject(new GameObject((JObject)objectNode), options.BuildComponentTree);
                }
            }

            JToken unknownDataString = node["unknownData"];
            if (unknownDataString.Type == JTokenType.Bytes) {
                unknownData = unknownDataString.Value<byte[]>();
            }

            JToken unknownData2String = node["unknownData2"];
            if (unknownData2String.Type == JTokenType.Bytes) {
                unknownData2 = unknownData2String.Value<byte[]>();
            }
        }

        public void WriteJson(JsonTextWriter generator, WritingOptions writingOptions) {
            generator.WriteStartObject();

            generator.WriteField("localProfileVersion", LocalProfileVersion);
            generator.WritePropertyName("localProfile");
            if (localProfile != null) {
                localProfile.WriteJson(generator, writingOptions);
            } else {
                generator.WriteNull();
            }

            if (Objects.Count > (localProfile == null ? 0 : 1)) {
                generator.WriteArrayFieldStart("objects");
                foreach (GameObject gameObject in Objects) {
                    if (gameObject == localProfile) {
                        continue;
                    }

                    gameObject.WriteJson(generator, writingOptions);
                }

                generator.WriteEndArray();
            }

            if (unknownData != null) {
                generator.WriteField("unknownData", unknownData);
            }

            if (unknownData2 != null) {
                generator.WriteField("unknownData2", unknownData2);
            }

            generator.WriteEndObject();
        }
    }

}
