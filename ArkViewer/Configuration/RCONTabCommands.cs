using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ArkViewer.Configuration
{
    [DataContract]
    public class RCONTabCommands
    {
        [DataMember(Name ="name")] public string TabName { get; set; }
        [DataMember(Name ="commands")] public List<RCONCommand> Commands { get; set; } = new List<RCONCommand>();

    }
}
