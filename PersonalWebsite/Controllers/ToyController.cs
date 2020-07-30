using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
