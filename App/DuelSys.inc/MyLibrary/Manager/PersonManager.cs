using MyLibrary.Model;
using MyLibrary.Repository;
using MyLibrary.ValidationForWebiste;

namespace MyLibrary.Manager
{
    public class PersonManager
    {
        private readonly IPersonDal _personRepository;

        public List<Player> listOfPlayers = new List<Player>();
        public List<Player> listOfPlayerInTournament = new List<Player>();
        private Hasher hasher = new Hasher();

        public PersonManager(IPersonDal personRepository)
        {
            _personRepository = personRepository;
            GetPlayers();
        }

        public Player CheckIfPlayer(ValidationForLogin player)
        {
            foreach (Player p in listOfPlayers)
            {
                if (p.Email == player.Email && hasher.Verify(player.Password, p.Password))
                {
                    return p;
                }
            }
            return null;
        }

        public bool CheckIfStaff(string username, string password)
        {
            foreach (Staff s in _personRepository.GetAllStaff())
            {
                if (s.Username == username && hasher.Verify(password, s.Password))
                {
                    return true;
                }
            }
            return false;
        }

        public Player GetPlayer(int playerID)
        {
            foreach (Player p in listOfPlayers)
            {
                if (p.Id == playerID)
                {
                    return p;
                }
            }
            return null;
        }

        public Player ConvertToPlayer(ValidationForRegister playerToBeConverted)
        {
            if (playerToBeConverted == null)
            {
                return null;
            }
            Player player = new Player();
            player.Name = playerToBeConverted.Name;
            player.Email = playerToBeConverted.Email;
            player.Phone = Convert.ToInt32(playerToBeConverted.Phone);
            player.Password = playerToBeConverted.ConfirmPassword;

            return player;
        }

        public bool CheckIfPlayerHasUniqueEmail(Player newPlayer)
        {
            foreach (Player p in listOfPlayers)
            {
                if (p.Email == newPlayer.Email)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CreateUser(Person newPerson)
        {

            if (newPerson == null)
            {
                return false;
            }

            newPerson.Password = hasher.Hash(newPerson.Password);
            if (newPerson is Player)
            {
                if (_personRepository.AddPlayerToDB((Player)newPerson))
                {
                    return true;
                }
            }
            else if (newPerson is Staff)
            {
                if (_personRepository.AddStaffToDB((Staff)newPerson))
                {
                    return true;
                }
            }
            return false;
        }

        public void GetPlayers()
        {
            listOfPlayers.Clear();
            if (_personRepository.GetPlayersFromDB() == null)
            {
                return;
            }
            listOfPlayers = _personRepository.GetPlayersFromDB();
        }

        public bool RegisterPlayerToTournament(Player player, int tournamentID)
        {
            if (player == null || tournamentID == 0)
            {
                return false;
            }

            _personRepository.RegisterPlayerToTournament(player, tournamentID);
            return true;
        }

        public bool GetTournamentListBasedOnID(int tournamentID)
        {
            if (tournamentID == 0)
            {
                return false;
            }

            listOfPlayerInTournament.Clear();
            listOfPlayerInTournament = _personRepository.GetTournament(tournamentID);
            return true;
        }

        public bool CheckIfPlayerHasAlreadyRegisterd(int playerID)
        {
            foreach (Player p in listOfPlayerInTournament)
            {
                if (p.Id == playerID)
                {
                    return false;

                }
            }
            return true;
        }

        public bool CheckIfRegistrationIsPossible(Tournament tournament)
        {
            if (listOfPlayerInTournament.Count() >= tournament.MaxNrOfPlayers)
            {
                return false;
            }
            return true;
        }

        public List<Player> GetTopThreePlayersFromTournament(int tournamentID, PersonManager personManager)
        {
            return _personRepository.GetTop3FromTournament(tournamentID, personManager);
        }

        public List<Player> GetRankingOfPlayersInTournament(int tournamentID, PersonManager personManager)
        {
            return _personRepository.GetRankingOfplayerInTournament(tournamentID, personManager);
        }

    }
}
