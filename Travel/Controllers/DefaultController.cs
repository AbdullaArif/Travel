using Microsoft.AspNetCore.Mvc;

namespace Travel.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
