using MyLibrary;
using MyLibrary.Manager;
using MyLibrary.Model;
using MyLibrary.Repository;
using MyLibrary.Rules;
using MyLibrary.Sport;
using MyLibrary.TournamentSystem;
using UnitTest.MockDal;

namespace UnitTest.UnitTest
{
    public class TournamentManagerUnitTest
    {
        TournamentManager tournamentManager = new TournamentManager(new MockTournamentDal());

        [Fact]
        public void TestRoundRobinAlgorithmShouldSucceed()
        {
            //Arrange
            Tournament tournament = new Tournament();
            tournament.TournamentSystem = new RoundRobinElimination();
            List<Match> listOfMathes = new List<Match>();

            List<Player> listOfPlayers = new List<Player>()
            {
                new Player
                {
                    Id = 1,
                },
                new Player
                {
                    Id = 2,
                },
                new Player
                {
                    Id =3,
                }
            };

            //Act
            tournament.TournamentSystem.AddPlayersToList(listOfPlayers);
            tournament.TournamentSystem.CreateSchedule();
            listOfMathes = tournament.TournamentSystem.GetMatchSchedule();

            //Assert
            Assert.Equal(3, listOfMathes.Count());
        }

        [Fact]
        public void TestRoundRobinAlgorithmShouldFail()
        {
            //Arrange
            Tournament tournament = new Tournament();
            tournament.TournamentSystem = new RoundRobinElimination();
            List<Match> listOfMathes = new List<Match>();
            List<Player> listOfPlayers = new List<Player>(); // No Players
            int NrOfMatches;

            //Act
            tournament.TournamentSystem.AddPlayersToList(listOfPlayers);
            tournament.TournamentSystem.CreateSchedule();
            listOfMathes = tournament.TournamentSystem.GetMatchSchedule();
            NrOfMatches = listOfMathes.Count();

            //Assert
            Assert.Equal(0, NrOfMatches);
        }

        [Fact]
        public void TestDoubleRoundRobinAlgorithmShouldSucceed()
        {
            //Arrange
            Tournament tournament = new Tournament();
            tournament.TournamentSystem = new DoubleRoundRobinElimination();
            List<Match> listOfMathes = new List<Match>();

            List<Player> listOfPlayers = new List<Player>()
            {
                new Player
                {
                    Id = 1,
                },
                new Player
                {
                    Id = 2,
                },
                new Player
                {
                    Id =3,
                }
            };

            //Act
            tournament.TournamentSystem.AddPlayersToList(listOfPlayers);
            tournament.TournamentSystem.CreateSchedule();
            listOfMathes = tournament.TournamentSystem.GetMatchSchedule();

            //Assert
            Assert.Equal(6, listOfMathes.Count());
        }

        [Fact]
        public void TestDoubleRoundRobinAlgorithmShouldFail()
        {
            //Arrange
            Tournament tournament = new Tournament();
            tournament.TournamentSystem = new RoundRobinElimination();
            List<Match> listOfMathes = new List<Match>();
            List<Player> listOfPlayers = new List<Player>();
            int NrOfMatches;

            //Act
            tournament.TournamentSystem.AddPlayersToList(listOfPlayers);
            tournament.TournamentSystem.CreateSchedule();
            listOfMathes = tournament.TournamentSystem.GetMatchSchedule();
            NrOfMatches = listOfMathes.Count();

            //Assert
            Assert.Equal(0, NrOfMatches);
        }

        [Theory]
        [InlineData(1, 1)]
        public void TestGetMatchBasedOnIDShouldSucceed(int matchID, int tournamentID)
        {
            //Arrange
            Match match = new Match();

            //Act 
            match = tournamentManager.GetMatchBasedOnID(matchID, tournamentID);

            Match expextedMatch = new Match();
            expextedMatch.Id = 1;
            expextedMatch.Player1Score = 21;
            expextedMatch.Player2Score = 18;

            //Assert
            Assert.NotNull(match);
            Assert.Equal(expextedMatch.Id, match.Id);
            Assert.Equal(expextedMatch.Player1Score, match.Player1Score);
            Assert.Equal(expextedMatch.Player2Score, match.Player2Score);
        }

        [Theory]
        [InlineData(4, 1)]
        public void TestGetMatchBasedOnIDShouldFail(int matchID, int tournamentID)
        {
            //Arrange
            Match match = new Match();

            //Act 
            match = tournamentManager.GetMatchBasedOnID(matchID, tournamentID);

            //Assert
            Assert.Null(match);
        }

        [Theory]
        [InlineData(2)]
        public void TestGetTournamentShouldSuceed(int tournamentID)
        {
            //Arrange
            Tournament tournament = new Tournament();

            //Act
            tournament = tournamentManager.GetTournament(tournamentID);

            Tournament expectedTournament = new Tournament();
            expectedTournament.Name = "SAICKAK";
            expectedTournament.TournamentSystem = new DoubleRoundRobinElimination();
            expectedTournament.ID = 2;
            expectedTournament.MaxNrOfPlayers = 10;
            expectedTournament.MinNrOfPlayers = 5;
            expectedTournament.Status = false;
            expectedTournament.Venue = "ISG Dammam";
            expectedTournament.StartDate = DateTime.Now.AddDays(15);
            expectedTournament.EndDate = DateTime.Now.AddDays(25);
            expectedTournament.Description = "Bring your own rackets";
            expectedTournament.Type = new Badminton();
            expectedTournament.Type.Rules = new BadmintonRule();

            //Assert
            Assert.Equal(tournament.Name, expectedTournament.Name);
            Assert.Equal(tournament.ID, expectedTournament.ID);
            Assert.Equal(tournament.MaxNrOfPlayers, expectedTournament.MaxNrOfPlayers);
            Assert.Equal(tournament.MinNrOfPlayers, expectedTournament.MinNrOfPlayers);
            Assert.Equal(tournament.Status, expectedTournament.Status);
            Assert.Equal(tournament.Venue, expectedTournament.Venue);
            Assert.Equal(tournament.Description, expectedTournament.Description);
        }

        [Theory]
        [InlineData(3)]
        public void TestGetTournamentShouldFail(int tournamentID)
        {
            //Arrange
            Tournament tournament = new Tournament();

            //Act
            tournament = tournamentManager.GetTournament(tournamentID);

            //Assert
            Assert.Null(tournament);
        }

       
    }
}