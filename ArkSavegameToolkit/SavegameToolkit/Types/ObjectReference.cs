using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SavegameToolkit.Types {

    public class ObjectReference : INameContainer {
        public const int TypeId = 0;
        public const int TypePath = 1;
        // Temporary, to support path references in save files
        public const int TypePathNoType = 2;

        public int Length { get; set; }

        public int ObjectId { get; set; }

        public ArkName ObjectString { get; set; }

        public int ObjectType { get; set; }

        public bool IsId => ObjectType == TypeId;

        public bool IsPath => ObjectType != TypeId;

        public ObjectReference() { }

        public ObjectReference(int length, int objectId) {
            Length = length;
            ObjectId = objectId;
            ObjectType = TypeId;
        }

        public ObjectReference(ArkName objectString) {
            ObjectString = objectString;
            ObjectType = TypePath;
        }

        public ObjectReference(ArkArchive archive, int length) {
            Length = length;
            readBinary(archive);
        }

        public ObjectReference(JToken node, int length) {
            Length = length;
            readJson(node);
        }

        public override string ToString() {
            return $"ObjectReference [ObjectType={ObjectType}, ObjectId={ObjectId}, ObjectString={ObjectString}, Length={Length}]";
        }

        public GameObject GetObject(GameObjectContainer objectContainer) {
            if (ObjectType == TypeId && ObjectId > -1 && ObjectId < objectContainer.Objects.Count) {
                return objectContainer.Objects[ObjectId];
            }

            return null;
        }

        private void readJson(JToken node) {
            switch (node.Type) {
                case JTokenType.Integer:
                    ObjectId = node.Value<int>();
                    ObjectType = TypeId;
                    break;
                case JTokenType.String:
                    ObjectString = ArkName.From(node.Value<string>());
                    ObjectType = TypePath;
                    break;
                default:
                    ObjectString = ArkName.From(node.Value<string>("value"));
                    ObjectType = node.Value<bool>("short") ? TypePathNoType : TypePath;
                    break;
            }
        }

        public void WriteJson(JsonTextWriter writer, WritingOptions writingOptions) {
            switch (ObjectType) {
                case TypeId:
                    writer.WriteValue(ObjectId);
                    break;
                case TypePath:
                    writer.WriteValue(ObjectString.ToString());
                    break;
                case TypePathNoType:
                    writer.WriteStartObject();
                    writer.WriteField("value", ObjectString.ToString());
                    writer.WriteField("short", true);
                    writer.WriteEndObject();
                    break;
            }
        }

        public int Size(NameSizeCalculator nameSizer) {
            switch (ObjectType) {
                case TypeId:
                    return Length;
                case TypePath:
                    return sizeof(int) + nameSizer(ObjectString);
                case TypePathNoType:
                    return nameSizer(ObjectString);
                default:
                    return Length;
            }
        }

        private void readBinary(ArkArchive archive) {
            if (Length >= 8) {
                ObjectType = archive.ReadInt();
                switch (ObjectType) {
                    case TypeId:
                        ObjectId = archive.ReadInt();
                        break;
                    case TypePath:
                        ObjectString = archive.ReadName();
                        break;
                    default:
                        archive.Position = archive.Position - 4;
                        ObjectType = TypePathNoType;
                        ObjectString = archive.ReadName();
                        break;
                }
            } else if (Length == 4) {
                // Only seems to happen in Version 5
                ObjectType = TypeId;
                ObjectId = archive.ReadInt();
            } else {
                Debug.WriteLine($"Warning: ObjectReference with length value {Length} at {archive.Position:X}");
                archive.Position = archive.Position + Length;
            }
        }

        public void WriteBinary(ArkArchive archive) {
            if (ObjectType == TypePath || Length >= 8 && ObjectType != TypePathNoType) {
                archive.WriteInt(ObjectType);
            }

            switch (ObjectType) {
                case TypeId:
                    archive.WriteInt(ObjectId);
                    break;
                case TypePath:
                case TypePathNoType:
                    archive.WriteName(ObjectString);
                    break;
            }
        }

        public void CollectNames(NameCollector collector) {
            if (ObjectType == TypePath) {
                collector(ObjectString);
            }
        }

    }

}
