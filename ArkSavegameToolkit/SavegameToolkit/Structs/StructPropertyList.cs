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
                try
                {
                    property = PropertyRegistry.ReadBinary(archive);
                }
                catch
                {
                    //unreadable property
                    property = null;
                }
                
            }
         }


        private List<IProperty> properties = new List<IProperty>();

        public List<IProperty> Properties {
            get => properties;
            set => properties = value.Where(property => property != null).ToList();
        }

        public bool IsNative => false;

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
