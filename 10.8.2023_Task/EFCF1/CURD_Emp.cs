using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCF1.Context;
using EFCF1.Model;

namespace EFCF1
{
    internal class CURD_Emp
    {
        public void AddNewEmp()
        {
            using (var context = new EmployeeManagement())
            {
                var emp = new Emp()
                {
                    Empno = 101,
                    Ename = "Alien",
                    Addr = "Mars"
                };
                context.Emps.Add(emp);
                context.SaveChanges();
            }
        }

        public void UpdateEmp()
        {
            var context = new EmployeeManagement();
            var selEmp = context.Emps.FirstOrDefault(d => d.Empno== 101);
            selEmp.Ename = "Human";
            context.SaveChanges();


        }
        public void DeleteEmp()
        {

            var context = new EmployeeManagement();
            var selEmp = context.Emps.FirstOrDefault(d => d.Empno == 101);
            context.Emps.Remove(selEmp);
            context.SaveChanges();
        }
    }
}
