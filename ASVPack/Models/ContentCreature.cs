using AsaSavegameToolkit;
using ASVPack.Extensions;
using SavegameToolkit;
using SavegameToolkit.Arrays;
using SavegameToolkit.Propertys;
using SavegameToolkit.Structs;
using SavegameToolkit.Types;
using SavegameToolkitAdditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
namespace ASVPack.Models
{
    [DataContract]
    public abstract class ContentCreature
    {
        [DataMember] public int BaseLevel { get; set; } = 0;
        [DataMember] public byte[] BaseStats { get; set; }
        [DataMember] public string ClassName { get; set; }
        [DataMember] public byte[] Colors { get; set; }
        [DataMember] public string Gender { get; set; } = "Male";
        [DataMember] public long Id { get; set; }
        [DataMember] public string DinoId { get; set; } = "";
        [DataMember] public bool IsBaby { get; set; } = false;
        [DataMember] public bool IsNeutered { get; set; } = false;
        [DataMember] public float? Latitude { get; set; }
        [DataMember] public float? Longitude { get; set; }
        [DataMember] public string[] ProductionResources { get; set; }
        [DataMember] public float? X { get; set; }
        [DataMember] public float? Y { get; set; }
        [DataMember] public float? Z { get; set; }
        [DataMember] public float WildScale { get; set; } = 1;
        [DataMember] public string Rig1 { get; set; } = "";
        [DataMember] public string Rig2 { get; set; } = "";
        [DataMember] public float Maturation { get; set; } = 100;
        [DataMember] public List<string> Traits { get; set; } = new List<string>();

        public override bool Equals(object? obj)
        {
            if (obj is ContentCreature) return ((ContentCreature)obj).Id == Id;
            return false;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }




        public ContentCreature()
        {
            ClassName = string.Empty;
            BaseStats = new byte[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Colors = new byte[6] { 0, 0, 0, 0, 0, 0 };
            ProductionResources = new string[0]; 




        }

        public ContentCreature(AsaGameObject creatureObject, AsaGameObject statusObject)
        {


            ProductionResources = new string[0];

            //populate asv objects
            Id = creatureObject.GetDinoId();


            if (statusObject == null)
            {
                BaseLevel = 1;
            }
            else
            {
                BaseLevel = statusObject.GetPropertyValue<int>("BaseCharacterLevel", defaultValue: 1);
            }

            ClassName = creatureObject.ClassString;

            WildScale = creatureObject.GetPropertyValue<float>("WildRandomScale", 0, 1);


            Gender = creatureObject.IsFemale() ? "Female" : "Male";
            if (ClassName.ToLower().Contains("queen")) Gender = "Female";


            IsNeutered = creatureObject.GetPropertyValue<bool>("bNeutered", 0, false);
            IsBaby = creatureObject.GetPropertyValue<bool>("bIsBaby", 0, false);
            if (IsBaby)
            {
                Maturation = creatureObject.GetPropertyValue<float>("BabyAge", 0, 0) * 100;
            }

            BaseStats = new byte[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            if (statusObject != null)
            {
                for (var i = 0; i < BaseStats.Length; i++)
                {
                    var pointsApplied = (byte)(statusObject.GetPropertyValue<uint>("NumberOfLevelUpPointsApplied", i) ?? 0);

                    BaseStats[i] = (byte)(pointsApplied);
                }
            }

            Colors = new byte[6] { 0, 0, 0, 0, 0, 0 };
            for (var i = 0; i < Colors.Length; i++) Colors[i] = (byte)creatureObject.GetPropertyValue<int>("ColorSetIndices", i,0);

            //resource production

            List<string> productionItems = new List<string>();

            /*           
            var productionSlots = creatureObject.GetPropertyValue<dynamic>("ResourceProduction");
            if (productionSlots != null)
            {
                var itemQuantityStruct = (ArkArrayStruct)productionSlots.Value;
                if (itemQuantityStruct != null)
                {
                    foreach (StructPropertyList itemQuantity in itemQuantityStruct)
                    {
                        if (itemQuantity.Properties.Count > 0)
                        {
                            PropertyObject itemRef = (PropertyObject)itemQuantity.Properties[0];
                            if (itemRef != null && itemRef.Value?.ObjectId >= 0)
                            {
                                string classString = itemRef.Value.ObjectString.Name.ToString();
                                if (classString.Contains("."))
                                {
                                    classString = classString.Substring(classString.LastIndexOf(".") + 1);
                                    productionItems.Add(classString);
                                }
                            }


                        }

                    }
                }

            }
            */

            //known producers but with no ResourceProduction data in save
            switch (ClassName)
            {

                case "Achatina_Character_BP_C":
                case "Achatina_Character_BP_Aberrant":
                    //achatina paste, organic polymer
                    productionItems.Add("PrimalItemResource_SnailPaste_C");
                    productionItems.Add("PrimalItemResource_Polymer_Organic_C");

                    break;
                case "Toad_Character_BP_Aberrant_C":
                case "Toad_Character_BP_Aberrant":
                    //cement paste
                    productionItems.Add("PrimalItemResource_ChitinPaste_C");

                    break;
                case "DungBeetle_Character_BP_C":
                case "DungBeetle_Character_BP_Aberrant_C":
                    //oil/fertilizer
                    productionItems.Add("PrimalItemResource_Oil_C");
                    productionItems.Add("PrimalItemConsumable_Fertilizer_Compost_C");

                    break;

                case "Hesperornis_Character_BP_C":
                    productionItems.Add("PrimalItemResource_Oil_C");

                    break;
                case "Tusoteuthis_Character_BP_C":
                case "Basilosaurus_Character_BP_C":
                case "Ocean_Basilosaurus_Character_BP_C":
                    //oil
                    productionItems.Add("PrimalItemResource_SquidOil");

                    break;
                case "GiantTurtle_Character_BP_C":
                    //rare flower, rare mushroom
                    productionItems.Add("PrimalItemResource_RareFlower_C");
                    productionItems.Add("PrimalItemResource_RareMushroom_C");


                    break;
                case "Shapeshifter_Small_Character_BP_C":
                case "Shapeshifter_Large_Character_BP_C":
                    //element dust
                    productionItems.Add("PrimalItemResource_ElementDust_C");

                    break;
                case "TekStrider_Character_BP_C":
                    //tek stryder rigs
                    //var inventComp = creatureObject.InventoryComponent();

                    //EquippedItems



                    break;
            }
            if (productionItems.Count > 0) ProductionResources = productionItems.ToArray();





            //location
            if (creatureObject.Location != null)
            {
                X = (float)creatureObject.Location.X;
                Y = (float)creatureObject.Location.Y;
                Z = (float)creatureObject.Location.Z;

            }

            DinoId = Id.ToString();


        }

        public ContentCreature(GameObject creatureObject, GameObject statusObject)
        {

            ProductionResources = new string[0];

            //populate asv objects
            Id = creatureObject.GetDinoId();


            if (statusObject == null)
            {
                BaseLevel = 1;
            }
            else
            {
                BaseLevel = statusObject.GetPropertyValue<int>("BaseCharacterLevel", defaultValue: 1);
            }

            ClassName = creatureObject.ClassString;

            WildScale = creatureObject.GetPropertyValue<float>("WildRandomScale", 0, 1);


            Gender = creatureObject.IsFemale() ? "Female" : "Male";
            if (ClassName.ToLower().Contains("queen")) Gender = "Female";


            IsNeutered = creatureObject.GetPropertyValue<bool>("bNeutered", 0, false);
            IsBaby = creatureObject.GetPropertyValue<bool>("bIsBaby", 0, false);
            if (IsBaby)
            {
                Maturation = creatureObject.GetPropertyValue<float>("BabyAge", 0, 0) * 100;
            }

            BaseStats = new byte[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            if(statusObject != null)
            {
                for (var i = 0; i < BaseStats.Length; i++) BaseStats[i] = statusObject.GetPropertyValue<ArkByteValue>("NumberOfLevelUpPointsApplied", i)?.ByteValue ?? 0;
            }

            Colors = new byte[6] { 0, 0, 0, 0, 0, 0 };
            for (var i = 0; i < Colors.Length; i++) Colors[i] = creatureObject.GetPropertyValue<ArkByteValue>("ColorSetIndices", i)?.ByteValue ?? 0;

            //resource production

            List<string> productionItems = new List<string>();
            PropertyArray productionSlots = creatureObject.GetTypedProperty<PropertyArray>("ResourceProduction");
            if (productionSlots != null)
            {
                var itemQuantityStruct = (ArkArrayStruct)productionSlots.Value;
                if (itemQuantityStruct != null)
                {
                    foreach (StructPropertyList itemQuantity in itemQuantityStruct)
                    {
                        if (itemQuantity.Properties.Count > 0)
                        {
                            PropertyObject itemRef = (PropertyObject)itemQuantity.Properties[0];
                            if (itemRef != null && itemRef.Value?.ObjectId >= 0)
                            {
                                string classString = itemRef.Value.ObjectString.Name.ToString();
                                if (classString.Contains("."))
                                {
                                    classString = classString.Substring(classString.LastIndexOf(".") + 1);
                                    productionItems.Add(classString);
                                }
                            }


                        }

                    }
                }

            }

            //known producers but with no ResourceProduction data in save
            switch (ClassName)
            {

                case "Achatina_Character_BP_C":
                case "Achatina_Character_BP_Aberrant":
                    //achatina paste, organic polymer
                    productionItems.Add("PrimalItemResource_SnailPaste_C");
                    productionItems.Add("PrimalItemResource_Polymer_Organic_C");

                    break;
                case "Toad_Character_BP_Aberrant_C":
                case "Toad_Character_BP_Aberrant":
                    //cement paste
                    productionItems.Add("PrimalItemResource_ChitinPaste_C");

                    break;
                case "DungBeetle_Character_BP_C":
                case "DungBeetle_Character_BP_Aberrant_C":
                    //oil/fertilizer
                    productionItems.Add("PrimalItemResource_Oil_C");
                    productionItems.Add("PrimalItemConsumable_Fertilizer_Compost_C");

                    break;

                case "Hesperornis_Character_BP_C":
                    productionItems.Add("PrimalItemResource_Oil_C");

                    break;
                case "Tusoteuthis_Character_BP_C":
                case "Basilosaurus_Character_BP_C":
                case "Ocean_Basilosaurus_Character_BP_C":
                    //oil
                    productionItems.Add("PrimalItemResource_SquidOil");

                    break;
                case "GiantTurtle_Character_BP_C":
                    //rare flower, rare mushroom
                    productionItems.Add("PrimalItemResource_RareFlower_C");
                    productionItems.Add("PrimalItemResource_RareMushroom_C");


                    break;
                case "Shapeshifter_Small_Character_BP_C":
                case "Shapeshifter_Large_Character_BP_C":
                    //element dust
                    productionItems.Add("PrimalItemResource_ElementDust_C");

                    break;
                case "TekStrider_Character_BP_C":
                    //tek stryder rigs
                    var inventComp = creatureObject.InventoryComponent();

                    //EquippedItems



                    break;
            }
            if (productionItems.Count > 0) ProductionResources = productionItems.ToArray();





            //location
            if (creatureObject.Location != null)
            {
                X = creatureObject.Location.X;
                Y = creatureObject.Location.Y;
                Z = creatureObject.Location.Z;

            }

            DinoId = creatureObject.GetPropertyValue<int>("DinoID1").ToString() + creatureObject.GetPropertyValue<int>("DinoID2").ToString();



        }

    }
}

