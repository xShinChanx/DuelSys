using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DuelSysWebsite.Pages
{
    public class LogOutModel : PageModel
    {
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            try
            {
                await HttpContext.SignOutAsync();
                return RedirectToPage("/Index");
            }
            catch (Exception ex)
            {
                return RedirectToPage("/Error");
            }

        }
    }
}
