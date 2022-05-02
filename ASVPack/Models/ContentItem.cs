using SavegameToolkit;
using SavegameToolkit.Propertys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ASVPack.Models
{
    [DataContract]
    public class ContentItem
    {
        [DataMember] public string ClassName { get; set; } = "";
        [DataMember] public string CustomName { get; set; } = "";
        [DataMember] public string CraftedByPlayer { get; set; } = "";
        [DataMember] public string CraftedByTribe { get; set; } = "";
        [DataMember] public int Quantity { get; set; } = 1;
        [DataMember] public bool IsBlueprint { get; set; } = false;
        [DataMember] public bool IsEngram { get; set; } = false;
        [DataMember] public float? Rating { get; set; } = null;

        public ContentItem(GameObject itemObject)
        {
            ClassName = itemObject.ClassString;
            CustomName = itemObject.GetPropertyValue<string>("CustomName");
            IsBlueprint = itemObject.GetPropertyValue<bool>("bIsBlueprint");
            IsEngram = itemObject.GetPropertyValue<bool>("bIsEngram");
            Quantity = itemObject.GetPropertyValue<int>("ItemQuantity", 0, 1);
            CraftedByTribe = itemObject.GetPropertyValue<string>("CrafterTribeName");
            CraftedByPlayer = itemObject.GetPropertyValue<string>("CrafterCharacterName");


            if (itemObject.HasAnyProperty("ItemRating") & !ClassName.ToLower().Contains("egg"))
            {
                var ratingProp = itemObject.GetTypedProperty<PropertyFloat>("ItemRating")?.Value;
                if (!float.IsNaN(ratingProp.Value))
                {
                    Rating = ratingProp.Value;
                }
                else
                {
                    Rating = 0.0001f;
                }

            }

        }

        public ContentItem()
        {

        }

    }
}
