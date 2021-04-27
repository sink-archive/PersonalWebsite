using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Anilist4Net() => View();
        
        public IActionResult DiscordModding() => View();
        
        public IActionResult ExType() => View();
        
        public IActionResult Gord() => View();
        
        public IActionResult Reggie() => View();
                
        public IActionResult RunPlusPlus() => View();

        public IActionResult SourceMapInstaller() => View();

        public IActionResult UnityGames() => View();

        public IActionResult YtdlGui() => View();
    }
}
