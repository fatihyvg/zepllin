using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using zepllin.Interfaces;
using zepllin.Models;
namespace zepllin.Components.HomeComponents
{
    public class Container : ViewComponent
    {
        private readonly IDatabaseRepository<UserImages> databaseimages;

        private readonly IJsonCache<UserImages> cacheimage;
        public Container(IDatabaseRepository<UserImages> databaseimages, IJsonCache<UserImages> cacheimage)
        {
            this.databaseimages = databaseimages;
            this.cacheimage = cacheimage;
        }
        public IViewComponentResult Invoke()
        {
            List<UserImages> lastphotos = new List<UserImages>();
            foreach (var item in databaseimages.GetAllList().Where(w => w.ImageApprove == 1 && w.ImageEdıtor == 1).OrderByDescending(x => x.ImageId).Take(23).ToList())
            {            
                    lastphotos.Add(new UserImages
                    {
                        ImageId = item.ImageId,
                        ImageSrc = item.ImageSrc,
                        ImageWithoutSeoTitle = item.ImageWithoutSeoTitle,
                        ImageTitle = item.ImageTitle,
                        ImageApprove = item.ImageApprove,
                        
                    });
            }
            return View(cacheimage.jsonCache(lastphotos,"lastphotos",TimeSpan.FromDays(9)));
        }
    }
}
