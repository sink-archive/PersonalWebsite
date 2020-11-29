using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Controllers
{
	public class DukeController : Controller
	{
		public IActionResult Index() => View();
	}
}
