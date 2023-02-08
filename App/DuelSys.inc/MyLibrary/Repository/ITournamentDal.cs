using MyLibrary.Model;
namespace MyLibrary.Repository
{
    public interface ITournamentDal
    {
        public bool AddTournamentToDatabase(Tournament newTournament);

        public List<Tournament> GetAllTournamentsFromDB();

        public void AddMatchesToDB(Match newMatch, int tournamentID);

        public List<Match> GetMatchesBasedOnTournament(int tournamentID);
        
        public void UpdateTournament(Tournament tournament);
        
        public bool DeleteTournamentFromDB(Tournament tournament);

        public bool UpdateMatch(Match match);
    }
}