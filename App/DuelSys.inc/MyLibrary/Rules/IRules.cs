using MyLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Rules
{
    public interface IRules
    {
        public Player GetMatchWinner(Match match);
    }
}
