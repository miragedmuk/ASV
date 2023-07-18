using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASVBot.Data
{
    public interface IDiscordPlayer
    {
        string DiscordUsername { get; set; }
        long ArkPlayerId { get; set; }
        string ArkCharacterName { get; set; }
        float MaxRadius { get; set; }
        
        bool ResultLocation { get; set; }
        bool ResultStats { get; set; }
        bool MarkedMaps { get; set; }
        bool IsVerified { get; set; }
    }
}
