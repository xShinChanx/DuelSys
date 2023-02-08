using MyLibrary.Manager;
using MyLibrary.Model;

namespace MyLibrary.Repository
{
    public interface IPersonDal
    {
        public List<Player> GetPlayersFromDB();

        public bool AddPlayerToDB(Player newPlayer);

        public bool AddStaffToDB(Staff newStaff);

        public void RegisterPlayerToTournament(Player player, int tournamentID);

        public List<Player> GetTournament(int tournamentID);

        public List<Player> GetTop3FromTournament(int tournamentID, PersonManager personManager);

        public List<Player> GetRankingOfplayerInTournament(int tournamentID, PersonManager personManager);

        public List<Staff> GetAllStaff();
    }
}