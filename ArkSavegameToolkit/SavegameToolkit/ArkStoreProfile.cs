using SavegameToolkit.Propertys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavegameToolkit
{
    internal class ArkStoreProfile : GameObjectContainerMixin, IConversionSupport, IPropertyContainer
    {

        public int ProfileVersion { get; set; }

        public List<IProperty> Properties => profile.Properties;

        private GameObject profile;
        private long propertiesBlockOffset;

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

            propertiesBlockOffset = archive.Position;
            var useNameTable = archive.UseNameTable;
            archive.UseNameTable = false;
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

                    gameObject.LoadProperties(archive, new GameObject(), propertiesBlockOffset);
                }
            }
            catch
            {

            }
            archive.UseNameTable = useNameTable;
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
