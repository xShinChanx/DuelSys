using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyLibrary;
using MyLibrary.Manager;
using MyLibrary.Model;

namespace DuelSysWebsite.Pages
{
    [Authorize]

    public class SelectedTournamentModel : PageModel
    {
        public TournamentManager tournamentManager;
        public Tournament selectedTournament;
        public PersonManager personManager;
        public Player currentPlayer = new Player();
        public int i = 1;

        public IActionResult OnGet(int id)
        {
            try
            {
                tournamentManager = new TournamentManager(new TournamentDal());
                selectedTournament = new Tournament();
                personManager = new PersonManager(new PersonDal());

                currentPlayer = personManager.GetPlayer(Convert.ToInt32(User.Identity.Name));
                personManager.GetTournamentListBasedOnID(id);
                selectedTournament = tournamentManager.GetTournament(id);
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

        public IActionResult OnPostRegisterTournament(int id)
        {
            try
            {
                tournamentManager = new TournamentManager(new TournamentDal());
                selectedTournament = new Tournament();
                personManager = new PersonManager(new PersonDal());

                currentPlayer = personManager.GetPlayer(Convert.ToInt32(User.Identity.Name));
                personManager.RegisterPlayerToTournament(currentPlayer, id);
                personManager.GetTournamentListBasedOnID(id);
                return RedirectToPage("/Tournament");
            }
            catch(DataLayerConnectionFail ex)
            {
                TempData["DataAccesFail"] = "Couldnt connect to database";
            }
            catch (Exception ex)
            {
                return RedirectToPage("/Error");
            }
            return null;
        }
    }
}
