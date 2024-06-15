using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARKViewer.Models
{
    public class ASVFoundItem
    {
        public long TribeId { get; set; } = int.MinValue;
        public string TribeName { get; set; } = "[Abandoned]";
        public string ContainerName { get; set; } = "Structure";
        public long ItemId { get; set; } = 0;
        public string ClassName { get; set; } = "";
        public string DisplayName { get; set; } = "";
        public long? PlayerId { get; set; } = null;
        public string PlayerName { get; set; } = "";
        public bool IsBlueprint { get; set; } = false;
        public int Quantity { get; set; } = 0;
        public float Latitude { get; set; } = 0;
        public float Longitude { get; set; } = 0;
        public float X { get; set; } = 0;
        public float Y { get; set; } = 0;
        public float Z { get; set; } = 0;
        public string Quality { get; set; } = "";
        public int? QualityColor { get; set; } = null;
        public float? Rating { get; set; } = null;
        public DateTime? UploadedTime { get; set; } = null;


    }
}
