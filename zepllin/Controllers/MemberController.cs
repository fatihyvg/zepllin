using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using zepllin.Interfaces;
using zepllin.Models;
namespace zepllin.Controllers
{
    [Route("Member")]
    public class MemberController : Controller
    {
        private readonly IDatabaseRepository<UserImages> userimage;

        private readonly IUserImages usimage;
        public MemberController(IDatabaseRepository<UserImages> userimage,IUserImages usimage)
        {
            this.userimage = userimage;
            this.usimage = usimage;
        }
        public ActionResult Images()
        {
           
            return View();
        }
        [Route("Images/{username}")]
        public ActionResult Images(string username)
        {
            usimage.UserName = username;
            List<UserImages> listimage = new List<UserImages>();
            foreach (var item in userimage.SpGetUserByFetch(usimage.UserName).Where(r => r.ImageApprove == 1).Select(t => new { 
                ImageId = t.ImageId,
                ImageTitle = t.ImageTitle,
                ImageSrc = t.ImageSrc,
                UserName = t.UserName,
                ImageWithoutSeoTitle = t.ImageWithoutSeoTitle
            }).ToList())
            {
                listimage.Add(new UserImages
                {
                    ImageId = item.ImageId,
                    ImageTitle = item.ImageTitle,
                    ImageSrc = item.ImageSrc,
                    UserName = item.UserName,
                    ImageWithoutSeoTitle = item.ImageWithoutSeoTitle 
                });
                ViewBag.User = item.UserName;
            }
            return View(listimage.AsEnumerable());
        }
    }
}
