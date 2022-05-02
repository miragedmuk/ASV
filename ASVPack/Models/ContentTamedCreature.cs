using SavegameToolkit;
using SavegameToolkit.Arrays;
using SavegameToolkit.Propertys;
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
    public class ContentTamedCreature : ContentCreature
    {
        [DataMember] public long? FatherId { get; internal set; }
        [DataMember] public string FatherName { get; set; } = "";
        [DataMember] public bool IsClaimed { get; set; } = true;
        [DataMember] public bool IsCryo { get; set; } = false;
        [DataMember] public bool IsVivarium { get; set; } = false;
        [DataMember] public long ImprintedPlayerId { get; set; } = 0;
        [DataMember] public string ImprinterName { get; set; } = "";
        [DataMember] public decimal ImprintQuality { get; set; } = 0;
        [DataMember] public ContentInventory Inventory { get; set; } = new ContentInventory();
        [DataMember] public int Level { get; set; } = 0;
        [DataMember] public long? MotherId { get; set; }
        [DataMember] public string MotherName { get; set; } = "";
        [DataMember] public string Name { get; set; } = "";
        [DataMember] public int RandomMutationsFemale { get; set; } = 0;
        [DataMember] public int RandomMutationsMale { get; set; } = 0;
        [DataMember] public string TamedOnServerName { get; set; } = "";
        [DataMember] public byte[] TamedStats { get; set; }
        [DataMember] public long TargetingTeam { get; set; } = int.MinValue;
        [DataMember] public string TribeName { get; set; } = "";
        [DataMember] public string TamerName { get; set; } = "";
        [DataMember] public double TamedTimeInGame { get; set; } = 0;
        public DateTime? TamedAtDateTime { get; internal set; }

        [DataMember] public double LastAllyInRangeTimeInGame { get; set; } = 0;
        public DateTime? LastAllyInRangeTime { get; internal set; }

        [DataMember] public bool IsMating { get; set; } = false;
        [DataMember] public bool IsWandering { get; set; } = false;



        public ContentTamedCreature(GameObject creatureObject, GameObject statusObject) : base(creatureObject, statusObject)
        {
            TamedTimeInGame = creatureObject.GetPropertyValue<double>("TamedAtTime");

            IsWandering = creatureObject.GetPropertyValue<bool>("bEnableTamedWandering", 0, false);
            IsMating = creatureObject.GetPropertyValue<bool>("bEnableTamedMating", 0, false);


            int testTarget = creatureObject.GetPropertyValue<int>("TargetingTeam");
            int testTeam = creatureObject.GetPropertyValue<int>("TamingTeamID");


            TargetingTeam = testTarget;
            if (TargetingTeam == 2_000_000_000 && IsBaby)
            {
                //unclaimed baby, try determine parent targeting team instead

            }

            LastAllyInRangeTimeInGame = creatureObject.GetPropertyValue<double>("LastInAllyRangeTime", 0, 0);




            TribeName = creatureObject.GetPropertyValue<string>("TribeName");
            Name = creatureObject.GetPropertyValue<string>("TamedName");
            if (statusObject == null)
            {
                Level = 1;
            }
            else
            {
                int baseLevel = statusObject.GetPropertyValue<int>("BaseCharacterLevel", defaultValue: 1);
                short extraLevel = statusObject.GetPropertyValue<short>("ExtraCharacterLevel");
                Level = baseLevel + extraLevel;
            }


            TamedOnServerName = creatureObject.GetPropertyValue<string>("TamedOnServerName");
            TamerName = creatureObject.GetPropertyValue<string>("TamerString");

            ImprintedPlayerId = creatureObject.GetPropertyValue<long>("ImprinterPlayerDataID");
            if (ImprintedPlayerId > 0)
            {
                ImprintQuality = (decimal)statusObject.GetPropertyValue<float>("DinoImprintingQuality", 0, 0);
                ImprinterName = creatureObject.GetPropertyValue<string>("ImprinterName");
                TamerName = "";
            }


            IsCryo = creatureObject.IsCryo;
            IsVivarium = creatureObject.IsVivarium;



            if (IsCryo || IsVivarium)
            {
                //stored creatures don't have unique DinoId properties.  Negate to make them unique from non cryo tames.
                Id = -Id;
            }

            RandomMutationsFemale = creatureObject.GetPropertyValue<int>("RandomMutationsFemale");
            RandomMutationsMale = creatureObject.GetPropertyValue<int>("RandomMutationsMale");

            TamedStats = new byte[12];
            if (statusObject != null)
            {
                for (var i = 0; i < TamedStats.Length; i++) TamedStats[i] = statusObject.GetPropertyValue<ArkByteValue>("NumberOfLevelUpPointsAppliedTamed", i)?.ByteValue ?? 0;

            }




            //ancestors
            var parents = creatureObject.GetTypedProperty<PropertyArray>("DinoAncestors");
            if (parents != null)
            {
                ArkArrayStruct parentPropertyStruct = (ArkArrayStruct)parents.Value;
                if (parentPropertyStruct != null)
                {
                    StructPropertyList parentProperties = parentPropertyStruct.Cast<StructPropertyList>().FirstOrDefault();
                    if (parentProperties != null)
                    {
                        int maleId1 = parentProperties.GetPropertyValue<int>("MaleDinoID1");
                        int maleId2 = parentProperties.GetPropertyValue<int>("MaleDinoID2");

                        long fatherId = (long)maleId1 << 32 | (maleId2 & 0xFFFFFFFFL);
                        FatherId = fatherId;
                        FatherName = parentProperties.GetPropertyValue<string>("MaleName");

                        int femaleId1 = parentProperties.GetPropertyValue<int>("FemaleDinoID1");
                        int femaleId2 = parentProperties.GetPropertyValue<int>("FemaleDinoID2");

                        long motherId = (long)femaleId1 << 32 | (femaleId2 & 0xFFFFFFFFL);
                        MotherId = motherId;
                        MotherName = parentProperties.GetPropertyValue<string>("FemaleName");

                    }

                }

            }




        }

        public ContentTamedCreature() : base()
        {
        }
    }
}
