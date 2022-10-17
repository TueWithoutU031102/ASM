using ASM.Data;
using ASM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ASM.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext context;
        public CategoryController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.Categories.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                context.Categories.Add(category);
                context.SaveChanges();
                TempData["Message"] = "Add a new category successfully!!!!!!";
                return RedirectToAction("index");
            }
            else return View(category);
        }

    }
}
