using System;

namespace CrrBill
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int consumernumber = Convert.ToInt32(Console.ReadLine());
            string consumername = Console.ReadLine();
            int prevread = Convert.ToInt32(Console.ReadLine());
            int currentread = Convert.ToInt32(Console.ReadLine());
            string consumertype = Console.ReadLine();*/

        Loop:
            Bill bill = new Bill(123,"Ranga",1000,1200,"domestic");
            int billamt=bill.Calculate();

            Console.WriteLine("Bill :" + bill.Consumername + " " + bill.Consumernumber + "  " + billamt);

            Console.WriteLine("Want to continue [y/n]:");
            string lp = Console.ReadLine();
           
            if (lp=="y")
            {
                goto Loop;
            }
            

        }
    }
}
