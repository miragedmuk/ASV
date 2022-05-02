using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ARKViewer.Models.NameMap
{
    [DataContract]
    public class LogColourMap
    {
        [DataMember(EmitDefaultValue = true, IsRequired = false)]
        public int BackgroundColour { get; set; } = Color.FromArgb(64, 64, 64).ToArgb();
        [DataMember(EmitDefaultValue = true, IsRequired = false)]
        public int ForegroundColour { get; set; } = Color.WhiteSmoke.ToArgb();

        [DataMember(EmitDefaultValue = true, IsRequired = false)]
        public List<LogTextColourMap> TextColourMap { get; set; } = new List<LogTextColourMap>();


    }
}
