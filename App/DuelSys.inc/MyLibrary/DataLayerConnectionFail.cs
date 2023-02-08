using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class DataLayerConnectionFail : Exception
    {
        public DataLayerConnectionFail(string? message) : base(message)
        {
        }
    }
}
