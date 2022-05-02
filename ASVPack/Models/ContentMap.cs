using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ASVPack.Models
{
    public class ContentMap
    {
        public string MapName { get; set; } = "";
        public string Filename { get; set; } = "";
        public string ImageFile { get; set; } = "";
        public decimal LatShift { get; set; } = 50;
        public decimal LonShift { get; set; } = 50;
        public decimal LatDiv { get; set; } = 8000;
        public decimal LonDiv { get; set; } = 8000;

    }
}