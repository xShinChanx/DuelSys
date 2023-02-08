using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Model
{
    public class Match
    {
        public int Id { get; set; }
        public Tournament Tournament { get; set; }
        public Player Player1 { get; set; }
        public int Player1Score { get; set; }
        public Player Player2 { get; set; }
        public int Player2Score { get; set; }
        public Player Winner { get; set; }
    }
}
