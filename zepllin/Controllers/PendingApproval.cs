using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using zepllin.Interfaces;
using zepllin.Models;
namespace zepllin.Controllers
{
    [Authorize]
    [Route("PendingApproval")]
    public class PendingApproval : Controller
    {
        private readonly IDatabaseRepository<UserImages> pendingapproval;
        public PendingApproval(IDatabaseRepository<UserImages> pendingapproval)
        {
            this.pendingapproval = pendingapproval;
        }
        [Route("PendApproval")]
        public ActionResult PendApproval()
        {
            return View();
        }
        [Route("PendApproval/{UserNormalId:int}")]
        public ActionResult PendApproval(int UserNormalId)
        {
            List<UserImages> pendapp = new List<UserImages>();
            foreach (var item in pendingapproval.SpPendingApproval(UserNormalId).Where(c => c.ImageApprove == 0).ToList())
            {
                pendapp.Add(new UserImages
                {
                    UserName = item.UserName,
                    ImageApprove = item.ImageApprove,
                    ImageSrc = item.ImageSrc,
                });
                ViewData["pendusername"] = item.UserName;
            }
            return View(pendapp.AsEnumerable());
        }
    }
}
