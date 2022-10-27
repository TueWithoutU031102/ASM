using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public class UserAndRole : IdentityUser
        {
            public string RoleNames { get; set; }
        }
        public List<UserAndRole> users { get; set; }
        public int totalUsers { get; set; }
        public async Task OnGet()
        {

            var qr = _userManager.Users.OrderBy(u => u.UserName);
            totalUsers = await qr.CountAsync();
            var qr1 = qr.Select(u => new UserAndRole()
            {
                Id = u.Id,
                UserName = u.UserName,
            });
            users = await qr1.ToListAsync();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                user.RoleNames = string.Join(",", roles);
            }
        }
        public void OnPost()
        {
        }
    }
}
