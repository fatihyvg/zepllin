using Microsoft.AspNetCore.Mvc;
namespace zepllin.Components.ImageComponents
{
    public class ImageContainer : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
