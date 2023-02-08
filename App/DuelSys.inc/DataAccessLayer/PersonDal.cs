using MyLibrary.Manager;
using MyLibrary.Model;
using MyLibrary.Repository;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class PersonDal: IPersonDal
    {
        private int TempIDForPerson;
        private string connectionString = "Server=studmysql01.fhict.local;Uid=dbi475327;Database=dbi475327;Pwd=Ahem.adel1212;";

        public List<Player> GetPlayersFromDB()
        {
            try
            {
                List<Player> listOfPlayers = new List<Player>();
                Player player;

                using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
                {
                    string sql = "SELECT pl.ID, Name, Email, Password, Phone FROM s_person p INNER JOIN s_player pl on p.ID = pl.PersonID; ";

                    mySqlConnection.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32("ID");
                        string name = reader.GetString("Name");
                        string email = reader.GetString("Email");
                        string password = reader.GetString("Password");
                        int phone = reader.GetInt32("Phone");

                        player = new Player();

                        player.Id = id;
                        player.Name = name;
                        player.Email = email;
                        player.Password = password;
                        player.Phone = phone;

                        listOfPlayers.Add(player);
                    }
                    return listOfPlayers;
                }
            }
            catch (MySqlException)
            {
                throw new DataLayerConnectionFail("Cannot access connect to database");
            }
            catch(Exception ex)
            {

            }
            return null;
        }

        public List<Staff> GetAllStaff()
        {
            try
            {
                List<Staff> listOfStaff = new List<Staff>();
                Staff staff;

                using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
                {
                    string sql = "SELECT Username, Password FROM s_person p INNER JOIN s_staff s on p.ID = s.PersonID; ";

                    mySqlConnection.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string username = reader.GetString("Username");
                        string password = reader.GetString("Password");

                        staff = new Staff();

                        staff.Username = username;
                        staff.Password = password;

                        listOfStaff.Add(staff);
                    }
                    return listOfStaff;
                }
            }
            catch (MySqlException)
            {
                throw new DataLayerConnectionFail("Cannot access connect to database");
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        public bool AddPlayerToDB(Player newPlayer)
        {
            try
            {
                AddPersonToDBHelper(newPlayer, "Player");

                using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
                {
                    string sql = "INSERT INTO s_player (PersonID, Name, Email, Phone) VALUES(@PersonID, @Name, @Email, @Phone);";
                    mySqlConnection.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                    cmd.Parameters.AddWithValue("@PersonID", TempIDForPerson);
                    cmd.Parameters.AddWithValue("@Name", newPlayer.Name);
                    cmd.Parameters.AddWithValue("@Email", newPlayer.Email);
                    cmd.Parameters.AddWithValue("@Phone", newPlayer.Phone);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (MySqlException)
            {
                throw new DataLayerConnectionFail("Cannot access connect to database");
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool AddStaffToDB(Staff newStaff)
        {
            try
            {
                AddPersonToDBHelper(newStaff, "Staff");

                using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
                {
                    string sql = "INSERT INTO s_staff (PersonID, Username) VALUES(@PersonID, @Username);";
                    mySqlConnection.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                    cmd.Parameters.AddWithValue("@PersonID", TempIDForPerson);
                    cmd.Parameters.AddWithValue("@Username", newStaff.Username);

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (MySqlException)
            {
                throw new DataLayerConnectionFail("Cannot access connect to database");
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void AddPersonToDBHelper(Person newPerson, string Type)
        {
            try
            {
                using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
                {
                    string sql = "INSERT INTO s_person(Password, Type) VALUES(@Password, @Type);  SELECT LAST_INSERT_ID();";
                    mySqlConnection.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                    cmd.Parameters.AddWithValue("@Password", newPerson.Password);
                    cmd.Parameters.AddWithValue("@Type", Type);

                    TempIDForPerson = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            catch (MySqlException)
            {
                throw new DataLayerConnectionFail("Cannot access connect to database");
            }
            catch (Exception ex)
            {

            }

        }

        public void RegisterPlayerToTournament(Player player, int tournamentID)
        {
            try
            {
                using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
                {
                    string sql = "INSERT INTO s_playersintournament (PlayerID, TournamentID) VALUES(@PlayerID, @TournamentID); ";
                    mySqlConnection.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                    cmd.Parameters.AddWithValue("@PlayerID", player.Id);
                    cmd.Parameters.AddWithValue("@TournamentID", tournamentID);

                    cmd.ExecuteNonQuery();
                }
            }   
            catch (MySqlException)
            {
                throw new DataLayerConnectionFail("Cannot access connect to database");
            }
            catch (Exception ex)
            {

            }

        }

        public List<Player> GetTournament(int tournamentID)
        {
            try
            {
                List<Player> listOfPlayersInTournament = new List<Player>();
                Player player;

                using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
                {
                    string sql = "SELECT Name, Email, Phone, Password, player.ID as playerID FROM s_playersintournament pt Inner Join s_player player ON player.ID = pt.PlayerID Inner Join s_person person on player.PersonID = person.ID where TournamentID = @TournamentID; ";

                    mySqlConnection.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                    cmd.Parameters.AddWithValue("@TournamentID", tournamentID);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int playerID = reader.GetInt32("playerID");
                        string Name = reader.GetString("Name");
                        string Email = reader.GetString("Email");
                        int Phone = reader.GetInt32("Phone");
                        string Password = reader.GetString("Password");

                        player = new Player();

                        player.Id = playerID;
                        player.Name = Name;
                        player.Email = Email;
                        player.Phone = Phone;
                        player.Password = Password;

                        listOfPlayersInTournament.Add(player);
                    }
                    return listOfPlayersInTournament;
                }
            }
            catch (MySqlException)
            {
                throw new DataLayerConnectionFail("Cannot access connect to database");
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public List<Player> GetTop3FromTournament(int tournamentID, PersonManager personManager)
        {
            try
            {
                List<Player> listOfPlayers = new List<Player>();
                Player player;

                using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
                {
                    string sql = "SELECT Winner FROM s_match WHERE TournamentID = @TournamentID GROUP BY Winner ORDER BY COUNT(*) DESC LIMIT 3;";

                    mySqlConnection.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                    cmd.Parameters.AddWithValue("@TournamentID", tournamentID);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int Winner = reader.GetInt32("Winner");

                        player = new Player();

                        player = personManager.GetPlayer(Winner);
                        listOfPlayers.Add(player);
                    }
                    return listOfPlayers;
                }
            }
            catch (MySqlException)
            {
                throw new DataLayerConnectionFail("Cannot access connect to database");
            }

            return null;
        }

        public List<Player> GetRankingOfplayerInTournament(int tournamentID, PersonManager personManager)
        {
            try
            {
                List<Player> listOfPlayers = new List<Player>();
                Player player;

                using (MySqlConnection mySqlConnection = new MySqlConnection(connectionString))
                {
                    string sql = "SELECT Winner, Count(*) FROM s_match WHERE TournamentID = @TournamentID GROUP BY Winner ORDER BY COUNT(*) DESC;";

                    mySqlConnection.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, mySqlConnection);
                    cmd.Parameters.AddWithValue("@TournamentID", tournamentID);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int Winner;
                        player = new Player();
                        if (!reader.IsDBNull(reader.GetOrdinal("Winner")))
                        {
                            Winner = reader.GetInt32("Winner");
                            player = personManager.GetPlayer(Winner);
                        }
                        else
                        {
                        }

                        listOfPlayers.Add(player);
                    }
                    return listOfPlayers;
                }
            }
            catch (MySqlException)
            {
                throw new DataLayerConnectionFail("Cannot access connect to database");
            }
            catch (Exception ex)
            {

            }

            return null;
        }
    }
}
