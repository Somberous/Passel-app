using Microsoft.AspNetCore.Mvc;
using Passel.Models;

namespace Passel.Controllers
{
	public class MediaController : Controller
	{
		// Create the database context
		private readonly PasselContext _context;

		public MediaController(PasselContext context)
		{
			_context = context;
		}

		public IActionResult Index() => RedirectToAction("List");
		// get the list of changes
		public IActionResult List()
		{
			var vm = new MediaViewModel
			{
				Medias = _context.Medias
			};
			return View(vm);
		}
	}
}