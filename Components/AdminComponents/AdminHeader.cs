using Microsoft.AspNetCore.Mvc;
namespace zepllin.Areas.Admin.Components.AdminHeader
{
    public class AdminHeader : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
