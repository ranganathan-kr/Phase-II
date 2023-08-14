using Student;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagement
{
    class StaffDetails : College 
    {
        private int eno;
        private string name, address;

        public StaffDetails(string collegeName,string collegeaddress, int eno, string name, string address) : base (collegeName,collegeaddress)
        {
            this.eno = eno;
            this.name = name;
            this.address = address;
        }

        public int Eno { get => eno; set => eno = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
    }
}
