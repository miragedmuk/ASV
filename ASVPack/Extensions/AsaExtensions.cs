using SavegameToolkit.Propertys;
using SavegameToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsaSavegameToolkit;
using AsaSavegameToolkit.Propertys;
using System.Runtime.CompilerServices;
using ASVPack.Models;

namespace ASVPack.Extensions
{
    public static class AsaExtensions
    {
        private const int PLAYER_START = 50_000;
        private const int TRIBE_START = 1_000_000_000;
        private const int BREEDING_ID = 2_000_000_000;

        public static dynamic? GetPropertyValue<T>(this AsaGameObject gameObject, string name, int index = 0, dynamic? defaultValue = null)
        {
            foreach (var prop in gameObject.Properties)
            {
                if (prop.Position == index && prop.Name == name)
                {
                    return (T)prop.Value ;
                }
            }

            return defaultValue;
        }

        public static dynamic? GetPropertyValue<T>(this AsaObject gameObject, string name, int index = 0, dynamic? defaultValue = null)
        {
            foreach (var prop in gameObject.Properties)
            {
                if (prop.Position == index && prop.Name == name)
                {
                    return (T)prop.Value;
                }
            }

            return defaultValue;
        }

        public static bool HasAnyProperty(this AsaGameObject gameObject, string name)
        {
            bool hasProperty = gameObject.Properties.Any(p => p.Name == name);
            return hasProperty;
        }

        public static bool HasAnyProperty(this AsaObject gameObject, string name)
        {
            bool hasProperty = gameObject.Properties.Any(p => p.Name == name);
            return hasProperty;
        }

        public static bool IsStructure(this AsaGameObject gameObject)
        {
            return (
                        (
                            gameObject.HasAnyProperty("OwnerName")
                            || gameObject.HasAnyProperty("bHasResetDecayTime")
                            || gameObject.ClassString == "CherufeNest_C"
                            || gameObject.ClassString == "MotorRaft_BP_C"
                            || gameObject.ClassString == "Raft_BP_C"
                            || gameObject.ClassString == "TekHoverSkiff_Character_BP_C"
                            || gameObject.ClassString == "CogRaft_BP_C"
                            || gameObject.ClassString == "DingyRaft_BP_C"
                            || gameObject.ClassString == "LongshipRaft_BP_C"
                            || gameObject.ClassString == "SRaft_BP_C"
                        )
                        && gameObject.ClassString != "Structure_LoadoutDummy_Hotbar_C"
                        & !gameObject.ClassString.StartsWith("DeathItemCache_")
                   );
        }

        public static bool IsCreature(this AsaGameObject gameObject)
        {
            var isCreature = 
            gameObject.HasAnyProperty("bServerInitializedDino") 
            & !(
                gameObject.ClassString == "MotorRaft_BP_C"
                || gameObject.ClassString == "Raft_BP_C"
                || gameObject.ClassString == "TekHoverSkiff_Character_BP_C"
                || gameObject.ClassString == "CogRaft_BP_C"
                || gameObject.ClassString == "DingyRaft_BP_C"
                || gameObject.ClassString == "LongshipRaft_BP_C"
                || gameObject.ClassString == "SRaft_BP_C"
                );


            return isCreature;
        }



        public static bool IsWild(this AsaGameObject gameObject)
        {
            var targetingTeam = gameObject.GetPropertyValue<int>("TargetingTeam",0,0);
            return (targetingTeam < PLAYER_START && gameObject.IsCreature());
        }

        public static bool IsTamed(this AsaGameObject gameObject)
        {
            var targetingTeam = gameObject.GetPropertyValue<int>("TargetingTeam",0,0);
            return (targetingTeam >= PLAYER_START && gameObject.IsCreature());
        }

        public static bool IsPlayer(this AsaGameObject gameObject)
        {
            return gameObject.HasAnyProperty("LinkedPlayerDataID");
        }

        public static bool IsDroppedItem(this AsaGameObject gameObject)
        {
            return gameObject.HasAnyProperty("MyItem") & !gameObject.ClassString.Contains("NoStasis");
        }

        public static bool IsDeathItemCache(this AsaGameObject gameObject)
        {
            return gameObject.ClassString.StartsWith("DeathItemCache_");
        }

        public static bool IsFemale(this AsaGameObject gameObject)
        {
            return gameObject.GetPropertyValue<bool>("bIsFemale",0,false);
        }


        public static ContentStructure AsStructure(this AsaGameObject gameObject)
        {

            return new ContentStructure(gameObject);

        }

        public static ContentPlayer? AsPlayer(this AsaObject asaObject)
        {
            var playerData = new ContentPlayer(asaObject);
            return playerData.HasGameFile ? playerData : null;
        }

        public static ContentItem? AsItem(this AsaGameObject gameObject)
        {
            return new ContentItem(gameObject);
        }

        public static ContentDroppedItem AsDroppedItem(this AsaGameObject gameObject)
        {
            return new ContentDroppedItem(gameObject);
        }

        public static ContentWildCreature AsWildCreature(this AsaGameObject gameObject, AsaGameObject statusObject)
        {
            return new ContentWildCreature(gameObject, statusObject);
        }

        public static ContentTamedCreature AsTamedCreature(this AsaGameObject gameObject, AsaGameObject statusObject)
        {
            return new ContentTamedCreature(gameObject, statusObject);
        }

        public static long GetDinoId(this AsaGameObject gameObject)
        {

            int dinoId1 = (int)gameObject.GetPropertyValue<uint>("DinoID1", 0, 0);
            int dinoId2 = (int)gameObject.GetPropertyValue<uint>("DinoID2", 0, 0);
            string newDinoId = string.Concat(dinoId1, dinoId2);
            long.TryParse(newDinoId, out long dinoId);

            return dinoId;
        }

        public static long GetItemId(this AsaGameObject gameObject)
        {

            List<dynamic> itemIdStruct = gameObject.GetPropertyValue<List<dynamic>>("ItemID", 0, null);
            if (itemIdStruct == null) return 0;


            int itemId1 = (int)itemIdStruct.OfType<AsaProperty<dynamic>>().First(p => p.Name == "ItemID1").Value; 
            int itemId2 = (int)itemIdStruct.OfType<AsaProperty<dynamic>>().First(p => p.Name == "ItemID2").Value; ;
            string newItemId = string.Concat(itemId1, itemId2);
            long.TryParse(newItemId, out long itemId);

            return itemId;
        }

        public static long CreateDinoId(int id1, int id2)
        {
            string newDinoId = string.Concat(id1, id2);
            long.TryParse(newDinoId, out long dinoId);

            return dinoId;

            //return (long)id1 << 32 | (id2 & 0xFFFFFFFFL);
        }
        public static ContentTribe AsTribe(this AsaObject tribeObject)
        {
            return new ContentTribe(tribeObject);
        }

        public static ContentPlayer AsPlayer(this AsaGameObject playerObject, AsaGameObject statusObject)
        {
            return new ContentPlayer(playerObject, statusObject);
        }


    }
}
