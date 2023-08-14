using System;

namespace Day4Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            int Accountnumber = Convert.ToInt32(Console.ReadLine());
            string AccountHolderName = Console.ReadLine();
            int Depositamt = Convert.ToInt32(Console.ReadLine());
            int Widthdraw = Convert.ToInt32(Console.ReadLine());

            BankAccount bankAccount = new BankAccount(Accountnumber, AccountHolderName);
            bankAccount.Deposit(Depositamt);
            bankAccount.Deposit(Widthdraw);
            bankAccount.PrintAccountDetails();

            Console.ReadLine();
        }
    }
}
