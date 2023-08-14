using System;

namespace revolt
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
                while(num > 0)
            {
                int rem = num % 10;
                sum += rem * rem * rem;
                num /= 10;

            }
                if ( sum==temp)
            {
                Console.WriteLine("Armstro");
            }
            else
            {
                Console.WriteLine("not an Arms");
            }
            Console.ReadLine();
        }
    }
}
