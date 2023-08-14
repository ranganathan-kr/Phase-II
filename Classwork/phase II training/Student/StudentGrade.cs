using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class StudentGrade : StudentMark
    {
        public StudentGrade(string collegeName, string collegeaddress, int rno, string name, string address, int m1, int m2, int m3) : base(collegeName, collegeaddress, rno, name, address, m1, m2, m3)
        {

        }

        public char Grade()
        {
            double average = Average();
            if(average>=90)
            
                return 'A';
            
            if (average >= 80 && average <90)
            
                return 'B';

            if (average >= 65 && average < 80)

                return 'C';
            else
                return 'F';
            
        }

    }
}
