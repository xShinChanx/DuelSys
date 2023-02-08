using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyLibrary;
using MyLibrary.Manager;
using MyLibrary.ValidationForWebiste;

namespace DuelSysWebsite.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public ValidationForRegister newPlayer { get; set; }
        private PersonManager personManager;
        public IActionResult OnGet()
        {
            try
            {
                personManager = new PersonManager(new PersonDal());
            }
            catch (DataLayerConnectionFail ex)
            {
                TempData["DataAccesFail"] = "Couldnt connect to database";
            }
            catch (Exception ex)
            {
                return Redirect("/Error");

            }
            return null;
        }

        public IActionResult OnPost()
        {
            try
            {
                personManager = new PersonManager(new PersonDal());

                if (ModelState.IsValid)
                {
                    if (!personManager.CheckIfPlayerHasUniqueEmail(personManager.ConvertToPlayer(newPlayer)))
                    {
                        TempData["RegistrationFail"] = "This email has already been taken";
                        return null;
                    }
                    if (!personManager.CreateUser(personManager.ConvertToPlayer(newPlayer)))
                    {
                        TempData["RegistrationFail"] = "Something went wrong with registration";
                        return null;
                    }
                    personManager.GetPlayers();
                    return Redirect("/LogIn");
                }
                else
                {
                    var errors = ModelState.Select(x => x.Value.Errors)
                                           .Where(y => y.Count > 0)
                                           .ToList();
                }
                return null;
            }
            catch (DataLayerConnectionFail ex)
            {
                TempData["DataAccesFail"] = "Couldnt connect to database";
            }
            catch (Exception ex)
            {
                return Redirect("/Error");
            }
            return null;

        }
    }
}
