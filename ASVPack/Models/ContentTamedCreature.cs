using AsaSavegameToolkit;
using AsaSavegameToolkit.Propertys;
using ASVPack.Extensions;
using SavegameToolkit;
using SavegameToolkit.Arrays;
using SavegameToolkit.Propertys;
using SavegameToolkit.Structs;
using SavegameToolkit.Types;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        [DataMember] public bool IsEmbryo { get; set; } = false;
        [DataMember] public long ImprintedPlayerId { get; set; } = 0;
        public string ImprintedPlayerNetId { get; set; } = string.Empty;
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
        [DataMember] public string UploadedServerName { get; set; } = "";

        [DataMember] public byte[] TamedStats { get; set; }
        [DataMember] public byte[] TamedMutations { get; set; }

        [DataMember] public long TargetingTeam { get; set; } = int.MinValue;
        [DataMember] public string TribeName { get; set; } = "";
        [DataMember] public string TamerName { get; set; } = "";
        [DataMember] public double TamedTimeInGame { get; set; } = 0;
        public DateTime? TamedAtDateTime { get; internal set; }

        [DataMember] public double LastAllyInRangeTimeInGame { get; set; } = 0;
        public DateTime? LastAllyInRangeTime { get; internal set; }

        [DataMember] public bool IsMating { get; set; } = false;
        [DataMember] public bool IsWandering { get; set; } = false;
        [DataMember] public bool IsClone { get; set; } = false;
        [DataMember] public DateTime? UploadedTime { get; set; } = null;
        public double UploadedTimeInGame { get; set; } = 0;

        [DataMember] public float Experience { get; set; } = 0;

        public ContentTamedCreature(double uploadTime, GameObject creatureObject, GameObject statusObject): base(creatureObject,statusObject)
        {
            UploadedTime = null;
            UploadedTimeInGame = uploadTime;


            TamedTimeInGame = creatureObject.GetPropertyValue<double>("TamedAtTime", 0, 0);

            IsWandering = creatureObject.GetPropertyValue<bool>("bEnableTamedWandering", 0, false);
            IsMating = creatureObject.GetPropertyValue<bool>("bEnableTamedMating", 0, false);
            IsClone = creatureObject.GetPropertyValue<bool>("bIsClone", 0, false);

            int testTarget = creatureObject.GetPropertyValue<int>("TargetingTeam", 0, 0);
            int testTeam = creatureObject.GetPropertyValue<int>("TamingTeamID", 0, 0);


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

            ImprintedPlayerId = (long)creatureObject.GetPropertyValue<long>("ImprinterPlayerDataID", 0, 0);
            if (ImprintedPlayerId > 0 && statusObject!=null)
            {
                ImprintQuality = (decimal)statusObject.GetPropertyValue<float>("DinoImprintingQuality", 0, 0);
                ImprinterName = creatureObject.GetPropertyValue<string>("ImprinterName");
                TamerName = "";
            }


            IsCryo = creatureObject.IsInCryo;
            IsVivarium = creatureObject.IsInVivarium;



            if (IsCryo || IsVivarium)
            {
                //stored creatures don't have unique DinoId properties.  Negate to make them unique from non cryo tames.
                Id = -Id;
            }

            RandomMutationsFemale = creatureObject.GetPropertyValue<int>("RandomMutationsFemale", 0, 0);
            RandomMutationsMale = creatureObject.GetPropertyValue<int>("RandomMutationsMale", 0, 0);

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
                    StructPropertyList? parentProperties = parentPropertyStruct.Cast<StructPropertyList>().FirstOrDefault();
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

        public ContentTamedCreature(GameObject creatureObject, GameObject statusObject) : base(creatureObject, statusObject)
        {
            TamedTimeInGame = creatureObject.GetPropertyValue<double>("TamedAtTime", 0, 0);
            UploadedTime = null;
            UploadedTimeInGame = 0;

            IsWandering = creatureObject.GetPropertyValue<bool>("bEnableTamedWandering", 0, false);
            IsMating = creatureObject.GetPropertyValue<bool>("bEnableTamedMating", 0, false);
            IsClone = creatureObject.GetPropertyValue<bool>("bIsCloneDino", 0, false);


            int testTarget = creatureObject.GetPropertyValue<int>("TargetingTeam", 0, 0);
            int testTeam = creatureObject.GetPropertyValue<int>("TamingTeamID", 0, 0);


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

            ImprintedPlayerId = creatureObject.GetPropertyValue<long>("ImprinterPlayerDataID", 0, 0);
            if (ImprintedPlayerId > 0 && statusObject!=null)
            {
                ImprintQuality = (decimal)statusObject.GetPropertyValue<float>("DinoImprintingQuality", 0, 0);
                ImprinterName = creatureObject.GetPropertyValue<string>("ImprinterName");
                TamerName = "";
            }


            IsCryo = creatureObject.IsInCryo;
            IsVivarium = creatureObject.IsInVivarium;



            if (IsCryo || IsVivarium)
            {
                //stored creatures don't have unique DinoId properties.  Negate to make them unique from non cryo tames.
                Id = -Id;
            }

            RandomMutationsFemale = creatureObject.GetPropertyValue<int>("RandomMutationsFemale", 0, 0);
            RandomMutationsMale = creatureObject.GetPropertyValue<int>("RandomMutationsMale", 0, 0);

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
                    StructPropertyList? parentProperties = parentPropertyStruct.Cast<StructPropertyList>().FirstOrDefault();
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
            TamedStats = new byte[8];
        }

        public ContentTamedCreature(AsaGameObject creatureObject, AsaGameObject statusObject) : base(creatureObject, statusObject)
        {
            TamedTimeInGame = creatureObject.GetPropertyValue<double>("TamedAtTime", 0, 0);
            UploadedTime = null;
            UploadedTimeInGame = 0;

            IsWandering = creatureObject.GetPropertyValue<bool>("bEnableTamedWandering", 0, false);
            IsMating = creatureObject.GetPropertyValue<bool>("bEnableTamedMating", 0, false);
            IsClone = creatureObject.GetPropertyValue<bool>("bIsCloneDino", 0, false);
            IsCryo = creatureObject.GetPropertyValue<bool>("IsInCryo", 0, false);

            int testTarget = creatureObject.GetPropertyValue<int>("TargetingTeam",0,0);
            int testTeam = creatureObject.GetPropertyValue<int?>("TamingTeamID",0,0)??0;

            TargetingTeam = testTarget;
            if (TargetingTeam == 2_000_000_000 && IsBaby)
            {
                //unclaimed baby, try determine parent targeting team instead

            }


            LastAllyInRangeTimeInGame = creatureObject.GetPropertyValue<double>("LastInAllyRangeSerialized", 0, 0);

            TribeName = creatureObject.GetPropertyValue<string>("TribeName", 0, "")??"";
            Name = creatureObject.GetPropertyValue<string>("TamedName", 0, "") ?? "";

            if (statusObject == null)
            {
                Level = 1;
            }
            else
            {
                int baseLevel = statusObject.GetPropertyValue<int>("BaseCharacterLevel", defaultValue: 1);
                int extraLevel = statusObject.GetPropertyValue<int>("ExtraCharacterLevel",0,0)??0;
                Level = baseLevel + extraLevel;
            }


            TamedOnServerName = creatureObject.GetPropertyValue<string>("TamedOnServerName", 0, "") ?? "";
            UploadedServerName = creatureObject.GetPropertyValue<string>("UploadedFromServerName", 0, "") ?? "";

            TamerName = creatureObject.GetPropertyValue<string>("TamerString", 0, "") ?? "";

            ImprintedPlayerId = (long)creatureObject.GetPropertyValue<ulong>("ImprinterPlayerDataID", 0, 0);
            ImprintedPlayerNetId = creatureObject.GetPropertyValue<string>("ImprinterPlayerUniqueNetId", 0, "")??"";

            ImprintQuality = (decimal)statusObject.GetPropertyValue<float>("DinoImprintingQuality", 0, 0);
            ImprinterName = creatureObject.GetPropertyValue<string>("ImprinterName", 0, "") ?? "";
            if(!string.IsNullOrEmpty(ImprinterName)) TamerName = "";




            //IsCryo = false;
            IsVivarium = false;

            if (IsCryo || IsVivarium)
            {
                //stored creatures don't have unique DinoId properties.  Negate to make them unique from non cryo tames.
                Id = -Id;
            }

            RandomMutationsFemale = creatureObject.GetPropertyValue<int>("RandomMutationsFemale", 0, 0);
            RandomMutationsMale = creatureObject.GetPropertyValue<int>("RandomMutationsMale", 0, 0);

            TamedStats = new byte[12];
            if (statusObject != null)
            {
                Experience = statusObject.GetPropertyValue<float>("ExperiencePoints", 0, 0);

                for (var i = 0; i < TamedStats.Length; i++)
                { 
                    var tamedBase = (byte)(statusObject.GetPropertyValue<uint>("NumberOfLevelUpPointsAppliedTamed", i,0) ?? 0);
            
                    TamedStats[i] = tamedBase;
                }

            }

            TamedMutations = new byte[12];
            if (statusObject != null)
            {
                for (var i = 0; i < TamedMutations.Length; i++)
                {
                    var mutationsApplied = (byte)(statusObject.GetPropertyValue<uint>("NumberOfMutationsAppliedTamed", i,0) ?? 0);

                    TamedMutations[i] = mutationsApplied;
                }
            }



            if (creatureObject.Location!= null) 
            {
                X = (float)creatureObject.Location.X;
                Y = (float)creatureObject.Location.Y;
                Z = (float)creatureObject.Location.Z;           
            }



            //ancestors
            List<dynamic>? dinoAncestors = creatureObject.GetPropertyValue<List<dynamic>?>("DinoAncestors", 0, null);
            if (dinoAncestors != null)
            {
                var ancestorData = dinoAncestors.FirstOrDefault() as List<dynamic>;

                UInt32 maleId1 = ancestorData.Cast<AsaProperty<dynamic>>().FirstOrDefault(p => p.Name == "MaleDinoID1").Value;
                UInt32 maleId2 = ancestorData.Cast<AsaProperty<dynamic>>().FirstOrDefault(p => p.Name == "MaleDinoID2").Value;
                
                FatherId = AsaExtensions.CreateDinoId((int)maleId1,(int)maleId2);
                FatherName = ancestorData.Cast<AsaProperty<dynamic>>().FirstOrDefault(p=>p.Name == "MaleName")?.Value??"[Unknown]";


                UInt32 femaleId1 = ancestorData.Cast<AsaProperty<dynamic>>().FirstOrDefault(p => p.Name == "FemaleDinoID1")?.Value;
                UInt32 femaleId2 = ancestorData.Cast<AsaProperty<dynamic>>().FirstOrDefault(p => p.Name == "FemaleDinoID2")?.Value;
                MotherId  = AsaExtensions.CreateDinoId((int)femaleId1,(int)femaleId2);
                MotherName = ancestorData.Cast<AsaProperty<dynamic>>().FirstOrDefault(p => p.Name == "FemaleName")?.Value ?? "[Unknown]";

            }


            var geneTraits = creatureObject.Properties.Find(p => p.Name == "GeneTraits")?.Value;
            if (geneTraits != null)
            {
                foreach (string geneTrait in geneTraits)
                {
                    string traitName = geneTrait;
                    
                    var openBracketPos = geneTrait.LastIndexOf("[");
                    var closeBracketPos = geneTrait.LastIndexOf("]");

                    if(openBracketPos >0 && closeBracketPos > 0)
                    {
                        var traitClass = geneTrait.Substring(0, openBracketPos);
                        var traitTier = int.Parse(geneTrait.Substring(openBracketPos + 1, closeBracketPos - openBracketPos - 1));

                        traitName = string.Concat(traitClass.Replace("Inherit", ""), " (", traitTier + 1, ")");

                    }


                    Traits.Add(traitName);

                }

            }
        }

    }
}
