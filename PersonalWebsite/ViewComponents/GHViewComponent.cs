using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.ViewComponents
{
    public class GhViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string url)
        {
            return View(model: url);
        }
    }
}