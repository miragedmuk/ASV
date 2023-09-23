using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ArkViewer.Configuration
{
    [DataContract]
    public class OfflineFileConfiguration
    {
        [DataMember] public string Filename { get; set; } = string.Empty;
        [DataMember] public string ClusterFolder { get; set; } = string.Empty;
        [DataMember] public string Name { get; set; } = string.Empty;
        [DataMember(EmitDefaultValue = false, IsRequired = false)] public string RCONServerIP { get; set; } = string.Empty;
        [DataMember(EmitDefaultValue = false, IsRequired = false)] public string RCONPassword { get; set; } = string.Empty;
        [DataMember(EmitDefaultValue = false, IsRequired = false)] public int RCONPort { get; set; } = 27020;

        public override string ToString()
        {
            return Name;
        }

    }
}
