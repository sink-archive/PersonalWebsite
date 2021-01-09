using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Controllers
{
	public class CsharpController : Controller
	{
		public IActionResult Index() => View();

		// GET
		public IActionResult Operators() => View();

		public IActionResult Pgp() => View();
	}
}