using System.Collections.Generic;
using System.Collections.Immutable;

namespace SavegameToolkitAdditions.IndexMappings {

    public static class AttributeNames {
        public static readonly ImmutableDictionary<int, string> Instance;

        static AttributeNames() {
            Instance = new Dictionary<int, string> {
                    { 0, "health" },
                    { 1, "stamina" },
                    { 2, "torpor" },
                    { 3, "oxygen" },
                    { 4, "food" },
                    { 5, "water" },
                    { 6, "temperature" },
                    { 7, "weight" },
                    { 8, "melee" },
                    { 9, "speed" },
                    { 10, "fortitude" },
                    { 11, "crafting" },
            }.ToImmutableDictionary();
        }
    }

}
