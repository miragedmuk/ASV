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
                var stringPropertyCount = archive.ReadInt(); //7
                var className = archive.ReadString(); //class name instance
                var nameAndLevel = archive.ReadString(); //name and level
                var colorCodeCsv = archive.ReadString(); //csv list of color #
                var neutered = archive.ReadString(); //NEUTERED or <empty>
                var gender = archive.ReadString(); //gender
                var storeUnknown1 = archive.ReadString(); 
                var storeUnknown2 = archive.ReadString(); 

                var floatPropertyCount = archive.ReadInt(); //float count (25)
                var hp = archive.ReadFloat(); //1
                var stamina = archive.ReadFloat(); //2
                var weight = archive.ReadFloat(); //3
                var oxy = archive.ReadFloat(); //4
                var food = archive.ReadFloat(); //5
                var speed = archive.ReadFloat(); //6
                var imprint = archive.ReadFloat(); //7
                var torpor = archive.ReadFloat(); //8

                var melee = 1 + archive.ReadFloat(); //9
                var storeUnknown3 = archive.ReadFloat(); //10
                var storeUnknown4 = archive.ReadFloat(); //11
                var storeUnknown5 = archive.ReadFloat(); //12

                var hpMax = archive.ReadFloat();//13
                var staminaMax = archive.ReadFloat(); //14
                var weightMax = archive.ReadFloat(); //15
                var oxyMax = archive.ReadFloat(); //16
                var foodMax = archive.ReadFloat(); //17
                var speedMax = archive.ReadFloat(); //18
                var imprintMax = archive.ReadFloat(); //19
                var torporMax = archive.ReadFloat(); //20
                var meleeMax = 1 + archive.ReadFloat(); //21

                var storeUnknown6 = archive.ReadFloat(); //22
                var storeUnknown7 = archive.ReadFloat(); //23
                var storeUnknown8 = archive.ReadFloat(); //24
                var storeUnknown9 = archive.ReadFloat(); //25

                
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
                Stats.Add("Speed", string.Concat(speed, "%"));
                Stats.Add("Imprint", string.Concat((imprint * 100).ToString("f1"), "%"));
                Stats.Add("Torpor", string.Concat(torpor, " / ", torporMax));
                Stats.Add("Melee", string.Concat((melee * 100).ToString("f1"), "%"));

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
