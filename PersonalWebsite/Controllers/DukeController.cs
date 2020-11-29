using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite.Controllers
{
	public class DukeController : Controller
	{
		public IActionResult Index() => View();
	}
}
