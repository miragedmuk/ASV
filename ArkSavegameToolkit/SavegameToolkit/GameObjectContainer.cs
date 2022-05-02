using System.Collections;
using System.Collections.Generic;
using SavegameToolkit.Types;

namespace SavegameToolkit {

    public class GameObjectContainer : IEnumerable<GameObject> {
        protected GameObjectContainer() {
            Objects = new List<GameObject>();
        }
        public GameObjectContainer(List<GameObject> objects) {
            Objects = objects;
        }

        public virtual List<GameObject> Objects { get; }

        public virtual GameObject this[int id] => id > -1 && id < Objects.Count ? Objects[id] : null;

        public virtual GameObject this[ObjectReference reference] {
            get {
                if (reference == null || !reference.IsId) {
                    return null;
                }

                return reference.ObjectId > -1 && reference.ObjectId < Objects.Count ? Objects[reference.ObjectId] : null;
            }
        }

        public bool TryGetValue(int id, out GameObject gameObject) {
            gameObject = this[id];
            return gameObject != null;
        }

        #region Implementation of IEnumerable

        public IEnumerator<GameObject> GetEnumerator() {
            return Objects.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return GetEnumerator();
        }

        #endregion
    }
}
