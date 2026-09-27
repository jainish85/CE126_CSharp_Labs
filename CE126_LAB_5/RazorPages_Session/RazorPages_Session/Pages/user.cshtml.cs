using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages_Session.Pages.User
{
    public class UserModel : PageModel
    {
        [BindProperty]
        public string? Name { get; set; }

        [BindProperty]
        public string? Email { get; set; }

        [BindProperty]
        public string? ContactNo { get; set; }

        [BindProperty]
        public string? Gender { get; set; }

        public IActionResult OnPost()
        {
         
            HttpContext.Session.SetString("Name", Name);
            HttpContext.Session.SetString("Email", Email);
            HttpContext.Session.SetString("ContactNo", ContactNo);
            HttpContext.Session.SetString("Gender", Gender);

            return RedirectToPage("/result");
        }
    }
}