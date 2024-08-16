using Microsoft.AspNetCore.Mvc;

namespace Travel.Areas.Member.Controllers
{
	public class ProfileController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
