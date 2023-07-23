using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ASVBot.Config
{

    [DataContract]
    public class BotConfig
    {
        [DataMember(Name = "arkSaveFile")]
        public string ArkSaveFile { get; set; } = string.Empty;

        [DataMember(Name = "arkClusterFolder")]
        public string ArkClusterFolder { get; set; } = string.Empty;

        [DataMember(Name = "discordBotToken")]
        public string DiscordBotToken { get; set; } = string.Empty;

        [DataMember(Name = "discordServerId")]
        public long DiscordServerId { get; set; } = 0;

        [DataMember(Name ="reloadCheckMins")]
        public int AutoReloadTimeMinutes{ get; set; } = 5;

    }
}
