using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Linq;
using System.Threading.Tasks;

namespace ASM.Areas.Admin.Pages.User
{
    public class DeleteModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;
        public string StatusMessage { get; set; }
        public DeleteModel(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public IdentityUser user { get; set; }
        public async Task<IActionResult> OnGet(string id)
        {
            if (id == null) return NotFound("Not found the user");
            user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound("Not found the user");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null) return NotFound("Not found the user");
            user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound("Not found the user");
            var delete = await _userManager.DeleteAsync(user);
            if (delete.Succeeded)
            {
                StatusMessage = $"Delete {user.UserName} succeedfully!!!!";
                return RedirectToPage("./Index");
            }
            else delete.Errors.ToList().ForEach(error => ModelState.AddModelError(string.Empty, error.Description));
            return Page();
        }
    }
}
