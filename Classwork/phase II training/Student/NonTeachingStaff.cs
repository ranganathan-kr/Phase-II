using LibraryManagement;
using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class NonTeachingStaff : StaffDetails
    {
        private double basicSalary;
        private readonly int _da, _hra, _cca, _pf;

        public double BasicSalary { get => basicSalary; set => basicSalary = value; }

        public int Da => _da;

        public int Hra => _hra;

        public int Cca => _cca;

        public int Pf => _pf;

        public NonTeachingStaff(string collegeName, string collegeaddress, int eno, string name, string address, double basicSalary, int da, int hra, int cca, int pf) : base(collegeName,collegeaddress,eno, name, address)
        {
            this.basicSalary = basicSalary;
            _da = da;
            _hra = hra;
            _cca = cca;
            _pf = pf;
        }

        public float CalculateSalary()
        {
            float netsal = (float)(basicSalary + ((basicSalary * ((float)Da / 100) + (basicSalary * ((float)Hra / 100)) + (basicSalary * ((float)Cca / 100)) - (basicSalary * ((float)Pf / 100)))));
            return netsal;
        }
    }
}
