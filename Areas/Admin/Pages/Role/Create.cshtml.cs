using ASM.Areas.Admin.Pages.Role;
using ASM.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
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
            [Display(Name = "Name roless")]
            [Required(ErrorMessage ="Must input {0}")]
            [StringLength(256,MinimumLength = 3, ErrorMessage ="{0} must length max is {1} and min is {2}")]
            string Name { get; set; }
        }

        public InputModel Input { get; set; }
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsysc()
        {
            var newRole = new IdentityRole("Name role");
            await roleManager.CreateAsync(newRole);
            return Page();
        }
    }
}
