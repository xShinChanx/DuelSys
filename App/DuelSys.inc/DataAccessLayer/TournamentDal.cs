using MyLibrary.Manager;
using MyLibrary.Model;
using MyLibrary.Repository;
using MyLibrary.Rules;
using MyLibrary.Sport;
using MyLibrary.TournamentSystem;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class TournamentDal : ITournamentDal
    {
        private string connectionString = "Server=studmysql01.fhict.local;Uid=dbi475327;Database=dbi475327;Pwd=Ahem.adel1212;";
        private Dictionary<string, ITournamentSystem> dict = new Dictionary<string, ITournamentSystem>();
        private PersonManager personManager = new PersonManager(new PersonDal());

        public TournamentDal()
        {
            AddElementsToDict();
        }

        private void AddElementsToDict()
        {
            dict.Add("Round-robin", new RoundRobinElimination());
            dict.Add("Double round-robin", new DoubleRoundRobinElimination());
        }

        public bool AddTournamentToDatabase(Tournament newTournament)
        {
            try
            {
                using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
                {
                    string sql = "INSERT INTO s_tournaments (Name, FormatOfElimination, MinNrOfPlayers, MaxNrOfPlayers, Venue, Description, StartDate, EndDate, Status, Type) VALUES(@Name, @FormatOfElimination, @MinNrOfPlayers, @MaxNrOfPlayers, @Venue, @Description, @StartDate, @EndDate, @Status, @Type);";
                    mySqlConnection.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                    cmd.Parameters.AddWithValue("@Name", newTournament.Name);
                    cmd.Parameters.AddWithValue("@FormatOfElimination", newTournament.TournamentSystem.ToString());
                    cmd.Parameters.AddWithValue("@MinNrOfPlayers", newTournament.MinNrOfPlayers);
                    cmd.Parameters.AddWithValue("@MaxNrOfPlayers", newTournament.MaxNrOfPlayers);
                    cmd.Parameters.AddWithValue("@Venue", newTournament.Venue);
                    cmd.Parameters.AddWithValue("@Description", newTournament.Description);
                    cmd.Parameters.AddWithValue("@StartDate", newTournament.StartDate);
                    cmd.Parameters.AddWithValue("@EndDate", newTournament.EndDate);
                    cmd.Parameters.AddWithValue("@Status", 0);
                    cmd.Parameters.AddWithValue("@Type", newTournament.Type.ToString());

                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (MySqlException)
            {
                throw new DataLayerConnectionFail("Cannot access connect to database");
                return false;
            }

        }

        public List<Tournament> GetAllTournamentsFromDB()
        {
            List<Tournament> listOfTournaments = new List<Tournament>();
            Tournament tournament;

            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                string sql = "SELECT ID, Name, FormatOfElimination, MinNrOfPlayers, MaxNrOfPlayers, Venue, Description, StartDate, EndDate, Status FROM s_tournaments; ";

                mySqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32("ID");
                    string name = reader.GetString("Name");
                    string formatOfElimination = reader.GetString("FormatOfElimination");
                    int minNrOfPlayers = reader.GetInt32("MinNrOfPlayers");
                    int maxNrOfPlayers = reader.GetInt32("MaxNrOfPlayers");
                    string venue = reader.GetString("Venue");
                    string description = reader.GetString("Description");
                    DateTime startDate = reader.GetDateTime("StartDate");
                    DateTime endDate = reader.GetDateTime("EndDate");
                    bool status = reader.GetBoolean("Status");

                    tournament = new Tournament();

                    tournament.ID = id;
                    tournament.Name = name;
                    tournament.TournamentSystem = dict[formatOfElimination];
                    tournament.MinNrOfPlayers = minNrOfPlayers;
                    tournament.MaxNrOfPlayers = maxNrOfPlayers;
                    tournament.Venue = venue;
                    tournament.Description = description;
                    tournament.StartDate = startDate;
                    tournament.EndDate = endDate;
                    tournament.Status = status;
                    Sports sport = new Badminton();
                    sport.Rules = new BadmintonRule();
                    tournament.Type = sport;
                    
                    listOfTournaments.Add(tournament);
                }
                return listOfTournaments;
            }
        }

        public void AddMatchesToDB(Match newMatch, int tournamentID)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                string sql = "INSERT INTO s_match (TournamentID, Player1ID, Player2ID) VALUES(@TournamentID, @Player1ID, @Player2ID); SELECT LAST_INSERT_ID();";
                mySqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                cmd.Parameters.AddWithValue("@TournamentID", tournamentID);
                cmd.Parameters.AddWithValue("@Player1ID", newMatch.Player1.Id);
                cmd.Parameters.AddWithValue("@Player2ID", newMatch.Player2.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Match> GetMatchesBasedOnTournament(int tournamentID)
        {

            List<Match> listOfMatches = new List<Match>();
            Match match;

            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                string sql = "SELECT ID, TournamentID, Player1ID, Player2ID, Player1Score, Player2Score, Winner FROM s_match Where TournamentID = @TournamentID; ";

                mySqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                cmd.Parameters.AddWithValue("@TournamentID", tournamentID);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32("ID");
                    int Player1ID = reader.GetInt32("Player1ID");
                    int Player2ID = reader.GetInt32("Player2ID");
                    int Player1Score = reader.GetInt32("Player1Score");
                    int Player2Score = reader.GetInt32("Player2Score");
                    int Winner;
                    if (!reader.IsDBNull(reader.GetOrdinal("Winner")))
                    {
                        Winner = reader.GetInt32("Winner");
                    }
                    else
                    {
                        Winner = 0;
                    }

                    match = new Match();

                    match.Id = id;
                    match.Player1 = personManager.GetPlayer(Player1ID);
                    match.Player2 = personManager.GetPlayer(Player2ID);
                    match.Player1Score = Player1Score;
                    match.Player2Score = Player2Score;

                    if(Winner == 0)
                    {
                        match.Winner = null;
                    }
                    match.Winner = personManager.GetPlayer(Winner);

                    listOfMatches.Add(match);
                }
                return listOfMatches;
            }
        }

        public void UpdateTournament(Tournament tournament)
        {
            using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
            {
                string sql = "UPDATE s_tournaments SET Name = @Name, MinNrOfPlayers = @MinNrOfPlayers, MaxNrOfPlayers = @MaxNrOfPlayers, Venue = @Venue, Description = @Description, Status = @Status WHERE id = @TournamentID";

                mySqlConnection.Open();

                MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                cmd.Parameters.AddWithValue("@Name", tournament.Name);
                cmd.Parameters.AddWithValue("@MinNrOfPlayers", tournament.MinNrOfPlayers);
                cmd.Parameters.AddWithValue("@MaxNrOfPlayers", tournament.MaxNrOfPlayers);
                cmd.Parameters.AddWithValue("@Venue", tournament.Venue);
                cmd.Parameters.AddWithValue("@Description", tournament.Description);
                cmd.Parameters.AddWithValue("@TournamentID", tournament.ID);
                cmd.Parameters.AddWithValue("@Status", tournament.Status);

                cmd.ExecuteNonQuery();
            }
        }

        public bool DeleteTournamentFromDB(Tournament tournament)
        {
            try
            {
                using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
                {
                    string sql = "DELETE FROM s_tournaments WHERE ID = @id";
                    mySqlConnection.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                    cmd.Parameters.AddWithValue("@id", tournament.ID);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public bool UpdateMatch(Match match)
        {
            try
            {
                using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
                {
                    string sql = "UPDATE s_match SET Player1Score = @Player1Score, Player2Score = @Player2Score, Winner = @Winner WHERE ID = @MatchID";

                    mySqlConnection.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                    cmd.Parameters.AddWithValue("@Player1Score", match.Player1Score);
                    cmd.Parameters.AddWithValue("@Player2Score", match.Player2Score);
                    cmd.Parameters.AddWithValue("@Winner", match.Winner.Id);
                    cmd.Parameters.AddWithValue("@MatchID", match.Id);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

    }
}
