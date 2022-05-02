using System.Collections.Generic;
using System.Linq;
using SavegameToolkit.Types;

namespace SavegameToolkit {

    public abstract class GameObjectContainerMixin : GameObjectContainer {
        //Dictionary<int, Dictionary<List<ArkName>, GameObject>> getObjectMap();
        public Dictionary<int, Dictionary<int, GameObject>> ObjectMap { get; } = new Dictionary<int, Dictionary<int, GameObject>>();

        protected void addObject(GameObject gameObject, bool processNames) {
            
            if (processNames) {
                if (ObjectMap.TryGetValue(gameObject.FromDataFile ? gameObject.DataFileIndex : -1, out Dictionary<int, GameObject> map)) {
                    if (gameObject.HasParentNames) {
                        IEnumerable<ArkName> targetName = gameObject.ParentNames;

                        if (map.TryGetValue(targetName.HashCode(), out GameObject parent)) {
                            parent.AddComponent(gameObject);
                            gameObject.Parent = parent;
                        }
                    }

                    if (!map.ContainsKey(gameObject.Names.HashCode())) {
                        map.Add(gameObject.Names.HashCode(), gameObject);
                    }
                } else {
                    map = new Dictionary<int, GameObject> {
                            [gameObject.Names.HashCode()] = gameObject
                    };
                    ObjectMap[gameObject.FromDataFile ? gameObject.DataFileIndex : -1] = map;
                }
            }

            gameObject.Id = Objects.Count;
            Objects.Add(gameObject);
        }
    }

    public static class ArkNameExtensions {
        public static int HashCode(this IEnumerable<ArkName> arkNames) {
            return arkNames.Aggregate(1, (current, arkName) => 31 * current + (arkName?.GetHashCode() ?? 0));
        }
    }

}
