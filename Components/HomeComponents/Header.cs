using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using zepllin.Interfaces;
using zepllin.Models;
namespace zepllin.Components.HomeComponents
{
    public class Header : ViewComponent
    {
        /*Veritabanı*/
        private readonly IDatabaseRepository<Category> categorylist;

        private readonly IJsonCache<Category> category;

        public Header(IDatabaseRepository<Category> categorylist, IJsonCache<Category> category)
        {
            this.categorylist = categorylist;
            this.category = category;
        }
        public IViewComponentResult Invoke()
        {
            #region cache yapılıyor
            List<Category> categories = new List<Category>();
            foreach (var item in categorylist.GetAllList().OrderBy(h => h.CategoryName).ToList())
            {
                categories.Add(new Category
                {
                    CategoryId = item.CategoryId,
                    CategoryName = item.CategoryName
                });
            }

            return View(category.jsonCache(categories,"category",TimeSpan.FromDays(365)));
        }
        #endregion
    }
}
