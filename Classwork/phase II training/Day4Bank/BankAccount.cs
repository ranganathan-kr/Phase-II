using System;
using System.Collections.Generic;
using System.Text;

namespace Day4Bank
{
    class BankAccount
    {
        readonly int Accountnumber;
        private  string AccountHolderName;
        private  int Balance=0;

        public BankAccount(int Accountnumber,string AccountHolderName)
        {
            this.AccountHolderName1 = AccountHolderName;
            this.Accountnumber = Accountnumber;
            
        }

        public string AccountHolderName1 { get => AccountHolderName; set => AccountHolderName = value; }
        public int Balance1 { get => Balance; set => Balance = value; }

        public int Deposit(int amt)
        {
            Balance1 += amt;
            return Balance1;
        }
        public int Withdraw(int remamt)
        {
            Balance1 =Balance1 - remamt;
            return Balance1;
        }
        public void PrintAccountDetails()
        {
            Console.WriteLine("The AccountNumber is :" + Accountnumber + " And the Name is :"+AccountHolderName1+" the balance is :"+Balance1);
        }
    }
}
