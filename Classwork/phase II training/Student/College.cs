using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class College
    {
        string collegeName, collegeaddress;

        public College(string collegeName, string collegeaddress)
        {
            this.collegeName = collegeName;
            this.collegeaddress = collegeaddress;
        }

        public string CollegeName { get => collegeName; set => collegeName = value; }
        public string Collegeaddress { get => collegeaddress; set => collegeaddress = value; }

        public void CollegeDetails()
        {
            Console.WriteLine("College name :" + CollegeName + " and Address:" + Collegeaddress);
        }
    }
}
