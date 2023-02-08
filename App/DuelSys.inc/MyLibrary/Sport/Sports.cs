using MyLibrary.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Sport
{
    public abstract class Sports
    {
        public IRules Rules { get; set; }
    }
}
