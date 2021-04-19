using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using zepllin.Interfaces;
using zepllin.Models;
namespace zepllin.Areas.AdminCategory.Controllers
{
    [Area("AdminCategory")]
    [Authorize(Roles = "Admin")]
    public class AdminCategoryCreateController : Controller
    {

        private readonly IDatabaseRepository<Category> categoryresulter;

        private readonly IJsonCache<Category> jsoncache;
        public AdminCategoryCreateController(IDatabaseRepository<Category> categoryresulter,IJsonCache<Category> jsoncache)
        {
            this.categoryresulter = categoryresulter;
            this.jsoncache = jsoncache;
        }
        /*TODO Kategorileri Getirme*/
        public ActionResult Index()
        {
            List<Category> categories = new List<Category>();
            foreach(var item in categoryresulter.GetAllList().ToList())
            {
                categories.Add(new Category
                {
                    CategoryId = item.CategoryId,
                    CategoryName = item.CategoryName
                });
            }
            
            return View(jsoncache.jsonCache(categories,"category",TimeSpan.FromDays(365)));
        }
        /*TODO Kategori Oluştur*/
        [HttpPost]
        public ActionResult CreateCategory(string category)
        {
            ICategory categoryresult = new Category();
            if (category != null)
            {
                categoryresult.CategoryName = category;
                categoryresulter.InsertToDatabase((Category)categoryresult);
                categoryresulter.Save();
            }     
            return Content(string.Empty);
        }
        /*TODO Kategori Sil*/
        [HttpPost]
        public ActionResult DeleteCategory(int delid)
        {
            if (ModelState.IsValid)
            {
                categoryresulter.DeleteFromDatabase(delid);
                categoryresulter.Save();
                return Content(string.Empty);
            }
            return Content(string.Empty);
        }
    }
}
