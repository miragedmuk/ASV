using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ARKViewer.Models
{
    [DataContract]
    public class ASVStructureMarker
    {

        [DataMember]
        public string Map { get; set; } = "";

        [DataMember]
        public string Colour { get; set; } = Color.White.ToString();

        [DataMember]
        public double Lat { get; set; } = 0;

        [DataMember]
        public double Lon { get; set; } = 0;
        [DataMember]
        public float X { get; set; } = 0;

        [DataMember]
        public float Y { get; set; } = 0;
        [DataMember]
        public float Z { get; set; } = 0;

    }
}
