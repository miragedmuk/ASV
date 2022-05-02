using System.Collections.Generic;
using System.Collections.Immutable;

namespace SavegameToolkitAdditions.IndexMappings {

    public static class PlayerBoneModifierNames {
        public static readonly ImmutableDictionary<int, string> Instance;

        static PlayerBoneModifierNames() {
            Instance = new Dictionary<int, string> {
                    { 0, "head" },
                    { 1, "neck" },
                    { 2, "necklength" },
                    { 3, "chest" },
                    { 4, "shoulders" },
                    { 5, "armlength" },
                    { 6, "upperarm" },
                    { 7, "lowerarm" },
                    { 8, "hand" },
                    { 9, "leglength" },
                    { 10, "upperleg" },
                    { 11, "lowerleg" },
                    { 12, "foot" },
                    { 13, "hip" },
                    { 14, "torso" },
                    { 15, "upperfacesize" },
                    { 16, "lowerfacesize" },
                    { 17, "torsodepth" },
                    { 18, "headheight" },
                    { 19, "headwidth" },
                    { 20, "headdepth" },
                    { 21, "torsoheight" }
            }.ToImmutableDictionary();
        }
    }

}
