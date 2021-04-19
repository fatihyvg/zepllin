using Microsoft.AspNetCore.Mvc;
namespace zepllin.Components.HomeComponents
{
    public class Footer : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
