using MyLibrary.Manager;
using MyLibrary.Model;
using MyLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.MockDal
{
    public class MockPersonDal : IPersonDal
    {
        public bool AddPlayerToDB(Player newPlayer)
        {
            throw new NotImplementedException();
        }

        public bool AddStaffToDB(Staff newStaff)
        {
            throw new NotImplementedException();
        }

        public List<Staff> GetAllStaff()
        {
            throw new NotImplementedException();
        }

        public List<Player> GetPlayersFromDB()
        {
            List<Player> listOfPlayer = new List<Player>()
            {
                new Player
                {
                    Id = 1,
                    Phone = 156156,
                    Email = "basheer@gmail.com",
                },
                new Player
                {
                    Id=2,
                    Phone = 456456,
                    Email = "min@gmail.com",
                },
                new Player
                {
                    Id=3,
                    Phone = 456456,
                    Email = "veiro@gmail.com"
                }
            };
            return listOfPlayer;
        }

        public List<Player> GetRankingOfplayerInTournament(int tournamentID, PersonManager personManager)
        {
            throw new NotImplementedException();
        }

        public List<Player> GetTop3FromTournament(int tournamentID, PersonManager personManager)
        {
            throw new NotImplementedException();
        }

        public List<Player> GetTournament(int tournamentID)
        {
            throw new NotImplementedException();
        }

        public void RegisterPlayerToTournament(Player player)
        {
            throw new NotImplementedException();
        }

        public void RegisterPlayerToTournament(Player player, int tournamentID)
        {
            throw new NotImplementedException();
        }
    }
}
