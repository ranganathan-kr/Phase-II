using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDF.Models
{
    internal class CRUD_Emp 
    {

        public void InsertEmp()
        {
            using (var context = new HeartBeatsContext())
            {
                var emp = new Emp()
                {
                    Id = 1,
                    Name = "employee",
                    Depno = 10,
                    Addr = "Hr"


                };

                context.Emps.Add(emp);
                context.SaveChanges();

            }
        }

        public void updateEmp()
            {
                var context =new HeartBeatsContext();
                var emp = context.Emps.FirstOrDefault(x =>x.Id == 1);
                emp.Name = "Ranga";
                context.SaveChanges();
            }
        

        public void deleteEmp()
        {
            var context = new HeartBeatsContext();
            var emp = context.Emps.FirstOrDefault(x => x.Id == 1);
            context.Emps.Remove(emp);
            context.SaveChanges();
        }
    }
}
