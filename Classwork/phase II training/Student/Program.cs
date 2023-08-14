using LibraryManagement;
using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            /*StudentGrade studentMark = new StudentGrade(100,"Armster","Pollachi",99,98,100);
            Console.WriteLine(studentMark.Name);
            Console.WriteLine(studentMark.Rno );
            Console.WriteLine(studentMark.Address );
            Console.WriteLine(studentMark.Total());
            Console.WriteLine(studentMark.Average());
            Console.WriteLine(studentMark.Grade ());*/

            NonTeachingStaff nonTeachingStaff = new NonTeachingStaff ("STC","Pollachi",101, "Armstser", "Pollachi", 1000000, 20, 30, 10,5);
            TeachingStaff teachingStaff = new TeachingStaff("STC", "Pollachi",101, "Armstser", "Pollachi","DCFS", 1000000, 20, 30, 10, 5);

            Console.WriteLine(nonTeachingStaff.Name);
            Console.WriteLine(nonTeachingStaff.Eno);
            Console.WriteLine(nonTeachingStaff.Address);
            Console.WriteLine(nonTeachingStaff.CalculateSalary());
            nonTeachingStaff.CollegeDetails();


            Console.WriteLine(teachingStaff.Name);
            Console.WriteLine(teachingStaff.Eno);
            Console.WriteLine(teachingStaff.Address);
            Console.WriteLine(teachingStaff.CalculateSalary());


            Console.ReadLine();
        }
    }
}
