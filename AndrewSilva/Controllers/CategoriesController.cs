using AndrewSilva.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AndrewSilva.Controllers
{
    public class CategoriesController : Controller
    {
        private static IList<Category> categoryList =
            new List<Category>() {
                new Category ( ) {categoryId=1, name = "keyboard"},
                new Category() { categoryId = 2, name = "monitor"},
                new Category() { categoryId = 3, name = "leptop"},
                new Category() { categoryId = 4, name = "mouse"},
                };
        // GET: Categories
        public ActionResult Index()
        {
            //select *
            //from categories 
            // order BY categories name
            return View(categoryList.OrderBy(c => c.name));
        }
    }
}