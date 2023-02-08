using MyLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.TournamentSystem
{
    public class RoundRobinElimination : ITournamentSystem
    {
        private List<Player> listOfPlayersInTournament = new List<Player>();
        private List<Match> listOfMatches = new List<Match>();

        public override string ToString()
        {
            return "Round-robin";
        }

        public bool AddPlayersToList(List<Player> listOfPlayersToBeAdded)
        {
            if (listOfPlayersToBeAdded == null)
            {
                return false;
            }
            listOfPlayersInTournament = listOfPlayersToBeAdded;
            return true;
        }

        public void CreateSchedule()
        {
            foreach (Player p1 in listOfPlayersInTournament.ToList())
            {
                foreach (Player p2 in listOfPlayersInTournament.ToList())
                {
                    if (p1 != p2)
                    {
                        Match newMatch = new Match();
                        newMatch.Player1 = p1;
                        newMatch.Player2 = p2;
                        listOfMatches.Add(newMatch);
                    }
                }
                listOfPlayersInTournament.Remove(p1);
            }
        }

        public List<Match> GetMatchSchedule()
        { 
            if (listOfMatches == null)
            {
                return null;
            }
            return listOfMatches;
        }
    }
}
