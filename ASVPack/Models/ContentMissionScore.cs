using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ASVPack.Models
{
    [DataContract]
    public class ContentMissionScore
    {
        [DataMember] public string FullTag { get; set; } = "";
        [DataMember] public string MissionTag { get; set; } = "";
        [DataMember] public decimal LastScore { get; set; } = 0;
        [DataMember] public decimal HighScore { get; set; } = 0;
        [DataMember] public int TargetingTeam { get; set; } = 0;
        [DataMember] public long NetworkId { get; set; } = 0;
        [DataMember] public string PlayerName { get; set; } = "";


    }
}
