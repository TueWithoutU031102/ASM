using ASM.Data;
using ASM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            var categories = context.Categories.Include(b => b.Books).FirstOrDefault(c => c.Id == id);
            return View(categories);
        }

        public IActionResult Info(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = context.Categories.Include(c => c.Books).FirstOrDefault(c => c.Id == id);
            return View(category);
        }
        [HttpGet]
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
