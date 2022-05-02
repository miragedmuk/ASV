using System.Collections.Generic;
using System.Collections.Immutable;

namespace SavegameToolkitAdditions.IndexMappings {
    public static class TribeGovernDinoOwnership {
        public static readonly ImmutableDictionary<int, string> Instance;

        static TribeGovernDinoOwnership() {
            Instance = new Dictionary<int, string> {
                    { 0, "Tribe Owned" },
                    { 1, "Personally Owned, Tribe Ridden" },
                    { 2, "Personally Owned, Personally Ridden" },
            }.ToImmutableDictionary();
        }
    }
}
