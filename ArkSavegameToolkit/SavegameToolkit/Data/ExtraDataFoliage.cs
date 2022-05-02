using System.Collections.Generic;
using Newtonsoft.Json;
using SavegameToolkit.Structs;

namespace SavegameToolkit.Data {

    public class ExtraDataFoliage : IExtraData, INameContainer {
        public const string NullPlaceholder = "/NULL_KEY";

        public List<Dictionary<string, StructPropertyList>> StructMapList { get; set; }

        public int CalculateSize(NameSizeCalculator nameSizer) {
            int size = sizeof(int) * 2;

            size += sizeof(int) * StructMapList.Count;
            foreach (Dictionary<string, StructPropertyList> structMap in StructMapList) {
                foreach (KeyValuePair<string, StructPropertyList> entry in structMap) {
                    size += ArkArchive.GetStringLength(entry.Key);
                    size += entry.Value.Size(nameSizer);
                    size += sizeof(int);
                }
            }

            return size;
        }

        public void WriteJson(JsonTextWriter writer, WritingOptions writingOptions) {
            if (writingOptions.Compact) {
                writer.WriteNull();
                return;
            }
            writer.WriteStartArray();

            foreach (Dictionary<string, StructPropertyList> structMap in StructMapList) {
                writer.WriteStartObject();
                foreach (KeyValuePair<string, StructPropertyList> entry in structMap) {
                    writer.WritePropertyName(entry.Key ?? NullPlaceholder);
                    entry.Value.WriteJson(writer, writingOptions);
                }

                writer.WriteEndObject();
            }

            writer.WriteEndArray();
        }

        public void WriteBinary(ArkArchive archive) {
            archive.WriteInt(0);
            archive.WriteInt(StructMapList.Count);

            foreach (Dictionary<string, StructPropertyList> structMap in StructMapList) {
                archive.WriteInt(structMap.Count);
                foreach (KeyValuePair<string, StructPropertyList> entry in structMap) {
                    archive.WriteString(entry.Key);
                    entry.Value.WriteBinary(archive);
                    archive.WriteInt(0);
                }
            }
        }

        public void CollectNames(NameCollector collector) {
            foreach (Dictionary<string, StructPropertyList> structMap in StructMapList) {
                foreach (KeyValuePair<string, StructPropertyList> entry in structMap) {
                    entry.Value.CollectNames(collector);
                }
            }
        }

    }

}
