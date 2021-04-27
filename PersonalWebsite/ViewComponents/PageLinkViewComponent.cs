using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.ViewComponents
{
	public class PageLinkViewComponent : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync(
			string title,
			string controller,
			string page,
			string subtitle)
		{
			return View(string.IsNullOrWhiteSpace(subtitle)
				? new [] {title, controller, page}
				: new [] {title, controller, page, subtitle});
		}
	}
}