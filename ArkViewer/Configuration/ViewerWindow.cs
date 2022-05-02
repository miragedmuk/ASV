using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ARKViewer.Models
{
    [DataContract]
    public class ViewerWindow
    {
        [DataMember] public string Name { get; set; } = "";
        [DataMember] public int Top { get; set; } = 0;
        [DataMember] public int Left { get; set; } = 0;
        [DataMember] public int Width { get; set; } = 0;
        [DataMember] public int Height { get; set; } = 0;
        [DataMember] public string Monitor { get; set; } = "";

    }
}
