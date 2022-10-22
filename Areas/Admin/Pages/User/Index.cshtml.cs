using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASM.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
namespace ASM.Areas.Admin.Pages.User
{
    public class IndexModel : PageModel
    {

        private readonly UserManager<IdentityUser> _userManager;
        [TempData]
        public string StatusMessage { get; set; }
        public IndexModel(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public List<IdentityUser> users { get; set; }
        public async Task OnGet()
        {
            users = await _userManager.Users.OrderBy(u=>u.UserName).ToListAsync();
        }
        public void OnPost() => RedirectToPage();
    }
}
