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
            if (discordPlayers.LongCount(d => d.DiscordUsername.ToLower() == discordUsername.ToLower()) > 0)
            {
                var playerItem = discordPlayers.First(d => d.DiscordUsername.ToLower() == discordUsername.ToLower());
                if (playerItem != null)
                {
                    discordPlayers.Remove(playerItem);
                }
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
    }
}
