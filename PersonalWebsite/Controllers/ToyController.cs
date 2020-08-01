using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Controllers
{
    public class ToyController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult Calculator() => View();

        public IActionResult DoubleOrNothing() => View();
    }
}
