using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NLog;
using zepllin.Interfaces;
using zepllin.Models;

namespace zepllin.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly SignInManager<CreateUsers> loginandresult;

        private readonly IDatabaseRepository<UserImages> databaserespositoryımages;

        private readonly IUserImages userimage;

        private readonly IAdminLogin adminlogin;
        public HomeController(SignInManager<CreateUsers> loginandresult, 
            IAdminLogin adminlogin, IDatabaseRepository<UserImages> databaserespositoryımages,
            IUserImages userimage)
        {
            this.loginandresult = loginandresult;
            this.adminlogin = adminlogin;
            this.databaserespositoryımages = databaserespositoryımages;
            this.userimage = userimage;
        }
        public IActionResult Index()
        {
            return View();
        }
        /*TODO HomeController Error Sayfası Yönlendirme*/
        [Route("/Error")]
        public ActionResult Error()
        {
            var error = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            var log = LogManager.GetLogger("ErrorLog");
            log.Log(LogLevel.Error, $"\nError:{error.Error.Message}\nStack Trace:{error.Error.StackTrace}\nError Path:{error.Path}");
            return View();
        }
        #region
        /*TODO HomeController NotFound Sayfası Yönlendirme*/
        public ActionResult NotFound(int code)
        {
            ViewBag.Code = code;
            return View();
        }
        #endregion
        /*TODO HomeController Erişim Engellendi Sayfası Yönlendirme*/
        [HttpGet]
        [AllowAnonymous]
        public ActionResult AccessDenied()
        {
            return View();
        }
        [HttpGet]
        public JsonResult Search(string term)
        {
            List<UserImages> usim = new List<UserImages>();
            foreach (var item in databaserespositoryımages.SpSearch(term).Where(t => t.ImageApprove  == 1).Select(r => new {
                ImageId = r.ImageId,
                ImageSrc = r.ImageSrc,
                ImageTitle = r.ImageTitle,
                ImageWithoutSeoTitle = r.ImageWithoutSeoTitle
            }).ToList())
            {
                usim.Add(new UserImages
                {
                    ImageId = item.ImageId,
                    ImageSrc = item.ImageSrc,
                    ImageTitle = item.ImageTitle,
                    ImageWithoutSeoTitle = item.ImageWithoutSeoTitle
                });
            }
            return Json(usim.AsEnumerable());
        }

    }
}
