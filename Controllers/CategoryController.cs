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
        public IActionResult Search(string keyword)
        {
            var category = context.Categories.Where(c => c.CategoryName.Contains(keyword)).ToList();
            if (category.Count == 0)
            {
                TempData["Message"] = "No book with this name can be found !";
            }
            return View("Index", category);
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

       //[HttpPost]
       // public IActionResult Search(string keyword)
       //{
       //var categories = context.Categories.Where(c => c.CategoryName.Contains(keyword)).ToList();
       //if (categories.Count == 0)
       //{
       //   TempData["Message"] = "No category found !";
       // }
       //   return View("index", categories);
       // }

        [HttpPost]
        public IActionResult SearchBook(string keyword)
        {
            var books = context.Books.Where(b => b.Title.Contains(keyword)).ToList();
            if (books.Count == 0)
            {
                TempData["Message"] = "No book found !";
            }
            return View("detail", books);
        }

        [HttpPost]
        public IActionResult SearchCategory(string keyword)
        {
            var categories = context.Categories.Where(c => c.CategoryName.Contains(keyword)).ToList();
            if (categories.Count == 0)
            {
                TempData["Message"] = "No categories found !";
            }
            return View("detail", categories);
        }
        public IActionResult SortNameAsc()
        {
            return View("index", context.Categories.OrderBy(c => c.CategoryName).ToList());
        }

        public IActionResult SortNameDesc()
        {
            return View("index", context.Categories.OrderByDescending(c => c.CategoryName).ToList());
        }
    }
}
