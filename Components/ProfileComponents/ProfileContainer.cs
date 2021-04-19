using Microsoft.AspNetCore.Mvc;
namespace zepllin.Components.ProfileComponents
{
    public class ProfileContainer : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
