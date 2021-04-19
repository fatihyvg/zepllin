using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using zepllin.Interfaces;
using zepllin.Models;
namespace zepllin.Components.AdminComponents
{
    public class AdminHomeImages : ViewComponent
    {
        private IDatabaseRepository<UserImages> userimages;
        public AdminHomeImages(IDatabaseRepository<UserImages> userimages)
        {
            this.userimages = userimages;
        }
        public IViewComponentResult Invoke()
        {
            List<UserImages> homeimages = new List<UserImages>();
            foreach(var item in userimages.GetAllList().Where(c => c.ImageEdıtor == 1).ToList())
            {
                homeimages.Add(new UserImages
                { 
                    ImageId = item.ImageId,
                    ImageSrc = item.ImageSrc
                });
            }
            return View(homeimages.AsEnumerable());
        }
    }
}
