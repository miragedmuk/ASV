using System.Collections.Generic;
using System.Collections.Immutable;

namespace SavegameToolkitAdditions.IndexMappings {

    public static class PlayerBodyColorRegions {
        public static readonly ImmutableDictionary<int, string> Instance;

        static PlayerBodyColorRegions() {
            Instance = new Dictionary<int, string> {
                    { 0, "skin" },
                    { 1, "head hair" },
                    { 2, "eyes" },
                    { 3, "facial hair" }
            }.ToImmutableDictionary();
        }
    }

}
