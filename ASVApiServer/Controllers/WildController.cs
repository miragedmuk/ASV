using ASVApiServer.Models;
using ASVPack.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASVApiServer.Controllers
{
    public class WildController : ControllerBase
    {
        //Wild creatures
        [HttpGet]
        public List<WildSummaryModel> GetSummary()
        {
            var summary = new List<WildSummaryModel>();  




            return summary;
        }

        [HttpGet]
        public List<ContentWildCreature> GetData(int minLevel, int maxLevel, decimal srcLat, decimal srcLon, decimal srcRad, string className, string realmName, string resourceClass) 
        {
        
            var returnList = new List<ContentWildCreature>();




            return returnList;
        } 

    }
}
