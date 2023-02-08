using MyLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.TournamentSystem
{
    public interface ITournamentSystem
    {
        public bool AddPlayersToList(List<Player> listOfPlayersToBeAdded);
        public void CreateSchedule();
        public List<Match> GetMatchSchedule();
    }
}
