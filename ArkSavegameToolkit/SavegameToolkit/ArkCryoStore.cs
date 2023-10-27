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
            if (archive.ReadString().ToLowerInvariant() != "dino") return;

            var stringPropertyCount = archive.ReadInt(); //7
            if(stringPropertyCount < 0) 
                return;

            while(stringPropertyCount-- > 0)
            {
                archive.SkipString();
            }

            var floatPropertyCount = archive.ReadInt(); //float count (25)
            if (floatPropertyCount < 0) 
                return;

            while (floatPropertyCount-- > 0)
            {
                _ = archive.ReadFloat();
            }
            
            var colorCount = archive.ReadInt(); //color name count
            if (colorCount < 0) 
                return;

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

            StatusComponent = Objects.FirstOrDefault(o=>o.ClassString.Contains("DinoCharacterStatusComponent"));

            InventoryComponent = Objects.FirstOrDefault(o => o.ClassString.Contains("DinoTamedInventoryComponent") &! o.ClassString.Contains("Retrieval")); 

            archive.UseNameTable = useNameTable;


            

        }

        public void LoadProperties(ArkArchive archive)
        {
            bool useNameTable = archive.UseNameTable;
            archive.UseNameTable = false;

            var pos = archive.Position;

            if(CreatureComponent!=null)
            {
                CreatureComponent.LoadProperties(archive, new GameObject(), propertiesOffset);
            }

            if (StatusComponent != null)
            {
                StatusComponent.LoadProperties(archive, new GameObject(), propertiesOffset);
            }

            if (InventoryComponent!= null)
            {
                InventoryComponent.LoadProperties(archive, new GameObject(), propertiesOffset);
            }

            archive.Position = pos;
            
            archive.UseNameTable = useNameTable;
        }

    }
}
