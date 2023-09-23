using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ARKViewer.Configuration
{
    [DataContract]
    public class ServerConfiguration
    {


        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public int Port { get; set; } = 8821;
        [DataMember]
        public string SaveGamePath { get; set; }
        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string IV { get; set; }
        [DataMember]
        public string PR { get; set; }
        [DataMember]
        public string PH { get; set; }
        [DataMember]
        public string TR { get; set; }
        [DataMember]
        public string TH { get; set; }
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public string Map { get; set; } = "theisland.ark";
        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public int Mode { get; set; } = 0;
        public List<string> RestrictedTribes = new List<string>();
        public List<int> RestrictedPlayers = new List<int>();

        [DataMember(EmitDefaultValue = false, IsRequired = false)] public string RCONServerIP { get; set; } = string.Empty;
        [DataMember(EmitDefaultValue = false, IsRequired = false)] public string RCONPassword { get; set; } = string.Empty;
        [DataMember(EmitDefaultValue = false, IsRequired = false)] public int RCONPort { get; set; } = 27020;

        public override string ToString()
        {
            return Name;
        }





    }
}
