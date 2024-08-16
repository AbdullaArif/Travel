using Microsoft.AspNetCore.Mvc;

namespace Travel.Areas.Member.Controllers
{
	public class MessageController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
