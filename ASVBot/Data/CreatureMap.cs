using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ASVBot.Data
{
    [DataContract]
    public class CreatureMap: ICreatureMap
    {
        [DataMember]
        public string ClassName { get; set; } = string.Empty;
        [DataMember]
        public string FriendlyName { get; set; } = string.Empty;

    }
}
