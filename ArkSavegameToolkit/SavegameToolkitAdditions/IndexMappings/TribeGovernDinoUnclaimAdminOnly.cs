using System.Collections.Generic;
using System.Collections.Immutable;

namespace SavegameToolkitAdditions.IndexMappings {

    public static class TribeGovernDinoUnclaimAdminOnly {
        public static readonly ImmutableDictionary<int, string> Instance;

        static TribeGovernDinoUnclaimAdminOnly() {
            Instance = new Dictionary<int, string> {
                    { 0, "Any Tribe Member" },
                    { 1, "Only Admins" }
            }.ToImmutableDictionary();
        }
    }

}
