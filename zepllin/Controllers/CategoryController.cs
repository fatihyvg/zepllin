using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using zepllin.Interfaces;
using zepllin.Models;
namespace zepllin.Controllers
{
    [Route("Category")]
    public class CategoryController : Controller
    {
        private readonly IDatabaseRepository<UserImages> usimages;

        private readonly IDatabaseRepository<Category> categoryrepository;

        private readonly ICategory category;
        public CategoryController(IDatabaseRepository<UserImages> usimages,
            IDatabaseRepository<Category> categoryrepository,
            ICategory category)
        {
            this.usimages = usimages;
            this.category = category;
            this.categoryrepository = categoryrepository;
        }
        public ActionResult List()
        {
            return View();
        }
        [Route("List/{CategoryFk:int}")]
        public ActionResult List(int CategoryFk)
        {
            List<UserImages> byccategoryimage = new List<UserImages>();
            category.CategoryId = CategoryFk;
            foreach (var item in usimages.SpGetByCategory(category.CategoryId).ToList())
            {
                    byccategoryimage.Add(new UserImages
                    {
                        ImageId = item.ImageId,
                        ImageSrc = item.ImageSrc,
                        ImageTitle = item.ImageTitle,
                        ImageWithoutSeoTitle = item.ImageWithoutSeoTitle
                    });
            }
            foreach(var categoryitem in categoryrepository.GetAllList().Where(c => c.CategoryId == category.CategoryId).ToList())
            {
                ViewData["categorytitle"] = categoryitem.CategoryName;
            }

            return View(byccategoryimage.AsEnumerable());
        }
    }
}
