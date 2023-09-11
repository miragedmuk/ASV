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

      
        public override string ToString() {
            return $"ObjectReference [ObjectType={ObjectType}, ObjectId={ObjectId}, ObjectString={ObjectString}, Length={Length}]";
        }

        public GameObject GetObject(GameObjectContainer objectContainer) {
            if (ObjectType == TypeId && ObjectId > -1 && ObjectId < objectContainer.Objects.Count) {
                return objectContainer.Objects[ObjectId];
            }

            return null;
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

        public void CollectNames(NameCollector collector) {
            if (ObjectType == TypePath) {
                collector(ObjectString);
            }
        }

    }

}
