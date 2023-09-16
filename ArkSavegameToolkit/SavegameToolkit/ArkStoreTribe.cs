using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SavegameToolkit.Propertys;

namespace SavegameToolkit
{

    public class ArkStoreTribe : GameObjectContainerMixin, IConversionSupport, IPropertyContainer
    {

        public int TribeVersion { get; set; }

        public GameObject Tribe { get; set; }

        public List<IProperty> Properties => Tribe.Properties;

        private long propertiesBlockOffset;

        public void ReadBinary(ArkArchive archive, ReadingOptions options)
        {
            
            propertiesBlockOffset = archive.Position;
            var useNameTable = archive.UseNameTable;
            archive.UseNameTable = false;

            TribeVersion = archive.ReadInt();

            if (TribeVersion != 1)
            {
                throw new NotSupportedException("Unknown Tribe Version " + TribeVersion);
            }

            int tribesCount = archive.ReadInt();

            Objects.Clear();
            ObjectMap.Clear();
            for (int i = 0; i < tribesCount; i++)
            {
                var newObject = new GameObject(archive);

                addObject(newObject,false);
            }

            for (int i = 0; i < tribesCount; i++)
            {
                GameObject gameObject = Objects[i];
                if (gameObject.ClassString == "PrimalTribeData")
                {
                    Tribe = gameObject;
                }

                gameObject.LoadProperties(archive, new GameObject(), propertiesBlockOffset);
            }

            archive.UseNameTable = useNameTable;
        }


    }

}
