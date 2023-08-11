using EFDF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDF
{
    internal class CRUD
    {

        public void InsertRecords()
        {
            using (var context = new HeartBeatsContext())
            {
                var department = new Department()
                {
                    Depno = 10,
                    Dname = "Hr"

                };

                context.Departments.Add(department);
                context.SaveChanges();

            }
        }
        public void update()
        {
            var context = new HeartBeatsContext();
            var seldept =context.Departments.FirstOrDefault(d => d.Depno ==10);
            seldept.Dname ="cons";
            context.SaveChanges();
        }
        public void delete()
        {
            var context = new HeartBeatsContext();
            var seldept =context.Departments.FirstOrDefault(d => d.Depno ==10);
            context.Remove(seldept);    
            context.SaveChanges();
        }
    }
}
