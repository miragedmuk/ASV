using System.Collections.Generic;
using System.Collections.Immutable;

namespace SavegameToolkitAdditions.IndexMappings {

    public static class TribeGovernStructureOwnership {
        public static readonly ImmutableDictionary<int, string> Instance;

        static TribeGovernStructureOwnership() {
            Instance = new Dictionary<int, string> {
                    { -1, "Tribe Owned, Admin Demolish" },
                    { 0, "Tribe Owned" },
                    { 1, "Personally Owned, Tribe Snap, Admin Demolish" },
                    { 2, "Personally Owned, Personal Snap" }
            }.ToImmutableDictionary();
        }
    }

}
