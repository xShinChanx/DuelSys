using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyLibrary;
using MyLibrary.Manager;

namespace DuelSysWebsite.Pages
{
    public class TournamentModel : PageModel
    {
        public TournamentManager tournamentManager;
        public PersonManager personManager;
        public IActionResult OnGet()
        {
            try
            {
                personManager = new PersonManager(new PersonDal());
                tournamentManager = new TournamentManager(new TournamentDal());
            }
            catch(DataLayerConnectionFail ex)
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
