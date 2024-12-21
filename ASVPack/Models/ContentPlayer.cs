using AsaSavegameToolkit;
using AsaSavegameToolkit.Propertys;
using AsaSavegameToolkit.Structs;
using AsaSavegameToolkit.Types;
using ASVPack.Extensions;
using SavegameToolkit;
using SavegameToolkit.Arrays;
using SavegameToolkit.Propertys;
using SavegameToolkit.Structs;
using SavegameToolkit.Types;
using SavegameToolkitAdditions.IndexMappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace ASVPack.Models
{
    [DataContract]
    public class ContentPlayer
    {
        [DataMember] public long Id { get; set; } = 0;
        [DataMember] public string CharacterName { get; set; } = "";
        [DataMember] public string Name { get; set; } = "";
        [DataMember] public string Gender { get; set; } = "Male";
        [DataMember] public string NetworkId { get; set; } = "";
        [DataMember] public float? Latitude { get; set; } = null;
        [DataMember] public float? Longitude { get; set; } = null;
        [DataMember] public float? X { get; set; } = null;
        [DataMember] public float? Y { get; set; } = null;
        [DataMember] public float? Z { get; set; } = null;
        [DataMember] public ContentInventory Inventory { get; set; } = new ContentInventory();
        [DataMember] public ContentInventory Engrams { get; set; } = new ContentInventory();
        [DataMember] public ContentInventory Emotes { get; set; } = new ContentInventory();
        [DataMember] public ContentInventory Hairstyles { get; set; } = new ContentInventory();
        [DataMember] public ContentInventory FacialStyles { get; set; } = new ContentInventory();
        [DataMember] public float ExperiencePoints { get; set; }
        [DataMember] public int Level { get; set; } = 0;
        [DataMember] public byte[] Stats { get; set; } = new byte[12];
        [DataMember] public double LastTimeInGame { get; set; } = 0;
        [DataMember] public DateTime? LastActiveDateTime { get; set; } = null;
        [DataMember] public int TargetingTeam { get; set; } = int.MinValue; //abandoned
        [DataMember] public List<ContentMissionScore> MissionScores { get; set; } = new List<ContentMissionScore>();
        [DataMember] public List<ContentAchievement> Achievments { get; set; } = new List<ContentAchievement>();
        [DataMember] public List<string> ExplorerNotes { get; set; } = new List<string>();
        [DataMember] public string LastNetAddress { get;set; } = string.Empty;

        public bool HasGameFile { get; set; } = false;
        public string PlayerFilename { get; set; } = string.Empty;

        public bool IsSpawned()
        {
            return X.HasValue;
        }
        public ContentPlayer()
        {

        }

        public ContentPlayer(GameObject playerObject)
        {

            if (!playerObject.HasAnyProperty("MyData")) return;

            var playerData = (StructPropertyList)playerObject.GetTypedProperty<PropertyStruct>("MyData").Value;
            if (playerData == null) return;

            HasGameFile = true;
            Id = playerData.GetPropertyValue<long>("PlayerDataID");

            StructUniqueNetIdRepl? netId = (StructUniqueNetIdRepl?)playerData.GetTypedProperty<PropertyStruct>("UniqueID")?.Value;
            NetworkId = netId == null ? "" : netId.NetId;
            Name = playerData.GetPropertyValue<string>("PlayerName") ?? "Unknown";
            CharacterName = Name;
            TargetingTeam = playerData.GetPropertyValue<int>("TribeId");
            LastTimeInGame = playerData.GetPropertyValue<double>("LastLoginTime");

            var characterConfig = playerData.GetTypedProperty<PropertyStruct>("MyPlayerCharacterConfig");
            if (characterConfig != null)
            {
                var playerConfig = (StructPropertyList)characterConfig.Value;
                CharacterName = playerConfig.GetPropertyValue<string>("PlayerCharacterName") ?? Name;
                Gender = playerConfig.GetPropertyValue<bool>("bIsFemale") ? "Female" : "Male";
            }

            X = 0;
            Y = 0;
            Z = 0;

            var characterStats = playerData.GetTypedProperty<PropertyStruct>("MyPersistentCharacterStats");
            if (characterStats != null)
            {
                var playerStatus = (StructPropertyList)characterStats.Value;

                ExperiencePoints = playerStatus.GetPropertyValue<float>("ExperiencePoints", 0, 0);

                Level = playerStatus.GetPropertyValue<short>("CharacterStatusComponent_ExtraCharacterLevel") + 1;
                Stats = new byte[12];
                for (var i = 0; i < Stats.Length; i++)
                {
                    var pointValue = playerStatus.GetTypedProperty<PropertyByte>("CharacterStatusComponent_NumberOfLevelUpPointsApplied", i);
                    Stats[i] = pointValue == null ? (byte)0 : pointValue.Value.ByteValue;
                }

            }

            if (playerData.HasAnyProperty("LatestMissionScores"))
            {
                var missionScores = playerData.GetTypedProperty<PropertyArray>("LatestMissionScores");
                if (missionScores != null)
                {

                    foreach (StructPropertyList propertyList in (ArkArrayStruct)missionScores.Value)
                    {
                        var bestScore = (StructPropertyList)propertyList.GetTypedProperty<PropertyStruct>("BestScore").Value;

                        var newScore = new ContentMissionScore()
                        {
                            FullTag = bestScore.GetTypedProperty<PropertyName>("MissionTag").Value.Name
                        };

                        float floatValue = bestScore.GetPropertyValue<float>("FloatValue");
                        int intValue = bestScore.GetPropertyValue<int>("IntValue");

                        string stringScore = floatValue.ToString($"f{intValue}");
                        decimal.TryParse(stringScore, out decimal highScore);
                        newScore.HighScore = (decimal)highScore;
                        newScore.FullTag = newScore.FullTag.Substring(newScore.MissionTag.LastIndexOf(".") + 1);

                        MissionScores.Add(newScore);
                    }
                }

            }
        }

        public ContentPlayer(ArkProfile playerProfile)
        {
            var playerData = (StructPropertyList)playerProfile.GetTypedProperty<PropertyStruct>("MyData").Value;


            HasGameFile = true;
            Id = playerData.GetPropertyValue<long>("PlayerDataID");

            StructUniqueNetIdRepl? netId = (StructUniqueNetIdRepl?)playerData.GetTypedProperty<PropertyStruct>("UniqueID")?.Value;
            NetworkId = netId == null ? "" : netId.NetId;
            Name = playerData.GetPropertyValue<string>("PlayerName") ?? "Unknown";
            CharacterName = Name;
            TargetingTeam = playerData.GetPropertyValue<int>("TribeId");
            LastTimeInGame = playerData.GetPropertyValue<double>("LastLoginTime");
            try
            {
                LastNetAddress = playerData.GetPropertyValue<string>("SavedNetworkAddress");
            }
            catch { }
            

            var characterConfig = playerData.GetTypedProperty<PropertyStruct>("MyPlayerCharacterConfig");
            if (characterConfig != null)
            {
                var playerConfig = (StructPropertyList)characterConfig.Value;
                CharacterName = playerConfig.GetPropertyValue<string>("PlayerCharacterName") ?? Name;
                Gender = playerConfig.GetPropertyValue<bool>("bIsFemale") ? "Female" : "Male";
            }

            X = 0;
            Y = 0;
            Z = 0;

            var characterStats = playerData.GetTypedProperty<PropertyStruct>("MyPersistentCharacterStats");
            if (characterStats != null)
            {
                var playerStatus = (StructPropertyList)characterStats.Value;

                ExperiencePoints = playerStatus.GetPropertyValue<float>("ExperiencePoints", 0, 0);

                Level = playerStatus.GetPropertyValue<short>("CharacterStatusComponent_ExtraCharacterLevel") + 1;
                Stats = new byte[12];
                for (var i = 0; i < Stats.Length; i++)
                {
                    var pointValue = playerStatus.GetTypedProperty<PropertyByte>("CharacterStatusComponent_NumberOfLevelUpPointsApplied", i);
                    Stats[i] = pointValue == null ? (byte)0 : pointValue.Value.ByteValue;
                }

                Emotes = new ContentInventory();
                Hairstyles = new ContentInventory();
                FacialStyles = new ContentInventory();

                var playerEmotes = playerStatus.GetTypedProperty<PropertyArray>("EmoteUnlocks");
                if (playerEmotes != null)
                {
                    foreach (var playerEmote in (ArkArrayName)playerEmotes.Value)
                    {
                        ContentItem engramItem = new ContentItem();

                        engramItem.ClassName = playerEmote.Name.ToString();
                        engramItem.Quantity = 1;
                        engramItem.IsEngram = true;

                        if (engramItem.ClassName.ToLower().StartsWith("emote"))
                        {
                            Emotes.Items.Add(engramItem);
                        }
                        else if (engramItem.ClassName.ToLower().StartsWith("headhair"))
                        {
                            Hairstyles.Items.Add(engramItem);
                        }
                        else if (engramItem.ClassName.ToLower().StartsWith("facialhair"))
                        {
                            FacialStyles.Items.Add(engramItem);
                        }
                    }
                }


                Engrams = new ContentInventory();

                var playerEngrams = playerStatus.GetTypedProperty<PropertyArray>("PlayerState_EngramBlueprints");
                if (playerEngrams != null)
                {
                    foreach (var playerEngram in (ArkArrayObjectReference)playerEngrams.Value)
                    {
                        ContentItem engramItem = new ContentItem();

                        string fullTag = playerEngram.ObjectString.Name;
                        engramItem.ClassName = fullTag.Substring(fullTag.LastIndexOf(".") + 1);
                        engramItem.Quantity = 1;
                        engramItem.IsEngram = true;

                        Engrams.Items.Add(engramItem);

                    }
                }

            }

            if (playerData.HasAnyProperty("LatestMissionScores"))
            {
                var missionScores = playerData.GetTypedProperty<PropertyArray>("LatestMissionScores");
                if (missionScores != null)
                {

                    foreach (StructPropertyList propertyList in (ArkArrayStruct)missionScores.Value)
                    {
                        var bestScore = (StructPropertyList)propertyList.GetTypedProperty<PropertyStruct>("BestScore").Value;

                        var newScore = new ContentMissionScore()
                        {
                            FullTag = bestScore.GetTypedProperty<PropertyName>("MissionTag").Value.Name
                        };

                        float floatValue = bestScore.GetPropertyValue<float>("FloatValue");
                        int intValue = bestScore.GetPropertyValue<int>("IntValue");

                        string stringScore = floatValue.ToString($"f{intValue}");
                        decimal.TryParse(stringScore, out decimal highScore);
                        newScore.HighScore = (decimal)highScore;
                        newScore.MissionTag = newScore.FullTag.Substring(newScore.MissionTag.LastIndexOf(".") + 1);

                        MissionScores.Add(newScore);
                    }
                }

            }

        }

        public ContentPlayer(GameObject playerComponent, GameObject statusComponent)
        {
            /*

            StructProperty MyData
            StructPropertList MyData.Value
                long PlayerDataID
                string PlayerName
                PropertyStruct MyPlayerCharacterConfig
                StructPropertList MyPlayerCharacterConfig.Value
                PropertyStruct MyPersistentCharacterStats
                StructPropertList MyPersistentCharacterStats.Value
                int TribeId


            */


            //get data
            HasGameFile = false;
            Id = playerComponent.GetPropertyValue<long?>("PlayerDataID") ?? playerComponent.GetPropertyValue<long>("LinkedPlayerDataID");
            TargetingTeam = playerComponent.GetPropertyValue<int>("TargetingTeam");
            Stats = new byte[12];
            if (statusComponent != null)
                for (var i = 0; i < Stats.Length; i++) Stats[i] = statusComponent.GetPropertyValue<ArkByteValue>("NumberOfLevelUpPointsApplied", i)?.ByteValue ?? 0;

            LastTimeInGame = playerComponent.GetPropertyValue<double>("SavedLastTimeHadController");
            Name = playerComponent.GetPropertyValue<string>("PlatformProfileName");

            var netId = playerComponent.Properties.Find(p=>p.Name.Name == "PlatformProfileID");
            if(netId!= null)
            {
                PropertyStruct netIdStruct = (PropertyStruct)netId;
                StructUniqueNetIdRepl uniqueNetId = (StructUniqueNetIdRepl)netIdStruct.Value;
                NetworkId = uniqueNetId.NetId;
            }

            CharacterName = playerComponent.GetPropertyValue<string>("PlayerName");
            if (statusComponent != null)
            {
                Level = getFullLevel(statusComponent);
                ExperiencePoints = statusComponent.GetPropertyValue<float>("ExperiencePoints",0,0);
            }
            Gender = playerComponent.ClassName.Name.ToLower().Contains("female") ? "Female" : "Male";
           
            if (playerComponent.Location != null)
            {
                X = playerComponent.Location?.X;
                Y = playerComponent.Location?.Y;
                Z = playerComponent.Location?.Z;
            }


        }

        public ContentPlayer(AsaObject gameObject)
        {
            if (!gameObject.HasAnyProperty("MyData")) return;

            List<dynamic>? playerData = gameObject.GetPropertyValue<dynamic>("MyData",0,null);
            if (playerData == null || playerData.Count == 0 ) return;

            HasGameFile = true;
            try
            {
                var playerDataId = playerData.FirstOrDefault(p => ((AsaProperty<dynamic>)p).Name == "PlayerDataID")?.Value;
                Id = (long)playerDataId;
                AsaSavegameToolkit.Structs.AsaUniqueNetIdRepl netId = playerData.FirstOrDefault(p => ((AsaProperty<dynamic>)p).Name == "UniqueID")?.Value;
                NetworkId = netId == null ? "" : netId.Value;
                LastNetAddress = playerData.FirstOrDefault(p => ((AsaProperty<dynamic>)p).Name == "SavedNetworkAddress")?.Value ?? "";
                Name = playerData.FirstOrDefault(p => ((AsaProperty<dynamic>)p).Name == "PlayerName")?.Value ?? "";
                CharacterName = Name;
                TargetingTeam = playerData.FirstOrDefault(p => ((AsaProperty<dynamic>)p).Name == "TribeID")?.Value ?? 0;
                LastTimeInGame = playerData.FirstOrDefault(p => ((AsaProperty<dynamic>)p).Name == "LastLoginTime")?.Value ?? 0;

                List<dynamic> characterConfig = playerData.FirstOrDefault(p => ((AsaProperty<dynamic>?)p).Name == "MyPlayerCharacterConfig")?.Value ?? null;
                if (characterConfig != null)
                {
                    CharacterName = characterConfig.FirstOrDefault(p => ((AsaProperty<dynamic>)p).Name == "PlayerCharacterName")?.Value ?? Name;
                    Gender = characterConfig.FirstOrDefault(p => ((AsaProperty<dynamic>)p).Name == "bIsFemale")?.Value ?? false ? "Female" : "Male";
                }

                X = 0;
                Y = 0;
                Z = 0;

                if (gameObject.Location != null)
                {
                    X = (float)gameObject.Location.X;
                    Y = (float)gameObject.Location.Y;
                    Z = (float)gameObject.Location.Z;
                }


                List<dynamic> characterStats = playerData.FirstOrDefault(p => ((AsaProperty<dynamic>?)p).Name == "MyPersistentCharacterStats")?.Value ?? null;
                if (characterStats != null)
                {
                    ExperiencePoints = characterStats.FirstOrDefault(p => ((AsaProperty<dynamic>)p).Name == "CharacterStatusComponent_ExperiencePoints")?.Value ?? 0;
                    Level = (characterStats.FirstOrDefault(p => ((AsaProperty<dynamic>)p).Name == "CharacterStatusComponent_ExtraCharacterLevel")?.Value ?? 0) + 1;
                    Stats = new byte[12];
                    for (var i = 0; i < Stats.Length; i++)
                    {
                        var pointValue = characterStats.FirstOrDefault(p => ((AsaProperty<dynamic>)p).Name == "CharacterStatusComponent_NumberOfLevelUpPointsApplied" && ((AsaProperty<dynamic>)p).Position == i)?.Value ?? 0;
                        Stats[i] = (byte)pointValue;
                    }


                    Emotes = new ContentInventory();
                    Hairstyles = new ContentInventory();
                    FacialStyles = new ContentInventory();

                    List<dynamic> ? ascensionData = gameObject.GetPropertyValue<dynamic>("AscensionData", 0, null);
                    int ascensionIndex = 0;


                    if (ascensionData != null)
                    {
                        foreach (var ascensionDataItem in ascensionData)
                        {
                            int.TryParse(ascensionDataItem.ToString(), out int ascensionValue);
                            if (ascensionValue > 0)
                            {
                                ContentAchievement achievement = new ContentAchievement();
                                switch (ascensionIndex)
                                {
                                    case 0:
                                        //broodmother
                                        achievement.Description = "Defeated Broodmother";


                                        break;
                                    case 1:
                                        //megapethicus
                                        achievement.Description = "Defeated Megapethicus";

                                        break;
                                    case 2:
                                        //dragon
                                        achievement.Description = "Defeated Dragon";
                                        break;
                                    case 3:
                                        //overseer
                                        achievement.Description = "Defeated Overseer";
                                        break;
                                    case 4:
                                        achievement.Description = "Defeated Manticore";
                                        break;
                                }
                                switch (ascensionValue)
                                {
                                    case 1:
                                        achievement.Level = "Gamma";
                                        break;

                                    case 2:
                                        achievement.Level = "Beta";
                                        break;

                                    case 3:
                                        achievement.Level = "Alpha";
                                        break;
                                }

                                Achievments.Add(achievement);
                            }

                            ascensionIndex++;
                        }


                    }

                    var chibiLevels = gameObject.GetPropertyValue<int>("NumChibiLevelUpsData", 0, 0);//NumChibiLevelUpsData
                    if(chibiLevels > 0)
                    {
                        Achievments.Add(new ContentAchievement("Chibi Level Ups", string.Format("+{0}",chibiLevels)));
                    }

                    
                    var namedExplorerNotes = characterStats.FirstOrDefault(p => ((AsaProperty<dynamic>?)p).Name == "PerMapNamedExplorerNoteUnlocks")?.Value ?? null;
                    if(namedExplorerNotes != null)
                    {
                        foreach (var note in namedExplorerNotes)
                        {
                            ExplorerNotes.Add(note.ToString());
                        }
                    }


                    var playerEmotes = characterStats.FirstOrDefault(p => ((AsaProperty<dynamic>?)p).Name == "EmoteUnlocks")?.Value ?? null;
                    if (playerEmotes != null)
                    {

                        foreach (var playerEmote in playerEmotes)
                        {
                            ContentItem engramItem = new ContentItem();

                            engramItem.ClassName = playerEmote;
                            engramItem.Quantity = 1;
                            engramItem.IsEngram = true;

                            
                            if (engramItem.ClassName.ToLower().StartsWith("headhair"))
                            {
                                Hairstyles.Items.Add(engramItem);
                            }
                            else if (engramItem.ClassName.ToLower().StartsWith("facialhair"))
                            {
                                FacialStyles.Items.Add(engramItem);
                            }
                            else
                            {
                                Emotes.Items.Add(engramItem);
                            }
                        }
                    }


                    Engrams = new ContentInventory();
                    var playerEngrams = characterStats.FirstOrDefault(p => ((AsaProperty<dynamic>?)p).Name == "PlayerState_EngramBlueprints")?.Value ?? null;
                    if (playerEngrams != null)
                    {
                        foreach (AsaObjectReference playerEngram in playerEngrams)
                        {
                            ContentItem engramItem = new ContentItem();

                            string fullTag = playerEngram.Value;
                            engramItem.ClassName = fullTag.Substring(fullTag.LastIndexOf(".") + 1);
                            engramItem.Quantity = 1;
                            engramItem.IsEngram = true;

                            Engrams.Items.Add(engramItem);

                        }
                    }


                }

            }
            catch
            {
                
            }

        }


        public ContentPlayer(AsaGameObject playerObject, AsaGameObject statusObject)
        {
            HasGameFile = false;
            Id = (long)(playerObject.GetPropertyValue<ulong?>("PlayerDataID") ?? playerObject.GetPropertyValue<ulong>("LinkedPlayerDataID"));
            TargetingTeam = playerObject.GetPropertyValue<int>("TargetingTeam");
            NetworkId = playerObject.GetPropertyValue<AsaUniqueNetIdRepl?>("PlatformProfileID", 0, null)?.Value ?? "";
            Stats = new byte[12];
            if (statusObject != null)
                for (var i = 0; i < Stats.Length; i++)
                {
                    Stats[i] = (byte)statusObject.GetPropertyValue<int>("NumberOfLevelUpPointsApplied", i, 0);
                }

            LastTimeInGame = playerObject.GetPropertyValue<double>("SavedLastTimeHadController");
            Name = playerObject.GetPropertyValue<string>("PlatformProfileName", 0, "")??"";
            CharacterName = playerObject.GetPropertyValue<string>("PlayerName", 0, "")??"";
            if (statusObject != null)
            {
                Level = getFullLevel(statusObject);
                ExperiencePoints = statusObject.GetPropertyValue<float>("ExperiencePoints", 0, 0);
            }
            Gender = playerObject.ClassName.Name.ToLower().Contains("female") ? "Female" : "Male";

            if (playerObject.Location != null)
            {
                X = (float)playerObject.Location?.X;
                Y = (float)playerObject.Location?.Y;
                Z = (float)playerObject.Location?.Z;
            }

        }

        public override bool Equals(object? obj)
        {
            if (obj is ContentPlayer) return ((ContentPlayer)obj).Id == Id;
            return false;
        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        private int getFullLevel(GameObject statusComponent)
        {
            if (statusComponent == null)
            {
                return 1;
            }

            int baseLevel = statusComponent.GetPropertyValue<int>("BaseCharacterLevel", defaultValue: 1);
            short extraLevel = statusComponent.GetPropertyValue<short>("ExtraCharacterLevel");
            return baseLevel + extraLevel;
        }

        private int getFullLevel(AsaGameObject statusComponent)
        {
            if (statusComponent == null)
            {
                return 1;
            }

            int baseLevel = statusComponent.GetPropertyValue<int>("BaseCharacterLevel",0,1);
            int extraLevel = (int)statusComponent.GetPropertyValue<uint>("ExtraCharacterLevel",0,0);
            return baseLevel + extraLevel;
        }
    }
}
