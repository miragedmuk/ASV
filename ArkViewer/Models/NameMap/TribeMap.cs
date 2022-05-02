using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARKViewer.Models.NameMap
{
    public class TribeMap : IEquatable<TribeMap>
    {
        public long TribeId { get; set; }
        public string TribeName { get; set; }
        public int PlayerCount { get; set; }
        public long TameCount { get; set; }
        public long StructureCount { get; set; }
        public DateTime LastActive { get; set; }
        public bool ContainsLog { get; set; }

        public override int GetHashCode()
        {
            int hashTribeId = TribeId.GetHashCode();
            int hashTribeName = TribeName == null ? 0 : TribeName.GetHashCode();

            return hashTribeId ^ hashTribeName;
        }

        public bool Equals(TribeMap other)
        {
            return this.TribeId == other.TribeId;
        }


    }
}
