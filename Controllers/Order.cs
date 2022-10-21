using ASM.Data;
using ASM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ASM.Controllers
{
    public class Order : Controller
    {

        public IActionResult Index()
        {
            var orders = db.Orders.Include(o => o.Staff);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
