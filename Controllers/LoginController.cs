using ASM.Data;
using ASM.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ASM.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext context;
        public LoginController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [Route("/Login")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/Register")]
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
    }
}
