using EF_CF.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CF.Context
{
    internal class EmployeeManagement :DbContext
    {
        public DbSet <Dept> Depts { get; set; }

        public DbSet <Emp> Emps { get; set; }   
    }
}
