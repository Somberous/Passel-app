using Microsoft.AspNetCore.Mvc;

namespace Passel.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public ActionResult YourFeed()
		{
			return View();
		}

		public ActionResult ChangeLog()
		{
			return View();
		}

		public ActionResult Application()
		{
			return View();
		}

	}
}
