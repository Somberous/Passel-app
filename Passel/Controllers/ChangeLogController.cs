using Microsoft.AspNetCore.Mvc;
using Passel.Models;

namespace Passel.Controllers
{
	public class ChangeLogController : Controller
	{
		// Create the database context
		private readonly PasselContext _context;

		public ChangeLogController(PasselContext context)
		{
			_context = context;
		}

		public IActionResult Index() => RedirectToAction("List");
		// get the list of changes
		public IActionResult List()
		{
			var vm = new ChangeLogViewModel
			{
				Changes = _context.Changes
			};
			return View(vm);
		}
	}
}