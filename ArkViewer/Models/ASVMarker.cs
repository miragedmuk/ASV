using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ARKViewer.Models
{
    public class ASVMarker
    {
        public string Name { get; set; } = "";
        public int Colour { get; set; } = Color.White.ToArgb();
        public string Image { get; set; } = "";
        public int BorderColour { get; set; } = Color.Black.ToArgb();
        public int BorderWidth { get; set; } = 0;
        public double Lat { get; set; } = 0;
        public double Lon { get; set; } = 0;
        public bool Displayed { get; set; } = false;
    }
}
