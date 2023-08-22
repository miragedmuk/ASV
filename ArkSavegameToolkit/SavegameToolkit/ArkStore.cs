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
    public class ArkStore : GameObjectContainerMixin
    {
        public string ClassName { get; internal set; } = string.Empty;
        public string Summary { get;internal set; } = string.Empty;
        public string Gender { get; internal set; } = string.Empty;
        public int[] Colors { get; internal set; } = new int[5];
        public Dictionary<string,string> Stats { get; internal set; } = new Dictionary<string, string>();
        public GameObject? CreatureComponent { get; internal set; } = null;
        public GameObject? StatusComponent { get; internal set; } = null;
        public GameObject? InventoryComponent { get; internal set; } = null;

        private long propertiesOffset = 0;

        public ArkStore(ArkArchive archive) 
        {
            ReadBinary(archive);
        }

        public void ReadBinary(ArkArchive archive)
        {
            var objectType = archive.ReadString(); //type?
            if (objectType.Equals("dino", StringComparison.InvariantCultureIgnoreCase))
            {
                var unknown1 = archive.ReadInt(); //unknown
                var className = archive.ReadString(); //class name instance
                var nameAndLevel = archive.ReadString(); //name and level
                var colorCodeCsv = archive.ReadString(); //csv list of color #
                var unknown2 = archive.ReadInt();//?
                var gender = archive.ReadString(); //gender

                archive.SkipBytes(14);//?

                var hp = archive.ReadFloat();
                var stamina = archive.ReadFloat();
                var weight = archive.ReadFloat();
                var oxy = archive.ReadFloat();
                var food = archive.ReadFloat();
                var speed = archive.ReadFloat();
                var imprint = archive.ReadFloat();
                var torpor = archive.ReadFloat();


                archive.SkipBytes(16); //unknown, need to identify

                var hpMax = archive.ReadFloat();
                var staminaMax = archive.ReadFloat();
                var weightMax = archive.ReadFloat();
                var oxyMax = archive.ReadFloat();
                var foodMax = archive.ReadFloat();
                var speedMax = archive.ReadFloat();
                var imprintMax = archive.ReadFloat();
                var torporMax = archive.ReadFloat();

                archive.SkipBytes(20);//?

                var colorCount = archive.ReadInt(); //color name count
                List<string> colorNames = new List<string>();
                while (colorCount-- > 0)
                {
                    var colorName = archive.ReadString();
                    colorNames.Add(colorName);
                }


                //set properties
                ClassName = className.Substring(0, className.LastIndexOf("_"));
                Summary = nameAndLevel;
                Gender = gender;

                string[] colorSplit = colorCodeCsv.Split(',').Where(e=>e.Length > 0).ToArray();
                Colors = new int[colorSplit.Length];
                for (int i = 0; i< colorSplit.Length; i++)
                {
                    int.TryParse(colorSplit[i], out int colorSplitInt);
                    Colors[i] = colorSplitInt;
                }

                Stats.Clear();
                Stats.Add("Health", string.Concat(hp, " / ", hpMax));
                Stats.Add("Stamina", string.Concat(stamina, " / ", staminaMax));
                Stats.Add("Weight", string.Concat(weight, " / ", weightMax));
                Stats.Add("Oxygen", string.Concat(oxy, " / ", oxyMax));
                Stats.Add("Food", string.Concat(food, " / ", foodMax));
                Stats.Add("Speed", string.Concat(speed, " / ", speedMax));
                Stats.Add("Imprint", string.Concat(imprint, " / ", imprintMax));
                Stats.Add("Torpor", string.Concat(torpor, " / ", torporMax));

            }


            archive.SkipBytes(8);//?

            propertiesOffset = archive.Position;



            //load GameObjects
            Objects.Clear();

            bool useNameTable = archive.UseNameTable;
            archive.UseNameTable = false;

            var objectCount = archive.ReadInt();
            while(objectCount-- > 0)
            {
                Objects.Add(new GameObject(archive));
            }

            if (Objects.Count > 0)
            {
                CreatureComponent = Objects[0];
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
