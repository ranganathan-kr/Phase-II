using System;

namespace training_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, res;
            Console.WriteLine("Enter 2 num");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            res = num1 + num2;
            Console.WriteLine(res);
            string x = Console.ReadLine();
        }
    }
}
