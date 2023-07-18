using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ASVBot.Data
{
    [DataContract]
    public class DiscordPlayer: IDiscordPlayer
    {
        [DataMember(Name ="discordUsername")]
        public string DiscordUsername { get; set; } = string.Empty;
        [DataMember(Name = "arkPlayerId")]
        public long ArkPlayerId { get; set; } = 0;
        [DataMember(Name = "arkCharacterName")]
        public string ArkCharacterName { get; set; } = string.Empty;
        [DataMember(Name = "maxRadius")]
        public float MaxRadius { get; set; } = 1;
        [DataMember(Name = "isVerified")]
        public bool IsVerified { get; set; } = false;
        [DataMember(Name = "allowResultLocation")]
        public bool ResultLocation { get; set; } = true;
        [DataMember(Name = "allowResultStats")]
        public bool ResultStats { get; set; } = false;
        [DataMember(Name = "allowMaps")]
        public bool MarkedMaps { get; set; } = true;
    }
}
