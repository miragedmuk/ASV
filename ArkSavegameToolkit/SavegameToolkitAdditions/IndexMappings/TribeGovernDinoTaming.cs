using System.Collections.Generic;
using System.Collections.Immutable;

namespace SavegameToolkitAdditions.IndexMappings {

    public static class TribeGovernDinoTaming {
        public static readonly ImmutableDictionary<int, string> Instance;

        static TribeGovernDinoTaming() {
            Instance = new Dictionary<int, string> {
                    { 0, "Tribe" },
                    { 1, "Personal" },
            }.ToImmutableDictionary();
        }
    }

}
