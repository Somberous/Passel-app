using Microsoft.AspNetCore.Mvc;

namespace Passel.Controllers
{
	public class FeedController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}