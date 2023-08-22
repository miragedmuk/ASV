using SavegameToolkit.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavegameToolkit
{
    public class StoredSummaryEntry
    {
        public long TribeId { get; internal set; }
        public LocationData? Location { get; set; }
        public string ClassName { get; internal set; } = string.Empty;
        public string Summary { get; internal set; } = string.Empty;
        public string Gender { get; internal set; } = string.Empty;
        public int[] Colors { get; internal set; } = new int[5];
        public Dictionary<string, string> Stats { get; internal set; } = new Dictionary<string, string>();

        internal StoredSummaryEntry(long tribeId, LocationData? location, string className, string summaryInfo, string gender, int[] colors, Dictionary<string,string> stats)
        {
            TribeId = tribeId;
            Location = location;
            ClassName = className;
            Summary = summaryInfo;
            Gender = gender;
            Colors = colors;    
            Stats = stats;
        }
    }
}
