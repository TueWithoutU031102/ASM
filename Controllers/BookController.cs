using ASM.Data;
using ASM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ASM.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext context;
        public BookController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [Route("/Book")]
        public IActionResult Index()
        {
            return View(context.Books.ToList());
        }
        
        public IActionResult Detail(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var book = context.Books.Include(c => c.Category).FirstOrDefault(b => b.Id == id);
            return View(book);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var categories = context.Categories.ToList();
            ViewBag.Categories = categories;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Books.Add(book);
                context.SaveChanges();
                TempData["Message"] = "Add a new book successfully!!!!!!";
                return RedirectToAction("index");
            }
            else return View(book);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();
            else
            {
                var book = context.Books.Find(id);
                context.Books.Remove(book);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            Book b = context.Books.Single(x => x.Id == id);
            return View(b);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Entry(book).State = EntityState.Modified;
                context.SaveChanges();
                TempData["Message"] = "Book Has Been Change Successfully!!!!!!";
                return RedirectToAction("index");
            }
            else return View(book);
        }
    }
}
