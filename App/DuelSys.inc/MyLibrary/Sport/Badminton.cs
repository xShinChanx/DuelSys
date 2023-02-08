using MyLibrary.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Sport
{
    public class Badminton : Sports
    {
        public IRules Rules { get { return new BadmintonRule(); } }

        public override string ToString()
        {
            return "Badminton";
        }

    }
}
