using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using zepllin.Interfaces;
using zepllin.Models;

namespace zepllin.Components.ProfileComponents
{
    public class UploadImage : ViewComponent
    {
        private readonly IDatabaseRepository<Category> databasecategory;

        private readonly IJsonCache<Category> categorycache;
        public UploadImage(IDatabaseRepository<Category> databasecategory, IJsonCache<Category> categorycache)
        {
            this.databasecategory = databasecategory;
            this.categorycache = categorycache;
        }
        public IViewComponentResult Invoke()
        {
            List<Category> category = new List<Category>();
            foreach(var item in databasecategory.GetAllList().ToList())
            {
                category.Add(new Category
                {
                    CategoryId = item.CategoryId,
                    CategoryName = item.CategoryName
                });
            }           
            return View(categorycache.jsonCache(category,"category",TimeSpan.FromDays(365)));
        }
    }
}
