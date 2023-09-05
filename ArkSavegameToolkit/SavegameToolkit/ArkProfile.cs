using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Propertys;

namespace SavegameToolkit
{

    public class ArkProfile : GameObjectContainerMixin, IConversionSupport, IPropertyContainer
    {

        public int ProfileVersion { get; set; }

        public List<IProperty> Properties => profile.Properties;

        private GameObject profile;
        private int propertiesBlockOffset;

        public GameObject Profile
        {
            get => profile;
            set
            {
                if (profile != null)
                {
                    int oldIndex = Objects.IndexOf(profile);
                    if (oldIndex > -1)
                    {
                        Objects.RemoveAt(oldIndex);
                    }
                }

                profile = value;
                if (value != null && Objects.IndexOf(value) == -1)
                {
                    Objects.Insert(0, value);
                }
            }
        }

        public void ReadBinary(ArkArchive archive, ReadingOptions options)
        {
            try
            {
                ProfileVersion = archive.ReadInt();

                if (ProfileVersion != 1)
                {
                    //throw new NotSupportedException("Unknown Profile Version " + ProfileVersion);
                }

                int profilesCount = archive.ReadInt();

                Objects.Clear();
                ObjectMap.Clear();
                for (int i = 0; i < profilesCount; i++)
                {
                    addObject(new GameObject(archive), options.BuildComponentTree);
                }

                for (int i = 0; i < profilesCount; i++)
                {
                    GameObject gameObject = Objects[i];
                    if (gameObject.ClassString == "PrimalPlayerData" || gameObject.ClassString == "PrimalPlayerDataBP_C")
                    {
                        profile = gameObject;
                    }

                    gameObject.LoadProperties(archive, i < profilesCount - 1 ? Objects[i + 1] : null, 0);
                }
            }
            catch
            {

            }

            //var tekGrams = Objects.Where(o => o.ClassString.ToLower().Contains("canteen")).ToList();

        }


        public int CalculateSize()
        {
            int size = sizeof(int) * 2;

            NameSizeCalculator nameSizer = ArkArchive.GetNameSizer(false);

            size += Objects.Sum(o => o.Size(nameSizer));

            propertiesBlockOffset = size;

            size += Objects.Sum(o => o.PropertiesSize(nameSizer));
            return size;
        }

    }

}
