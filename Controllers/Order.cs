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
            return View();
        }
    }
}
