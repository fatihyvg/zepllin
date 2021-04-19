using Microsoft.AspNetCore.Mvc;
namespace zepllin.Components.ProfileComponents
{
    public class ProfileHeader : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
