using ASM.Areas.Admin.Pages.Role;
using ASM.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASM.Areas.Admin.Pages.Role
{
    public class CreateModel : RolePageModel
    {
        public CreateModel(RoleManager<IdentityRole> roleManager, ApplicationDbContext context) : base(roleManager, context)
        {
        }
        public class InputModel
        {
            [Display(Name = "Name roles")]
            [Required(ErrorMessage = "Must input {0}")]
            [StringLength(256, MinimumLength = 3, ErrorMessage = "{0} must length max is {1} and min is {2}")]
            public string Name { get; set; }
        }
        [BindProperty]
        public InputModel Input { set; get; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsysc()
        {

            var newRole = new IdentityRole(Input.Name);
            var result = await roleManager.CreateAsync(newRole);

            if (result.Succeeded)
            {
                StatusMessage = $"Create a new role {Input.Name} successfully!!!";
                return RedirectToPage("/admin/roles");
            }
            else result.Errors.ToList().ForEach(error => ModelState.AddModelError(string.Empty, error.Description));
            return Page();
        }
    }
}
