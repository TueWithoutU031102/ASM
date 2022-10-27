using ASM.Data;
using ASM.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace ASM.Controllers
{
    public class OrderController : Controller
    {
        protected ApplicationDbContext context;

        public OrderController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult MakeOrder(string Title, int book )
        {
            var order = new Order();
            order.BookId = book;
            order.OrderDate = DateTime.Now;
            order.Name = Title;
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
