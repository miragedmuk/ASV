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

        public int CalculateSize() {
            int size = sizeof(int);
            NameSizeCalculator nameSizer = ArkArchive.GetNameSizer(false);

            size += Objects.Sum(o => o.Size(nameSizer));

            propertiesBlockOffset = size;
            size += Objects.Sum(o => o.PropertiesSize(nameSizer));
            return size;
        }


    }

}
