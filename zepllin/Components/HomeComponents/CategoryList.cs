using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using zepllin.Interfaces;
using zepllin.Models;
namespace zepllin.Components.HomeComponents
{
    public class CategoryList : ViewComponent
    {
        private readonly IDatabaseRepository<Category> categorylist;

        private readonly IJsonCache<Category> categorycache;
        public CategoryList(IDatabaseRepository<Category> categorylist,IJsonCache<Category> categorycache)
        {
            this.categorylist = categorylist;
            this.categorycache = categorycache;
        }
        public IViewComponentResult Invoke()
        {
            List<Category> category = new List<Category>();
            foreach (var item in categorylist.GetAllList().OrderBy(o => o.CategoryName).ToList())
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
