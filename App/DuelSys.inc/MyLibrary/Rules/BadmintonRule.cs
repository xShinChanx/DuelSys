using MyLibrary.Manager;
using MyLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Rules
{
    public class BadmintonRule : IRules
    {
        public Player GetMatchWinner(Match match)
        {
            if ((match.Player1Score == 21 || match.Player2Score == 21) && (match.Player1Score <= 19 || match.Player2Score <= 19))
            {
                if (match.Player1Score > match.Player2Score)
                {
                    return match.Player1;
                }
                else
                {
                    return match.Player2;
                }
            }
            else if (match.Player1Score >= 21 && match.Player2Score >= 21 && Math.Abs(match.Player1Score - match.Player2Score) == 2)
            {
                if (match.Player1Score > match.Player2Score)
                {
                    return match.Player1;
                }
                else
                {
                    return match.Player2;
                }
            }
            else if (match.Player1Score == 30 && match.Player2Score == 29 ||match.Player1Score == 29 && match.Player2Score == 30)
            {
                if (match.Player1Score > match.Player2Score)
                {
                    return match.Player1;
                }
                else
                {
                    return match.Player2;
                }
            }
            return null;
        }
    }
}
