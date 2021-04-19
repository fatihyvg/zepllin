using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using zepllin.Interfaces;
using zepllin.Models;
namespace zepllin.Components.AdminComponents
{
    public class AdminImagesLoad : ViewComponent
    {
        private IDatabaseRepository<UserImages> databaselistimages;

        public AdminImagesLoad(IDatabaseRepository<UserImages> databaselistimages)
        {
            this.databaselistimages = databaselistimages;
        }
        public IViewComponentResult Invoke()
        {
            List<UserImages> imgs = new List<UserImages>();

            foreach(var item in databaselistimages.GetAllList().Where(c => c.ImageApprove == 0).ToList())
            {
                imgs.Add(new UserImages
                {
                    ImageId = item.ImageId,
                    ImageSrc = item.ImageSrc,
                    ImageTitle = item.ImageTitle
                });
            }         
            return View(imgs.AsEnumerable());
        }
    }
}
