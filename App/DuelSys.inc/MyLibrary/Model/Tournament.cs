using MyLibrary.Rules;
using MyLibrary.Sport;
using MyLibrary.TournamentSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Model
{
    public class Tournament
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ITournamentSystem TournamentSystem { get; set; }
        public Sports Type { get; set; }
        public int MinNrOfPlayers { get; set; }
        public int MaxNrOfPlayers { get; set; }
        public string Venue { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; } 
        public DateTime EndDate { get; set; }  
        public bool Status { get; set; }
    }
}
