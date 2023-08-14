using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace execp
{
    internal class Ageexception : Exception
    {
        public Ageexception() : base("Age expection") 
        {

        }

    }
    internal class divexception : Exception
    {
        public divexception() : base("Invalid input")
        {

        }

    }

}
