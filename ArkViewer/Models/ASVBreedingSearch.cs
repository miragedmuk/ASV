using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ARKViewer.Models
{
    [DataContract]
    public class ASVBreedingSearch
    {
        [DataMember] public string ClassName { get; set; } = "";
        [DataMember] public bool Tamed { get; set; } = false;
        [DataMember] public int RangeHp { get; set; } = 10;
        [DataMember] public int RangeStamina { get; set; } = 50;
        [DataMember] public int  RangeMelee { get; set; } = 50;
        [DataMember] public int RangeWeight { get; set; } = 50;
        [DataMember] public int RangeSpeed { get; set; } = 50;
        [DataMember] public int RangeFood { get; set; } = 50;
        [DataMember] public int RangeOxygen { get; set; } = 50;
        [DataMember] public int RangeCrafting { get; set; } = 50;

        [DataMember] public List<int> ColoursRegion0 { get; set; } = new List<int>();
        [DataMember] public List<int> ColoursRegion1 { get; set; } = new List<int>();
        [DataMember] public List<int> ColoursRegion2 { get; set; } = new List<int>();
        [DataMember] public List<int> ColoursRegion3 { get; set; } = new List<int>();
        [DataMember] public List<int> ColoursRegion4 { get; set; } = new List<int>();
        [DataMember] public List<int> ColoursRegion5 { get; set; } = new List<int>();

    }
}
