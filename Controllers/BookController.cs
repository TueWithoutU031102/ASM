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

        [Route("/")]
        public IActionResult Index()
        {
            return View(context.Books.ToList());
        }

        public IActionResult Detail(int id)
        {
            var book = context.Books.FirstOrDefault(b => b.Id == id);
            return View(book);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var categories = context.Categories.ToList();
            ViewBag.Categories = categories;
            return View();
        }

        [HttpGet]
        public IActionResult Edit()
        {
            var categories = context.Categories.ToList();
            ViewBag.Categories = categories;
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Books.Update(book);
                context.SaveChanges();
                TempData["Message"] = "Book successfully edited";
                return RedirectToAction("index");
            }
            else return View(book);
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
    }
}
