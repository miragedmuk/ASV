using System.Collections.Generic;

namespace SavegameToolkit.Types {

    /// <summary>
    /// A list that contains all initially added element. Further elements are only added if not already exist.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ListAppendingSet<T> : HashSet<T> {
        public List<T> List { get; }
        private readonly HashSet<T> set;

        public ListAppendingSet(IReadOnlyCollection<T> list) {
            List = new List<T>(list);
            set = new HashSet<T>(list);
        }

        public new bool Add(T e) {
            if (!set.Add(e)) {
                return false;
            }

            List.Add(e);
            return true;
        }
    }

}
