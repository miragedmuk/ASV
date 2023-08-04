using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

        public void Save()
        {
            string configFilename = Path.Combine(AppContext.BaseDirectory, "botconfig.json");
            File.WriteAllText(configFilename,JsonConvert.SerializeObject(this));
        }
        public void Load()
        {
            string configFilename = Path.Combine(AppContext.BaseDirectory, "botconfig.json");
            if(File.Exists(configFilename))
            {
                var configFileData = File.ReadAllText(configFilename);
                var config = JsonConvert.DeserializeObject<BotConfig>(configFileData) ?? new BotConfig();

                this.ArkSaveFile = config.ArkSaveFile;
                this.ArkClusterFolder = config.ArkClusterFolder;
                this.AutoReloadTimeMinutes = config.AutoReloadTimeMinutes;
                this.DiscordBotToken = config.DiscordBotToken;
                this.DiscordServerId = config.DiscordServerId;

            }
        }



    }
}
