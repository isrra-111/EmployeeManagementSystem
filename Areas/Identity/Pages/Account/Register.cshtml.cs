using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace TCSASystem.Blazor.EmployeeManagement.Areas.Identity.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _singInManager;

        private readonly UserManager<IdentityUser> _userManager;


        public RegisterModel(SignInManager<IdentityUser> singInManager, UserManager<IdentityUser> userManager)
            {
             _singInManager = singInManager;
            _userManager = userManager; 
            
            }

        [BindProperty]


        public InputModel Input { get; set; }

       
        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var identity=new IdentityUser { UserName= Input.Email, Email=Input.Email };
                var result=await _userManager.CreateAsync(identity,Input.Password);

                if (result.Succeeded)
                {
                    await _singInManager.SignInAsync(identity, isPersistent: false);
                    return LocalRedirect("~/");
                }


            }
            return Page();
        }
    }




}
