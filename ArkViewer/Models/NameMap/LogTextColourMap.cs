using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ARKViewer.Models.NameMap
{
    [DataContract]
    public class LogTextColourMap
    {
        [DataMember]
        public int gc { get; set; } = 0;
        [DataMember]
        public int cc { get; set; } = 0;

        public LogTextColourMap(int gameColour, int customColour)
        {
            gc = gameColour;
            cc = customColour;
        }

    }
}
