﻿using ASM.Data;
using ASM.Models;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult ListBook()
        {
            return View(context.Books.ToList());
        }

        /*public IActionResult Detail(int id)
        {
            var book = context.Books
        }*/

        /*[HttpGet]
        public IActionResult Create()
        {

        }*/

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Books.Add(book);
                context.SaveChanges();
                TempData["Message"] = "Add a new book successfully!!!!!!";
                return RedirectToAction("Index");
            }
            else return View(book);
        }
    }
}
