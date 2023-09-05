using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Propertys;

namespace SavegameToolkit {

    public sealed class ArkCloudInventory : GameObjectContainerMixin, IConversionSupport, IPropertyContainer {
        public int InventoryVersion { get; set; }

        public List<IProperty> Properties => inventoryData.Properties;

        private GameObject inventoryData;

        public GameObject InventoryData {
            get => inventoryData;
            set {
                if (inventoryData != null) {
                    int oldIndex = Objects.IndexOf(inventoryData);
                    if (oldIndex > -1) {
                        Objects.RemoveAt(oldIndex);
                    }
                }

                inventoryData = value;
                if (value != null && Objects.IndexOf(value) == -1) {
                    Objects.Insert(0, value);
                }
            }
        }

        private int propertiesBlockOffset;

        #region binary read/write

        public void ReadBinary(ArkArchive archive, ReadingOptions options) {
            InventoryVersion = archive.ReadInt();

            if (InventoryVersion < 1 || InventoryVersion > 4) {
                throw new NotSupportedException("Unknown Cloud Inventory Version " + InventoryVersion);
            }

            int objectCount = archive.ReadInt();

            Objects.Clear();
            ObjectMap.Clear();
            for (int i = 0; i < objectCount; i++) {
                addObject(new GameObject(archive), options.BuildComponentTree);
            }

            for (int i = 0; i < objectCount; i++) {
                GameObject obj = Objects[i];
                if (obj.ClassString == "ArkCloudInventoryData") {
                    inventoryData = obj;
                }

                obj.LoadProperties(archive, i < objectCount - 1 ? Objects[i + 1] : null, 0);
            }
        }


        public int CalculateSize() {
            int size = sizeof(int) * 2;

            NameSizeCalculator nameSizer = ArkArchive.GetNameSizer(false);

            size += Objects.Sum(o => o.Size(nameSizer));

            propertiesBlockOffset = size;

            size += Objects.Sum(o => o.PropertiesSize(nameSizer));
            return size;
        }

        #endregion

    }

}
