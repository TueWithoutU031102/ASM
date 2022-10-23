using ASM.Data;
using ASM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;

namespace ASM.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            var cate = context.Categories.ToList();
            var book = context.Books.ToList();
            ViewBag.Cates = cate;
            ViewBag.Books = book;
            return View();
        }

        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();
            var book = context.Books.Include(c => c.Category).FirstOrDefault(b => b.Id == id);
            return View(book);
        }
        
        public IActionResult Category(int? id)
        {

            if (id == null) return NotFound();
            var cate = context.Categories.ToList();
            var book = context.Books.Where(b => b.CategoryId == id).ToList();
            ViewBag.Books = book;
            ViewBag.Cates = cate;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
