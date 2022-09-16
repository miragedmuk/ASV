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
        [DataMember] public int Level { get; set; } = 0;
        [DataMember] public byte[] Stats { get; set; } = new byte[12];
        [DataMember] public double LastTimeInGame { get; set; } = 0;
        [DataMember] public DateTime? LastActiveDateTime { get; set; } = null;
        [DataMember] public int TargetingTeam { get; set; } = int.MinValue; //abandoned
        [DataMember] public List<ContentMissionScore> MissionScores { get; set; } = new List<ContentMissionScore>();
        

        public bool HasGameFile { get; set; } = false;

        public bool IsSpawned()
        {
            return X.HasValue;
        }
        public ContentPlayer()
        {

        }

        public ContentPlayer(GameObject playerObject)
        {
            var playerData = (StructPropertyList)playerObject.GetTypedProperty<PropertyStruct>("MyData").Value;


            HasGameFile = true;
            Id = playerData.GetPropertyValue<long>("PlayerDataID");

            StructUniqueNetIdRepl netId = (StructUniqueNetIdRepl)playerData.GetTypedProperty<PropertyStruct>("UniqueID")?.Value;
            NetworkId = netId == null ? "" : netId.NetId;
            Name = playerData.GetPropertyValue<string>("PlayerName") ?? "Unknown";
            CharacterName = Name;
            TargetingTeam = playerData.GetPropertyValue<int>("TribeId");
            LastTimeInGame = playerData.GetPropertyValue<double>("LoginTime");

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

            StructUniqueNetIdRepl netId = (StructUniqueNetIdRepl)playerData.GetTypedProperty<PropertyStruct>("UniqueID")?.Value;
            NetworkId = netId == null ? "" : netId.NetId;
            Name = playerData.GetPropertyValue<string>("PlayerName") ?? "Unknown";
            CharacterName = Name;
            TargetingTeam = playerData.GetPropertyValue<int>("TribeId");
            LastTimeInGame = playerData.GetPropertyValue<double>("LoginTime");



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
            CharacterName = playerComponent.GetPropertyValue<string>("PlayerName");
            Level = getFullLevel(statusComponent);
            Gender = playerComponent.ClassName.Name.ToLower().Contains("female") ? "Female" : "Male";

            if (playerComponent.Location != null)
            {
                X = playerComponent.Location?.X;
                Y = playerComponent.Location?.Y;
                Z = playerComponent.Location?.Z;
            }


        }

        public override bool Equals(object obj)
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

    }
}
