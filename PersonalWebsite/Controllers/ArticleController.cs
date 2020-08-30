using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult ChromeOs() => View();

        public IActionResult Jailbreak() => View();

        public IActionResult Python() => View();

        public IActionResult Powerpoint() => View();

        public IActionResult UsbBoot() => View();
    }
}
