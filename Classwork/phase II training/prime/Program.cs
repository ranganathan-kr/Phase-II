using System;

namespace prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,str,temp =0;
           
            str = Convert.ToInt32(Console.ReadLine());
            num = Convert.ToInt32(Console.ReadLine());
            for (int i =str; i<= num; i++)
            {
                for(int j =2; j <= i/2; j++)
                {
                    if((i%j) == 0)
                    {
                        temp=0;
                    }
                    else
                    {
                        temp = 1;
                    }
                }
                if(temp == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
