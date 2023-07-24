using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASVBot.Data
{
    public interface IDiscordPlayerManager
    {
        public void LinkPlayer(string discordUsername, long arkPlayerId, string arkCharacterName, float radius);
        public void RemovePlayer(string discordUsername);
        public void DenyPlayer(string discordUsername);
        public List<IDiscordPlayer> GetPlayers();
        public List<IDiscordPlayer> GetDeniedPlayers();
        public void Save();
        public void Load();
    }
}
