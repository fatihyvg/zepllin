using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using zepllin.Interfaces;
using zepllin.Models;
namespace zepllin.Controllers
{
    [Route("Search")]
    public class SearchController : Controller
    {
        private readonly IDatabaseRepository<UserImages> databaseuserimage;
        public SearchController(IDatabaseRepository<UserImages> databaseuserimage)
        {
            this.databaseuserimage = databaseuserimage;
        }
        [Route("Image")]
        public ActionResult Image()
        {
            return View();
        }
        [Route("Image/{term}")]
        public ActionResult Image(string term)
        {
            List<UserImages> imgs = new List<UserImages>();
            foreach(var item in databaseuserimage.SpGetBySearchResult(term).Select(f => new {
                ImageId = f.ImageId,
                ImageTitle = f.ImageTitle,
                ImageWithoutSeoTitle = f.ImageWithoutSeoTitle,
                ImageSrc = f.ImageSrc,
                UserName = f.UserName
            }).ToList())
            {
                imgs.Add(new UserImages
                {
                    ImageId = item.ImageId,
                    ImageTitle = item.ImageTitle,
                    ImageWithoutSeoTitle = item.ImageWithoutSeoTitle,
                    ImageSrc = item.ImageSrc,
                    UserName = item.UserName
                });
                ViewData["searchresult"] = item.ImageWithoutSeoTitle;
            }
            return View(imgs.AsEnumerable());
        }
    }
}
