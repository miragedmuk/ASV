using ASVApiServer.Models;
using ASVPack.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace ASVApiServer.Controllers
{
    public class TribeController : ControllerBase
    {
        [HttpGet]
        public List<TribeSummaryModel> GetSummary()
        {
            var summary = new List<TribeSummaryModel>();




            return summary;
        }

        [HttpGet]
        [Route("")]
        public List<PlayerDataModel> GetPlayers()
        {

            var players = new List<PlayerDataModel>();

            return players;
        }


    }
}
