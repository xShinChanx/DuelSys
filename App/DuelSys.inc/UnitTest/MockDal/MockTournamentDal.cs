using MyLibrary.Model;
using MyLibrary.Repository;
using MyLibrary.Rules;
using MyLibrary.Sport;
using MyLibrary.TournamentSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.MockDal
{
    public class MockTournamentDal : ITournamentDal
    {
        public void AddMatchesToDB(Match newMatch, int tournamentID)
        {
            throw new NotImplementedException();
        }

        public bool AddTournamentToDatabase(Tournament newTournament)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTournamentFromDB(Tournament tournament)
        {
            throw new NotImplementedException();
        }

        public List<Tournament> GetAllTournamentsFromDB()
        {
            List<Tournament> listOfTournaments = new List<Tournament>();

            PrefilledTournaments(listOfTournaments);

            return listOfTournaments;
        }

        private static void PrefilledTournaments(List<Tournament> listOfTournaments)
        {
            Tournament tournament = new Tournament();
            tournament.Name = "DPSL";
            tournament.TournamentSystem = new RoundRobinElimination();
            tournament.ID = 1;
            tournament.MaxNrOfPlayers = 10;
            tournament.MinNrOfPlayers = 5;
            tournament.Status = false;
            tournament.Venue = "ISG Dammam";
            tournament.StartDate = DateTime.Now.AddDays(10);
            tournament.EndDate = DateTime.Now.AddDays(20);
            tournament.Description = "Bring your own rackets";
            tournament.Type = new Badminton();
            tournament.Type.Rules = new BadmintonRule();

            listOfTournaments.Add(tournament);

            Tournament tournament1 = new Tournament();
            tournament1.Name = "SAICKAK";
            tournament1.TournamentSystem = new DoubleRoundRobinElimination();
            tournament1.ID = 2;
            tournament1.MaxNrOfPlayers = 10;
            tournament1.MinNrOfPlayers = 5;
            tournament1.Status = false;
            tournament1.Venue = "ISG Dammam";
            tournament1.StartDate = DateTime.Now.AddDays(15);
            tournament1.EndDate = DateTime.Now.AddDays(25);
            tournament1.Description = "Bring your own rackets";
            tournament1.Type = new Badminton();
            tournament1.Type.Rules = new BadmintonRule();

            listOfTournaments.Add(tournament1);
        }

        public List<Match> GetMatchesBasedOnTournament(int tournamentID)
        {
            List<Match> listOfMatch = new List<Match>();
            
            Match match = new Match();           
            match.Id = 1;
            match.Player1Score = 21;
            match.Player2Score = 18;
            listOfMatch.Add(match);

            Match match1 = new Match();
            match1.Id = 2;
            match1.Player1Score = 23;
            match1.Player2Score = 21;
            listOfMatch.Add(match1);

            Match match2 = new Match();
            match2.Id = 3;
            match1.Player1Score = 23;
            match1.Player2Score = 21;
            listOfMatch.Add(match2);

            return listOfMatch;
        }

        public bool UpdateMatch(Match match)
        {
            throw new NotImplementedException();
        }

        public void UpdateTournament(Tournament tournament)
        {
            throw new NotImplementedException();
        }
    }
}
