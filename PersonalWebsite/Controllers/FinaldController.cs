using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Controllers
{
	public class FinaldController : Controller
	{
		public IActionResult Index() => View();
		public IActionResult About() => View();
		public IActionResult Cult()  => View();
	}
}
