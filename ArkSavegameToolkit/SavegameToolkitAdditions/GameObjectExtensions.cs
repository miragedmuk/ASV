using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using SavegameToolkit;
using SavegameToolkit.Types;

namespace SavegameToolkitAdditions {
    public static class GameObjectExtensions {


        public static bool IsStructure(this GameObject gameObject)
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
                        && gameObject.IsCryo == false
                        & !gameObject.ClassString.StartsWith("DeathItemCache_")
                   );
        }

        public static bool IsCreature(this GameObject gameObject) {
            return gameObject.HasAnyProperty("bServerInitializedDino") 
                        &! (
                            gameObject.ClassString == "MotorRaft_BP_C"
                            || gameObject.ClassString == "Raft_BP_C"
                            || gameObject.ClassString == "TekHoverSkiff_Character_BP_C"
                            || gameObject.ClassString == "CogRaft_BP_C"
                            || gameObject.ClassString == "DingyRaft_BP_C"
                            || gameObject.ClassString == "LongshipRaft_BP_C"
                            || gameObject.ClassString == "SRaft_BP_C"
                            );
            
        }

        public static bool IsDroppedItem(this GameObject gameObject) {
            return gameObject.HasAnyProperty("MyItem") &! gameObject.ClassString.Contains("NoStasis");
        }

        public static bool IsInventory(this GameObject gameObject) {
            return gameObject.HasAnyProperty("bInitializedMe");
        }

        public static bool IsPlayer(this GameObject gameObject) {
            return gameObject.HasAnyProperty("LinkedPlayerDataID");
        }

        public static bool IsStatusComponent(this GameObject gameObject) {
            return gameObject.HasAnyProperty("bServerFirstInitialized");
        }

        public static bool IsTamed(this GameObject gameObject) {
            TeamType teamType = TeamTypes.ForTeam(gameObject.GetPropertyValue<int>("TargetingTeam"));
            return teamType.IsTamed() && gameObject.IsCreature();
        }

        public static bool IsUnclaimedBaby(this GameObject gameObject) {
            TeamType teamType = TeamTypes.ForTeam(gameObject.GetPropertyValue<int>("TargetingTeam"));
            return teamType == TeamType.Breeding && gameObject.IsCreature();
        }

        public static bool IsWeapon(this GameObject gameObject) {
            return gameObject.HasAnyProperty("AssociatedPrimalItem") || gameObject.HasAnyProperty("MyPawn");
        }

        public static bool IsWild(this GameObject gameObject) {
            TeamType teamType = TeamTypes.ForTeam(gameObject.GetPropertyValue<int>("TargetingTeam"));
            return !teamType.IsTamed() && gameObject.IsCreature();
        }

        public static bool IsDeathItemCache(this GameObject gameObject) {
            return gameObject.ClassString.StartsWith("DeathItemCache_");
        }

        public static bool IsFemale(this GameObject gameObject) {
            return gameObject.GetPropertyValue<bool>("bIsFemale");
        }

        public static GameObject CharacterStatusComponent(this GameObject gameObject) {
            int? myCharacterStatusComponent = gameObject.GetPropertyValue<ObjectReference>("MyCharacterStatusComponent")?.ObjectId;
            return myCharacterStatusComponent.HasValue
                    ? gameObject.Components.FirstOrDefault(component => component.Value.Id == myCharacterStatusComponent).Value
                    : gameObject.Components.FirstOrDefault(component => component.Key.Name.StartsWith("DinoCharacterStatus_")).Value;

        }

        public static GameObject InventoryComponent(this GameObject gameObject)
        {
            //bInitializedMe
            int? myCharacterStatusComponent = gameObject.GetPropertyValue<ObjectReference>("MyInventoryComponent")?.ObjectId;
            return myCharacterStatusComponent.HasValue
                    ? gameObject.Components.FirstOrDefault(component => component.Value.Id == myCharacterStatusComponent).Value
                    : null;

        }



        public static int GetBaseLevel(this GameObject gameObject) {
            return gameObject.CharacterStatusComponent()?.GetPropertyValue<int>("BaseCharacterLevel") ?? 1;
        }

        public static int GetBaseLevel(this GameObject gameObject, GameObjectContainer saveFile) {
            ObjectReference objectReference = gameObject.GetPropertyValue<ObjectReference>("MyCharacterStatusComponent");
            GameObject statusComponent = objectReference != null ? saveFile[objectReference] : null;

            return statusComponent?.GetPropertyValue<int>("BaseCharacterLevel") ?? 1;
        }

        public static int GetFullLevel(this GameObject gameObject) {
            GameObject statusComponent = gameObject.CharacterStatusComponent();
            return getFullLevel(statusComponent);
        }

        public static int GetFullLevel(this GameObject gameObject, GameObjectContainer saveFile) {
            ObjectReference objectReference = gameObject.GetPropertyValue<ObjectReference>("MyCharacterStatusComponent");

            GameObject statusComponent = objectReference != null ? saveFile[objectReference] : null;

            return getFullLevel(statusComponent);
        }

        private static int getFullLevel(GameObject statusComponent) {
            if (statusComponent == null) {
                return 1;
            }

            int baseLevel = statusComponent.GetPropertyValue<int>("BaseCharacterLevel", defaultValue: 1);
            short extraLevel = statusComponent.GetPropertyValue<short>("ExtraCharacterLevel");
            return baseLevel + extraLevel;
        }

        public static string GetNameForCreature(this GameObject gameObject, ArkData arkData, string valueIfNotFound = null) {
            return arkData.GetCreatureForClass(gameObject.ClassString)?.Name ?? valueIfNotFound;
        }

        public static string GetNameForStructure(this GameObject gameObject, ArkData arkData) {
            return arkData.GetStructureForClass(gameObject.ClassString)?.Name;
        }

        public static string GetNameForItem(this GameObject gameObject, ArkData arkData) {
            return arkData.GetItemForClass(gameObject.ClassString)?.Name;
        }

        public static long GetDinoId(this GameObject gameObject) {
            return CreateDinoId(gameObject.GetPropertyValue<int>("DinoID1"), gameObject.GetPropertyValue<int>("DinoID2"));
        }

        public static long CreateDinoId(int id1, int id2) {
            return (long)id1 << 32 | (id2 & 0xFFFFFFFFL);
        }
    }
}
