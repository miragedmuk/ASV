using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ARKViewer.Models.NameMap
{
    [DataContract]
    public class MissionMap
    {
        [DataMember] public string FullTag { get; set; } = "";
        [DataMember] public string MissionTag { get; set; } = "";
        [DataMember] public string DisplayName { get; set; } = "";
    }
}
