using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class StudentDetails : College
    {
        private int rno;
        private string name, address;

        public StudentDetails(string collegeName, string collegeaddress, int rno, string name, string address) : base(collegeName, collegeaddress)
        {
            this.rno = rno;  //Rno can also be used here but here it is enough
            this.name = name;
            this.address = address;
        }

        public int Rno { get => rno; set => rno = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
    }
}
