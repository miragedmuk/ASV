using AsaSavegameToolkit;
using ASVPack.Extensions;
using SavegameToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace ASVPack.Models
{
    [DataContract]
    public class ContentDroppedItem
    {
        [DataMember] public string ClassName { get; set; }
        [DataMember] public bool IsBlueprint { get; set; }
        [DataMember] public bool IsEngram { get; set; }
        [DataMember] public bool IsDeathCache { get; set; }
        [DataMember] public string DroppedByName { get; set; }
        [DataMember] public long DroppedByPlayerId { get; set; }
        [DataMember] public int DroppedByTribeId { get; set; }
        [DataMember] public float? Latitude { get; set; }
        [DataMember] public float? Longitude { get; set; }
        [DataMember] public float? X { get; set; }
        [DataMember] public float? Y { get; set; }
        [DataMember] public float? Z { get; set; }
        [DataMember] public ContentInventory Inventory { get; set; } = new ContentInventory();
        [DataMember] public double CreatedTimeInGame { get; set; } = 0;
        [DataMember] public DateTime? CreatedDateTime { get; set; } = null;

        public ContentDroppedItem()
        {
            ClassName = string.Empty;
            DroppedByName= string.Empty;
            
        }

        public ContentDroppedItem(GameObject itemObject)
        {
            ClassName = string.Empty;

            if (itemObject.Location != null)
            {
                X = itemObject.Location?.X;
                Y = itemObject.Location?.Y;
                Z = itemObject.Location?.Z;
            }
            DroppedByName = itemObject.GetPropertyValue<string>("OwnerName") ?? itemObject.GetPropertyValue<string>("DroppedByName");
            DroppedByTribeId = itemObject.GetPropertyValue<int>("TargetingTeam", 0, 0);
            DroppedByPlayerId = itemObject.GetPropertyValue<long?>("LinkedPlayerDataID") ?? itemObject.GetPropertyValue<long>("DroppedByPlayerID", 0, 0);
            CreatedTimeInGame = itemObject.GetPropertyValue<double>("OriginalCreationTime", 0, 0);

        }

        public ContentDroppedItem(AsaGameObject itemObject)
        {
            ClassName = string.Empty;

            if (itemObject.Location != null)
            {
                X = (float)itemObject.Location?.X;
                Y = (float)itemObject.Location?.Y;
                Z = (float)itemObject.Location?.Z;
            }


            DroppedByName = itemObject.GetPropertyValue<string>("OwnerName", 0, "")??"";
            if (string.IsNullOrEmpty(DroppedByName))
            {
                DroppedByName = itemObject.GetPropertyValue<string>("DroppedByName", 0, "")??"<Unknown>";
            }

            DroppedByTribeId = itemObject.GetPropertyValue<int>("TargetingTeam", 0, 0);
            DroppedByPlayerId = (long)(itemObject.GetPropertyValue<ulong?>("LinkedPlayerDataID") ?? itemObject.GetPropertyValue<long>("DroppedByPlayerID", 0, 0));
            CreatedTimeInGame = itemObject.GetPropertyValue<double>("OriginalCreationTime", 0, 0);

        }
    }
}
