using MyLibrary.Model;
using MyLibrary.Repository;
using MyLibrary.TournamentSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Manager
{
    public class TournamentManager
    {
        private readonly ITournamentDal _tournamentRepository;
        public List<Tournament> listOfTournaments = new List<Tournament>();

        public TournamentManager(ITournamentDal tournamentReporsitory)
        {
            _tournamentRepository = tournamentReporsitory;
            GetAllTournaments();
        }

        private bool AddTournament(Tournament newTournament)
        {
            if (newTournament == null)
            {
                return false;
            }
            if (_tournamentRepository.AddTournamentToDatabase(newTournament))
            {
                return true;
            }
            return false;
        }

        public bool CreateTournamentObject(Tournament newTournament)
        {
            if (AddTournament(newTournament))
            {
                GetAllTournaments();
                return true;
            }
            return false;
        }

        public void GetAllTournaments()
        {
            if (_tournamentRepository.GetAllTournamentsFromDB() == null)
            {
                return;
            }

            listOfTournaments = _tournamentRepository.GetAllTournamentsFromDB();
        }

        public Tournament GetTournament(int tournamentID)
        {
            foreach (Tournament t in listOfTournaments)
            {
                if (t.ID == tournamentID)
                {
                    return t;
                }
            }
            return null;
        }

        public bool GenerateSchedule(int tournamentID, PersonManager personManager)
        {
            Tournament tournament = GetTournament(tournamentID);

            personManager.GetTournamentListBasedOnID(Convert.ToInt32(tournamentID));

            if (!tournament.TournamentSystem.AddPlayersToList(personManager.listOfPlayerInTournament))
            {
                return false;
            }
            tournament.TournamentSystem.CreateSchedule();
            AddMatchesToDB(tournament.TournamentSystem.GetMatchSchedule(), tournamentID);
            tournament.Status = true;
            UpdateTournament(tournament);

            if (tournament.TournamentSystem.GetMatchSchedule() == null)
            {
                return false;
            }
            return true;
        }

        private void AddMatchesToDB(List<Match> listOfMatches, int tournamentID)
        {
            foreach (Match m in listOfMatches)
            {
                _tournamentRepository.AddMatchesToDB(m, tournamentID);
            }
        }

        public List<Match> GetMatchBasedOnTournament(int tournamentID)
        {
            if(_tournamentRepository.GetMatchesBasedOnTournament(tournamentID) != null)
            {
                return _tournamentRepository.GetMatchesBasedOnTournament(tournamentID);
            }
            return null;
        }

        public Match GetMatchBasedOnID(int matchID, int tournamentID)
        {
            List<Match> listOfMatch = GetMatchBasedOnTournament(tournamentID);

            foreach (Match m in listOfMatch)
            {
                if (m.Id == matchID)
                {
                    return m;
                }
            }
            return null;
        }

        public void UpdateTournament(Tournament tournament)
        {
            _tournamentRepository.UpdateTournament(tournament);
        }

        public bool DeleteTournament(Tournament tournament)
        {
            if (_tournamentRepository.DeleteTournamentFromDB(tournament))
            {
                GetAllTournaments();
                return true;
            }
            return false;
        }

        public bool UpdateMatch(Match match)
        {
            if (_tournamentRepository.UpdateMatch(match))
            {
                return true;
            }
            return false;
        }

        public Tournament TypeOfElimination(string typeOfTournament)
        {
            Tournament tournament = new Tournament();

            if (string.IsNullOrEmpty(typeOfTournament))
            {
                return null;
            }

            if (typeOfTournament == "Round-robin")
            {
                tournament.TournamentSystem = new RoundRobinElimination();
            }

            else if (typeOfTournament == "Double round-robin")
            {
                tournament.TournamentSystem = new DoubleRoundRobinElimination();
            }
            return tournament;
        }

        public bool CheckMinAndMaxNrOfPlayer(int minNrOfPlayer, int maxNrOfPlayer)
        {
            if (maxNrOfPlayer < minNrOfPlayer)
            {
                return false;
            }
            return true;
        }

        public bool CheckEditForMinNrOfPlayer(Tournament tournament, int minNrOfPlayer, PersonManager personManager)
        {
            if (personManager.listOfPlayerInTournament.Count < minNrOfPlayer || minNrOfPlayer < 2)
            {
                return false;
            }
            return true;
        }

        public bool CheckDaysToStartTournament(Tournament tournament)
        {
            if(tournament.StartDate.Date < DateTime.Now.Date.AddDays(7))
            {
                return false;
            }
            return true;
        }

        public bool CheckIfTournamentIsDone(int tournamentID)
        {
            foreach (Match m in GetMatchBasedOnTournament(tournamentID))
            {
                if(m.Winner == null)
                {
                    return false;
                }
            }
                return true;
        }
    }
}
