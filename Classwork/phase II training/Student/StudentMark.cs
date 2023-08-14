using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class StudentMark : StudentDetails
    {
        private int m1, m2, m3;

        public StudentMark(string collegeName, string collegeaddress, int rno, string name, string address,int m1, int m2, int m3) : base (collegeName, collegeaddress, rno, name, address)
        {
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }

        public int M1 { get => m1; set => m1 = value; }
        public int M2 { get => m2; set => m2 = value; }
        public int M3 { get => m3; set => m3 = value; }
          
        public int Total()
        {
            return m1 + m2 + m3;
        }

        public double Average()
        {
            return (m1 + m2 + m3)/3;
        }

    }
}
