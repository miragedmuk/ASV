using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASVPack.Models
{
    public class ContentMapRegion
    {

        public string RegionName { get; set; } = string.Empty;
        public string ImageFile { get; set; } = string.Empty;
        public float LatitudeStart { get; set; } = 0;
        public float LatitudeEnd { get; set; } = 0;
        public float LongitudeStart { get; set; } = 0;
        public float LongitudeEnd { get; set; } = 0;
        public float ZStart {get;set;} = 0;
        public float ZEnd { get; set; } = 0;
        public string MarkerColor { get; set; } = "#000000";

    }
}
