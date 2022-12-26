using Microsoft.AspNetCore.Mvc;

namespace ASVApiServer.Controllers
{
    public class PlayerController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
