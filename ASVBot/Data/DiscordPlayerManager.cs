using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASVBot.Data
{
    internal class DiscordPlayerManager : IDiscordPlayerManager
    {
        private List<IDiscordPlayer> discordPlayers = new List<IDiscordPlayer>();
        private List<IDiscordPlayer> deniedPlayers = new List<IDiscordPlayer>();

        private string playerFilename = Path.Combine(AppContext.BaseDirectory, "discordplayers.json");

        public DiscordPlayerManager() 
        {
            Load();
        }

        public List<IDiscordPlayer> GetPlayers()
        {
            return discordPlayers;
        }

        public void LinkPlayer(string discordUsername, long arkPlayerId, string arkCharacterName, float radius)
        {
            var discordPlayer = discordPlayers.FirstOrDefault(d=>d.DiscordUsername.ToLower() == discordUsername.ToLower());
            if(discordPlayer!=null)
            {
                discordPlayer.ArkPlayerId = arkPlayerId;
                discordPlayer.ArkCharacterName = arkCharacterName;
                discordPlayer.MaxRadius = radius;
                discordPlayer.IsVerified = false; //need to be re-verified
            }
            else
            {
                discordPlayers.Add(new DiscordPlayer()
                {
                    DiscordUsername = discordUsername,
                    ArkPlayerId = arkPlayerId,
                    ArkCharacterName = arkCharacterName,
                    MaxRadius = radius
                });
            }
        }

        public void RemovePlayer(string discordUsername)
        {
            var playerItem = discordPlayers.FirstOrDefault(d => d.DiscordUsername.ToLower() == discordUsername.ToLower());
            if (playerItem != null)
            {
                discordPlayers.Remove(playerItem);
            }

            playerItem = deniedPlayers.FirstOrDefault(d => d.DiscordUsername.ToLower() == discordUsername.ToLower());
            if (playerItem != null)
            {
                deniedPlayers.Remove(playerItem);
            }
        }

        public void DenyPlayer(string discordUsername)
        {
            var alreadyDenied =deniedPlayers.FirstOrDefault(p=>p.DiscordUsername.ToLower() == discordUsername.ToLower());
            if(alreadyDenied == null) 
            {
                deniedPlayers.Add(new DiscordPlayer()
                {
                    DiscordUsername = discordUsername,
                    ArkCharacterName=string.Empty,
                    ArkPlayerId=0,
                    IsVerified = false,
                    MarkedMaps = false,
                    MaxRadius  =0,
                    ResultLocation=false,
                    ResultStats=false
                });
            }

            var alreadyVerifiedOrPending = discordPlayers.FirstOrDefault(d => d.DiscordUsername.ToLower() == discordUsername.ToLower());
            if(alreadyVerifiedOrPending != null) 
            {
                discordPlayers.Remove(alreadyVerifiedOrPending);
            }

        }

        public void Load()
        {
            if (!File.Exists(playerFilename)) return;
            var jsonPlayers = JsonConvert.DeserializeObject<List<DiscordPlayer>>(File.ReadAllText(playerFilename));
            if (jsonPlayers != null)
            {
                discordPlayers = jsonPlayers.ToList<IDiscordPlayer>();
            }

        }

        public void Save()
        {
            try
            {
                File.WriteAllText(playerFilename, JsonConvert.SerializeObject(discordPlayers));
            }
            catch
            {

            }
            
        }

        public List<IDiscordPlayer> GetDeniedPlayers()
        {
            throw new NotImplementedException();
        }
    }
}
