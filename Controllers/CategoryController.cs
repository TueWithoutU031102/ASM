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
                context.Add(category);
                context.SaveChanges();
                TempData["Message"] = "Add a new category successfully!!!!!!";
                return RedirectToAction("index");
            }
            else return View(category);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();
            else
            {
                var cate = context.Categories.Find(id);
                context.Categories.Remove(cate);
                context.SaveChanges();
                return RedirectToAction("index");
            }
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            Category cate = context.Categories.Single(c => c.Id == id);
            return View(cate);
        }

        [HttpPost]
        public IActionResult Edit(Category cate)
        {
            if (ModelState.IsValid)
            {
                context.Entry(cate).State = EntityState.Modified;
                context.SaveChanges();
                TempData["Message"] = "Category Has Been Change Successfully!!!!!!";
                return RedirectToAction("index");
            }
            else return View(cate);
        }

    }
}
