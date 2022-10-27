using ASM.Data;
using ASM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace ASM.Controllers
{
    public class OrderController : Controller
    {
        protected ApplicationDbContext context;

        public OrderController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public IActionResult MakeOrder(int id)
        {
            var order = new Order();
            order.Id = id;
            order.OrderDate = DateTime.Now;
            order.Customer = User.Identity.Name;
            order.BookTitle = context.Books.ToList().Last().Title;
            order.Price = context.Books.ToList().Last().Price;
            context.Orders.Add(order);
            context.SaveChanges();
            return View();
        }

        public IActionResult ViewOrder()
        {
            return View(context.Orders.ToList());
        }
    }
}
