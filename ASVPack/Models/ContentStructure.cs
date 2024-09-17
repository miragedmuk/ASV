using AsaSavegameToolkit;
using AsaSavegameToolkit.Propertys;
using AsaSavegameToolkit.Types;
using ASVPack.Extensions;
using SavegameToolkit;
using SavegameToolkit.Structs;
using SavegameToolkit.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace ASVPack.Models
{
    [DataContract]
    public class ContentStructure
    {
        [DataMember] public string ClassName { get; set; } = "";
        [DataMember] public float? Latitude { get; set; } = 0;
        [DataMember] public float? Longitude { get; set; } = 0;
        [DataMember] public string DisplayName { get; set; } = "";
        [DataMember] public bool? IsLocked { get; set; } = null;
        [DataMember] public bool? IsSwitchedOn { get; set; } = null;

        [DataMember] public float X { get; set; } = 0;
        [DataMember] public float Y { get; set; } = 0;
        [DataMember] public float Z { get; set; } = 0;
        [DataMember] public ContentInventory Inventory { get; set; } = new ContentInventory();
        [DataMember] public long TargetingTeam { get; set; } = 0;

        [DataMember] public double CreatedTimeInGame { get; set; } = 0;
        [DataMember] public DateTime? CreatedDateTime { get; internal set; }

        [DataMember] public bool HasDecayTimeReset { get; set; } = false;
        [DataMember] public double LastAllyInRangeTimeInGame { get; set; } = 0;
        [DataMember] public DateTime? LastAllyInRangeTime { get; internal set; }
        [DataMember] public int UniquePaintingId { get; set; } = 0;

        [DataMember] public List<string>? Inclusions { get; set; } = null;
        [DataMember] public List<string>? Exclusions{ get; set; } = null;

        public ContentStructure(GameObject structureObject)
        {
            ClassName = structureObject.ClassString;
            DisplayName = structureObject.GetPropertyValue<string>("BoxName")??ClassName;



            if(structureObject.GetPropertyValue<ObjectReference>("MyInventoryComponent") != null)
            {
                IsLocked = structureObject.GetPropertyValue<bool>("bIsPinLocked")
                    || structureObject.GetPropertyValue<bool>("bIsLocked");
            }

            if ((structureObject.GetPropertyValue<bool>("bIsPowered", 0, false) || structureObject.GetPropertyValue<bool>("bHasFuel", 0, false)))
            {
                IsSwitchedOn = structureObject.GetPropertyValue<bool>("bContainerActivated", 0, false);
            }
             
            if (structureObject.Location != null)
            {
                X = structureObject.Location.X;
                Y = structureObject.Location.Y;
                Z = structureObject.Location.Z;
            }
            
            HasDecayTimeReset = structureObject.GetPropertyValue<bool>("bHasResetDecayTime", 0, false);
            LastAllyInRangeTimeInGame = structureObject.GetPropertyValue<double>("LastInAllyRangeTime", 0, 0);
            TargetingTeam = structureObject.GetPropertyValue<int>("TargetingTeam", 0, 0);
            CreatedTimeInGame = structureObject.GetPropertyValue<double>("OriginalCreationTime", 0, 0);

        }

        public ContentStructure()
        {

        }

        public ContentStructure(AsaGameObject structureObject)
        {
            ClassName = structureObject.ClassString;
            DisplayName = structureObject.GetPropertyValue<string>("BoxName") ?? ClassName;


            if (structureObject.GetPropertyValue<AsaObjectReference>("MyInventoryComponent") != null)
            {
                IsLocked = structureObject.GetPropertyValue<bool>("bIsPinLocked",0,false)
                    || structureObject.GetPropertyValue<bool>("bIsLocked",0,false);
            }

            if ((structureObject.GetPropertyValue<bool>("bIsPowered", 0, false) || structureObject.GetPropertyValue<bool>("bHasFuel", 0, false)))
            {
                IsSwitchedOn = structureObject.GetPropertyValue<bool>("bContainerActivated", 0, false);
            }

            if (structureObject.HasAnyProperty("StoredTraits"))
            {




            }

            if (structureObject.HasAnyProperty("DinoFeedingListType"))
            {
                Inclusions = new List<string>();
                Exclusions = new List<string>();

                int listType = structureObject.GetPropertyValue<int>("DinoFeedingListType", 0, 0);
                List<dynamic>? feedingList = structureObject.GetPropertyValue<dynamic>("FeedingDinoList", 0, null);

                switch (listType)
                {
                    case 1:
                        //inclusion
                        if(feedingList!=null && feedingList.Count > 0)
                        {
                            foreach(AsaObjectReference includedRef in feedingList)
                            {
                                Inclusions.Add(includedRef.Value);
                            }
                        }
                        break;
                    case 2:
                        //exclusion
                        if (feedingList != null && feedingList.Count > 0)
                        {
                            foreach (AsaObjectReference includedRef in feedingList)
                            {
                                Exclusions.Add(includedRef.Value);
                            }
                        }

                        break;
                }
                

            }

            if (structureObject.Location != null)
            {
                X = (float)structureObject.Location.X;
                Y = (float)structureObject.Location.Y;
                Z = (float)structureObject.Location.Z;
            }

            HasDecayTimeReset = structureObject.GetPropertyValue<bool>("bHasResetDecayTime", 0, false);
            LastAllyInRangeTimeInGame = structureObject.GetPropertyValue<double>("LastInAllyRangeTimeSerialized", 0, 0);
            TargetingTeam = structureObject.GetPropertyValue<int>("TargetingTeam", 0, 0);
            CreatedTimeInGame = structureObject.GetPropertyValue<double>("OriginalCreationTime", 0, 0);
        }
    }
}
