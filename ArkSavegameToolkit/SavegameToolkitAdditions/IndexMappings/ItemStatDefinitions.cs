using System.Collections.Generic;
using System.Collections.Immutable;

namespace SavegameToolkitAdditions.IndexMappings {

    public class ItemStatDefinitions {
        public static readonly ImmutableDictionary<int, string> Instance;

        static ItemStatDefinitions() {
            Instance = new Dictionary<int, string> {
                    { 0, "Effectiveness" },
                    { 1, "Armor" },
                    { 2, "Max Durability" },
                    { 3, "Weapon Damage" },
                    { 4, "Weapon Clip Ammo" },
                    { 5, "Hypothermic Insulation" },
                    { 6, "Weight" },
                    { 7, "Hyperthermic Insulation" }
            }.ToImmutableDictionary();
        }
    }

}
