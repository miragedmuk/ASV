using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using SavegameToolkit.Propertys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SavegameToolkit.Arrays;
using System.Runtime.InteropServices.ObjectiveC;
using SavegameToolkit.Types;

namespace SavegameToolkit
{
    public class ArkCryoStore : GameObjectContainerMixin
    {
        public GameObject? CreatureComponent { get; internal set; } = null;
        public GameObject? StatusComponent { get; internal set; } = null;
        public GameObject? InventoryComponent { get; internal set; } = null;

        private long propertiesOffset = 0;

        public ArkCryoStore(ArkArchive archive) 
        {
            ReadBinary(archive);
        }

        public void ReadBinary(ArkArchive archive)
        {
            var objectType = archive.ReadString().ToLowerInvariant(); //type?
            if (objectType != "dino" && objectType != "settings") return;

            var stringPropertyCount = archive.ReadInt(); //7
            while(stringPropertyCount-- > 0)
            {
                archive.SkipString();
            }

            var floatPropertyCount = archive.ReadInt(); //float count (25)
            while(floatPropertyCount-- > 0)
            {
                _ = archive.ReadFloat();
            }
            
            var colorCount = archive.ReadInt(); //color name count
            
            while (colorCount-- > 0)
            {
                archive.SkipString();
            }

            var u0 = archive.ReadLong();
            //var u1 = archive.ReadInt();
            //archive.SkipBytes(8);//?

            propertiesOffset = archive.Position;



            //load GameObjects
            Objects.Clear();

            bool useNameTable = archive.UseNameTable;
            archive.UseNameTable = false;

            var objectCount = archive.ReadInt();
            while (objectCount-- > 0)
            {
                Objects.Add(new GameObject(archive));
            }

            if (Objects.Count > 0)
            {
                CreatureComponent = Objects[0];
                CreatureComponent.IsInCryo = !CreatureComponent.ClassString.Contains("vivarium", StringComparison.InvariantCultureIgnoreCase);
                CreatureComponent.IsInVivarium = CreatureComponent.ClassString.Contains("vivarium", StringComparison.InvariantCultureIgnoreCase);
            }

            if (Objects.Count > 1)
            {
                StatusComponent = Objects[1];
            }

            if (Objects.Count > 2)
            {
                InventoryComponent = Objects[2];
            }

            archive.UseNameTable = useNameTable;


            

        }

        public void LoadProperties(ArkArchive archive)
        {
            bool useNameTable = archive.UseNameTable;
            archive.UseNameTable = false;

            var pos = archive.Position;

            if(CreatureComponent!=null)
            {
                CreatureComponent.LoadProperties(archive, new GameObject(), (int)propertiesOffset);
            }

            if (StatusComponent != null)
            {
                StatusComponent.LoadProperties(archive, new GameObject(), (int)propertiesOffset);
            }

            if (InventoryComponent!= null)
            {
                InventoryComponent.LoadProperties(archive, new GameObject(), (int)propertiesOffset);
            }

            archive.Position = pos;
            
            archive.UseNameTable = useNameTable;
        }

    }
}
