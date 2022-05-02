using System.Collections.Generic;
using System.Collections.Immutable;

namespace SavegameToolkitAdditions.IndexMappings {

    public static class TribeGovernPINCode {
        public static readonly ImmutableDictionary<int, string> Instance;

        static TribeGovernPINCode() {
            Instance = new Dictionary<int, string> {
                    { 0, "Tribe" },
                    { 1, "Personal" }
            }.ToImmutableDictionary();
        }
    }

}
