using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyLibrary;
using MyLibrary.Manager;
using MyLibrary.Model;
using MyLibrary.ValidationForWebiste;
using System.Security.Claims;

namespace DuelSysWebsite
{
    public class LogInModel : PageModel
    {
        [BindProperty]
        public ValidationForLogin playerLogin { get; set; }

        public PersonManager personManager;
        public Player playerForCookies;
        public int playerID;

        public IActionResult OnGet()
        {
            try
            {
                personManager = new PersonManager(new PersonDal());
                playerForCookies = new Player();
            }
            catch(DataLayerConnectionFail ex)
            {
                TempData["DataAccesFail"] = "Couldnt connect to database";
            }
            catch (Exception)
            {
                return Redirect("/Error");
            }
            return null;
        }

        public IActionResult OnPost()
        {
            try
            {
                if (ModelState.IsValid)
                {
                    personManager = new PersonManager(new PersonDal());
                    playerForCookies = personManager.CheckIfPlayer(playerLogin);
                    if (playerForCookies == null)
                    {
                        TempData["LogInFail"] = "Please type in the right credentials";
                        return null;
                    }
                    AddCookie(playerForCookies.Id);
                    playerID = Convert.ToInt32(User.Identity.Name);
                    return Redirect("/Index");
                }
                else
                {
                    {
                        var errors = ModelState.Select(x => x.Value.Errors)
                                               .Where(y => y.Count > 0)
                                               .ToList();
                    }
                }
            }
            catch (DataLayerConnectionFail ex)
            {
                TempData["DataAccesFail"] = "Couldnt connect to database";
            }
            catch (Exception)
            {
                return Redirect("/Error");
            }
            return null;
        }

        public void AddCookie(int userID)
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, userID.ToString()));
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            HttpContext.SignInAsync(claimsPrincipal);
        }
    }
}
