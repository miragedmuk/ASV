using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Propertys;
using SavegameToolkit.Types;

namespace SavegameToolkit.Structs {

    public class StructPropertyList : IPropertyContainer, IStruct {

        public StructPropertyList() { }

        public StructPropertyList(List<IProperty> properties) {
            Properties = properties;
        }

        public StructPropertyList(ArkArchive archive) {
            Init(archive);
        }

        public void Init(ArkArchive archive) {
            IProperty property = PropertyRegistry.ReadBinary(archive);

            while (property != null) {
                Properties.Add(property);
                property = PropertyRegistry.ReadBinary(archive);
            }
        }

        public StructPropertyList(JArray node) {
            Init(node);
        }

        public void Init(JObject node) {
            throw new NotImplementedException();
        }

        public void Init(JArray node) {
            Properties = node.Select(n => PropertyRegistry.ReadJson((JObject)n)).ToList();
        }

        private List<IProperty> properties = new List<IProperty>();

        public List<IProperty> Properties {
            get => properties;
            set => properties = value.Where(property => property != null).ToList();
        }

        public bool IsNative => false;

        public void WriteJson(JsonTextWriter generator, WritingOptions writingOptions) {
            if (writingOptions.Compact) {
                generator.WriteStartObject();
            } else {
                generator.WriteStartArray();
            }

            foreach (IProperty property in Properties) {
                property.WriteJson(generator, writingOptions);
            }

            if (writingOptions.Compact) {
                generator.WriteEndObject();
            } else {
                generator.WriteEndArray();
            }
        }

        public void WriteBinary(ArkArchive archive) {
            Properties.ForEach(p => p.WriteBinary(archive));

            archive.WriteName(ArkName.NameNone);
        }

        public int Size(NameSizeCalculator nameSizer) {
            int size = nameSizer(ArkName.NameNone);

            size += Properties.Sum(p => p.CalculateSize(nameSizer));

            return size;
        }

        public void CollectNames(NameCollector collector) {
            Properties.ForEach(p => p.CollectNames(collector));
            collector(ArkName.NameNone);
        }

    }

}
