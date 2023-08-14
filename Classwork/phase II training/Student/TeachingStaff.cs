using System;
using System.Collections.Generic;
using System.Text;
using LibraryManagement;

namespace LibraryManagement
{
    class TeachingStaff : StaffDetails
    {
        private string dept;
        private double basicSalary;
        private readonly int _da,_hra,_cca,_pf;

        public string Dept { get => dept; set => dept = value; }
        public double BasicSalary { get => basicSalary; set => basicSalary = value; }

        public int Da => _da;

        public int Hra => _hra;

        public int Cca => _cca;

        public int Pf => _pf;

        public TeachingStaff(string collegeName, string collegeaddress, int eno, string name, string address,string dept, double basicSalary, int da, int hra, int cca, int pf) :base(collegeName, collegeaddress, eno,name,address)
        {
            this.dept = dept;
            this.basicSalary = basicSalary;
            _da = da;
            _hra = hra;
            _cca = cca;
            _pf = pf;
        }

        public float CalculateSalary()
        {
            float netsal = (float)(basicSalary+((basicSalary * ((float)Da / 100) + basicSalary * ((float)Hra / 100) + basicSalary * ((float)Cca / 100) - basicSalary * ((float)Pf / 100))));
            return netsal;
        }
    }
}
