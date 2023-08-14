using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class BankDetails
    {

        private int cusid;
        private string? name,status;
        private long accno;
        private double balance;

        public BankDetails(int cusid, string? name, string? status, long accno, double balance)
        {
            this.cusid = cusid;
            this.name = name;
            this.status = status;
            this.accno = accno;
            this.balance = balance;
        }

        public int Cusid { get => cusid; set => cusid = value; }
        public string? Name { get => name; set => name = value; }
        public string? Status { get => status; set => status = value; }
        public long Accno { get => accno; set => accno = value; }
        public double Balance { get => balance; set => balance = value; }

        public void Fetchacc(int cusid)
        {
            if(Cusid==cusid)
            {
                Console.WriteLine($"Account :{accno} \nname :{name} \nstatus : {status}");
            }
        }
        public void Fetchacc(string name)
        {
            if(name.Equals(Name))
            {
                Console.WriteLine($"Account :{accno} \nname :{name} \nstatus : {status}");
            }
        }
    }
}
