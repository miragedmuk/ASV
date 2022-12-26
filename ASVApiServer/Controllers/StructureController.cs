using Microsoft.AspNetCore.Mvc;

namespace ASVApiServer.Controllers
{
    //Player placed stuctures
    public class StructureController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
