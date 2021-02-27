using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.ViewComponents
{
	public class PageLinkViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync(
			string title,
			string controller,
			string page)
		{
			return View(new [] {title, controller, page});
		}
	}
}