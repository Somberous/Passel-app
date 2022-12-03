using Microsoft.AspNetCore.Mvc;

namespace Passel.Controllers
{
	public class AccountController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}