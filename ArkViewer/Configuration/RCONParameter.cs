using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ArkViewer.Configuration
{
    public class RCONParameter
    {       
        [DataMember] public string Key { get; set; }
        [DataMember] public bool Quoted { get; set; }
        [DataMember] public int Order { get; set; }
        [DataMember] public string? Default { get; set; } = null;
    }
}
