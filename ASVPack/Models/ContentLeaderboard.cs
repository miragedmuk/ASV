using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ASVPack.Models
{
    [DataContract]
    public class ContentLeaderboard
    {
        [DataMember] public string FullTag { get; set; } = "";
        [DataMember] public string MissionTag { get; set; } = "";
        [DataMember] public List<ContentMissionScore> Scores { get; set; } = new List<ContentMissionScore>();

    }
}