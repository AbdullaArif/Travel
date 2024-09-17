using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Travel.Models;

namespace Travel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Index calling");
            return View();
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation("Privacy page calling");

            return View();
        }
        public IActionResult Test()
        {
            _logger.LogInformation("Test page calling");

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
