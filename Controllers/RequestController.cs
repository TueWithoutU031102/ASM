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
                return View(context.Requests.ToList());
            }

            [HttpPost]
            public IActionResult MakeRequest(Book book, int quantity, string status)
            {
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
            }

            [Authorize(Roles = "Administrator")]
            public IActionResult RejRequest(Request request, int id)
            {
            }

        }
    }

}
*/