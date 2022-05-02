using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace ASVPack.Models
{
    [DataContract]
    public class ContentMarker
    {
        [DataMember] public string Map { get; set; } = "";
        [DataMember] public string Category { get; set; } = "";
        [DataMember] public string Name { get; set; } = "";
        [DataMember] public int Colour { get; set; } = Color.White.ToArgb();
        [DataMember] public string Image { get; set; } = "";
        [DataMember] public int BorderColour { get; set; } = Color.Black.ToArgb();
        [DataMember] public int BorderWidth { get; set; } = 0;
        [DataMember] public double Lat { get; set; } = 0;
        [DataMember] public double Lon { get; set; } = 0;
        [DataMember] public bool Displayed { get; set; } = false;
        [DataMember] public bool InGameMarker { get; set; } = false;
    }
}
