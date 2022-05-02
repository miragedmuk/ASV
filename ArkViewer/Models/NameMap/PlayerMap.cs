using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARKViewer.Models.NameMap
{
    public class PlayerMap : IEquatable<PlayerMap>
    {
        public long TribeId { get; set; }
        public long PlayerId { get; set; }
        public string PlayerName { get; set; }

        public override int GetHashCode()
        {
            int hashPlayerId = PlayerId.GetHashCode(); ;

            return hashPlayerId;
        }


        public bool Equals(PlayerMap other)
        {
            return this.PlayerId == other.PlayerId;
        }
    }
}
