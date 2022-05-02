using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Arrays;

namespace SavegameToolkit {

    public sealed class ArkContainer : GameObjectContainerMixin, IConversionSupport {
        private int propertiesBlockOffset;

        public ArkContainer(ArkArrayUInt8 source) {
            MemoryStream buffer = new MemoryStream(source.ToArray());

            ArkArchive archive = new ArkArchive(buffer);
            ReadBinary(archive, new ReadingOptions());
        }

        public ArkContainer(ArkArrayInt8 source) {
            MemoryStream buffer = new MemoryStream(source.ToArray());

            ArkArchive archive = new ArkArchive(buffer);
            ReadBinary(archive, new ReadingOptions());
        }

        public void ReadBinary(ArkArchive archive, ReadingOptions options) {
            int objectCount = archive.ReadInt();

            Objects.Clear();
            ObjectMap.Clear();
            for (int i = 0; i < objectCount; i++) {
                addObject(new GameObject(archive), options.BuildComponentTree);
            }

            for (int i = 0; i < objectCount; i++) {
                Objects[i].LoadProperties(archive, i < objectCount - 1 ? Objects[i + 1] : null, 0);
            }
        }

        public void WriteBinary(ArkArchive archive, WritingOptions options) {
            archive.WriteInt(Objects.Count);

            foreach (GameObject gameObject in Objects) {
                propertiesBlockOffset = gameObject.WriteBinary(archive, propertiesBlockOffset);
            }

            foreach (GameObject gameObject in Objects) {
                gameObject.WriteProperties(archive, 0);
            }
        }

        public int CalculateSize() {
            int size = sizeof(int);
            NameSizeCalculator nameSizer = ArkArchive.GetNameSizer(false);

            size += Objects.Sum(o => o.Size(nameSizer));

            propertiesBlockOffset = size;
            size += Objects.Sum(o => o.PropertiesSize(nameSizer));
            return size;
        }

        public void ReadJson(JToken node, ReadingOptions options) {
            Objects.Clear();
            ObjectMap.Clear();
            if (node.Type == JTokenType.Array) {
                foreach (JToken jsonObject in node) {
                    addObject(new GameObject((JObject)jsonObject), options.BuildComponentTree);
                }
            } else {
                var objectsNode = node["objects"];
                if (objectsNode != null && objectsNode.Type != JTokenType.Null) {
                    foreach (JToken jsonObject in objectsNode) {
                        addObject(new GameObject((JObject)jsonObject), options.BuildComponentTree);
                    }
                }
            }
        }

        public void WriteJson(JsonTextWriter generator, WritingOptions writingOptions) {
            generator.WriteStartArray();

            foreach (GameObject gameObject in Objects) {
                gameObject.WriteJson(generator, writingOptions);
            }

            generator.WriteEndArray();
        }

        private MemoryStream toBuffer() {
            int size = sizeof(int);

            NameSizeCalculator nameSizer = ArkArchive.GetNameSizer(false);

            size += Objects.Sum(o => o.Size(nameSizer));

            int propertiesBlockOffset = size;

            size += Objects.Sum(o => o.PropertiesSize(nameSizer));

            MemoryStream buffer = new MemoryStream(new byte[size], true);
            ArkArchive archive = new ArkArchive(buffer);

            archive.WriteInt(Objects.Count);

            foreach (GameObject gameObject in Objects) {
                propertiesBlockOffset = gameObject.WriteBinary(archive, propertiesBlockOffset);
            }

            foreach (GameObject gameObject in Objects) {
                gameObject.WriteProperties(archive, 0);
            }

            return buffer;

        }

        public ArkArrayUInt8 ToByteArray() {
            MemoryStream buffer = toBuffer();

            ArkArrayUInt8 result = new ArkArrayUInt8();

            buffer.Position = 0;

            result.AddRange(buffer.ToArray());

            return result;
        }

        public ArkArrayInt8 ToSignedByteArray() {
            MemoryStream buffer = toBuffer();

            ArkArrayInt8 result = new ArkArrayInt8();

            buffer.Position = 0;

            result.AddRange(buffer.ToArray());

            return result;
        }

    }

}
