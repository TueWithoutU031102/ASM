/*using Microsoft.AspNetCore.Mvc;
namespace ASM.Controllers
{
    using ASM.Data;
    using ASM.Models;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;
    using System.Reflection.Metadata.Ecma335;

    namespace BookStore.Controllers
    {
        public class RequestController : Controller
        {
            protected readonly ApplicationDbContext context;
            public RequestController(ApplicationDbContext context)
            {
                this.context = context;
            }
            [HttpGet]
            public IActionResult MakeRequest()
            {
*//*                return View(context.Requests.ToList());*//*
            }
            [HttpPost]
            public IActionResult MakeRequest(Book book, int quantity, string status)
            {
                var MakeReq = new Request();

                MakeReq.Name = book.Name;
                MakeReq.RequestDate = DateTime.Now;
                MakeReq.Quantity = quantity;
                MakeReq.Status = status;
                MakeReq.Accepted = status;
                MakeReq.BookID = book.Id;
                context.Requests.Add(MakeReq);
                context.SaveChanges();
                return View(context.Requests.ToList());
            }
            [HttpGet]
            public IActionResult AcpRequest()
            {
                return View();
            }
            [HttpPost]
            [Authorize(Roles = "Administrator")]
            public IActionResult AcpRequest(Request request, int id, int bookId, int quantity)
            {
                var req = context.Requests
                      .FirstOrDefault(x => x.Id == id);
                req.Status = "accepted";
                var book = context.Books.FirstOrDefault(x => x.Id == bookId);
                book.Quantity += quantity;
                context.Books.Update(book);
                context.Requests.Update(req);
                context.Books.Update(book);
                context.SaveChanges();
                return RedirectToAction("MakeRequest");
            }
            [Authorize(Roles = "Administrator")]
            public IActionResult RejRequest(Request request, int id)
            {
                var req = context.Requests
                     .FirstOrDefault(x => x.Id == id);
                req.Status = "rejected";
                context.Requests.Update(req);
                context.SaveChanges();
                return RedirectToAction("MakeRequest");

            }

        }
    }

}
*/