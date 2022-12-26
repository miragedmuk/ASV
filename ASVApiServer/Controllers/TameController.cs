using Microsoft.AspNetCore.Mvc;

namespace ASVApiServer.Controllers
{
    public class TameController : ControllerBase
    {
        //Tamed creatures
        public IActionResult Index()
        {
            return View();
        }
    }
}
