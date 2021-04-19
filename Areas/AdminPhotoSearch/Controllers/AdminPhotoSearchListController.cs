using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using zepllin.Interfaces;
using zepllin.Models;
namespace zepllin.Areas.AdminPhotoSearch.Controllers
{
    [Area("AdminPhotoSearch")]
    [Route("AdminPhotoSearchList")]
    [Authorize(Roles = "Admin,Manager")]
    public class AdminPhotoSearchListController : Controller
    {
        private readonly IDatabaseRepository<UserImages> admindatuserimage;
        public AdminPhotoSearchListController(IDatabaseRepository<UserImages> admindatuserimage)
        {
            this.admindatuserimage = admindatuserimage;
        }
        public ActionResult Index()
        {
            return View();
        }
        [Route("Index/{term}")]
        public ActionResult Index(string term)
        {
            List<UserImages> adminimage = new List<UserImages>();
            foreach (var item in admindatuserimage.SpGetBySearchResult(term).Select(f => new
            {
                ImageId = f.ImageId,
                ImageTitle = f.ImageTitle,
                ImageWithoutSeoTitle = f.ImageWithoutSeoTitle,
                ImageSrc = f.ImageSrc
            }).ToList())
            {
                adminimage.Add(new UserImages
                {
                    ImageId = item.ImageId,
                    ImageTitle = item.ImageTitle,
                    ImageWithoutSeoTitle = item.ImageWithoutSeoTitle,
                    ImageSrc = item.ImageSrc
                });
            }
            return View(adminimage.AsEnumerable());
        }
    }
}
