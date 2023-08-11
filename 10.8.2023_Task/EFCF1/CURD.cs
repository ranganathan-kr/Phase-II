using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCF1.Context;
using EFCF1.Model;

namespace EFCF1
{
    internal class CURD
    {
        public void AddNewDept()
        {
            using (var context = new EmployeeManagement())
            {
                var dept = new Dept()
                {
                    Depno = 10,
                    Dname = "HR"
                };
                context.Depts.Add(dept);
                context.SaveChanges();
            }
        }

        public void UpdateDept()
        {
            var context = new EmployeeManagement();
            var seldept = context.Depts.FirstOrDefault(d => d.Depno == 10);
            seldept.Dname = "Database admin";
            context.SaveChanges();


        }
        public void DeleteDept()
        {

            var context = new EmployeeManagement();
            var seldept = context.Depts.FirstOrDefault(d => d.Depno == 10);
            context.Depts.Remove(seldept);
            context.SaveChanges();
        }
    }
}
