using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.Classes;
using PersonalWebsite.Models;

namespace PersonalWebsite.Controllers
{
	public class LinksController : Controller
	{
		public static Dictionary<string, AccountLink> AccountLinks = new Dictionary<string, AccountLink>
		{
			{"Youtube", new AccountLink("//www.youtube.com/channel/UCQ_ZGydjNeSHNbdo_m6uUcQ", null, "//upload.wikimedia.org/wikipedia/commons/b/b8/YouTube_Logo_2017.svg")},
			{"Steam", new AccountLink("//steamcommunity.com/id/Yellosink/", null, "//upload.wikimedia.org/wikipedia/commons/a/ae/Steam_logo.svg")},
			{"Discord", new AccountLink(null, "Yellowsink#8156", "//upload.wikimedia.org/wikipedia/en/thumb/9/98/Discord_logo.svg/1280px-Discord_logo.svg.png", true)},
			{"Twitter", new AccountLink("//twitter.com/CainAtkin", null, "//upload.wikimedia.org/wikipedia/en/thumb/9/9f/Twitter_bird_logo_2012.svg/1259px-Twitter_bird_logo_2012.svg.png")},
			{"Reddit", new AccountLink("//www.reddit.com/user/Yellosink", null, "//upload.wikimedia.org/wikipedia/en/thumb/5/58/Reddit_logo_new.svg/1280px-Reddit_logo_new.svg.png")},
			{"osu!", new AccountLink("//osu.ppy.sh/u/Yellowsink", null, "//upload.wikimedia.org/wikipedia/commons/thumb/6/65/Osu%21Logo_%282015%29.svg/1080px-Osu%21Logo_%282015%29.svg.png")}
		};

		public IActionResult Index()
		{
			return View(new LinksIndexViewModel
			{
				AccountLinks = AccountLinks
			});
		}
	}
}