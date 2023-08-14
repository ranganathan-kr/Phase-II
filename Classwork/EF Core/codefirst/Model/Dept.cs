using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CF.Model
{
    internal class Dept
    {
        public int Depno { get; set; }
        public string? Dname { get; set; }


        public ICollection<Emp>? Emps { get; set; }

    }
}
