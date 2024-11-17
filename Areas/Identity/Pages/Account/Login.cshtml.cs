using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace TCSASystem.Blazor.EmployeeManagement.Areas.Identity.Pages.Account
{
    public class LoginModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _singInManager;



        public LoginModel(SignInManager<IdentityUser> singInManager)
        {
            _singInManager = singInManager;
          
        }



        [BindProperty]


        public InputModel Input { get; set; }
        public void OnGet()
        {
           
        }

        public async Task<IActionResult> OnPostAsync() 
        {
            if (ModelState.IsValid)
            {
                var result = await _singInManager.PasswordSignInAsync(Input.Email, Input.Password
                    ,isPersistent:false,lockoutOnFailure:false);

                if (result.Succeeded)
                {
                    return LocalRedirect("~/");
                }


            }

            return Page();
        }
    }

    public class InputModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

}
