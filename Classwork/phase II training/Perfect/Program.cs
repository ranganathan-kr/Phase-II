using System;

namespace Perfect
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,sum=0;
            num = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=num/2;i++)
            {
                if((num%i)==0)
                {
                    //Console.WriteLine(i);
                    sum += i;
                }
                
            }
            if(num==sum)
            {
                Console.WriteLine("it is pref");
            }
            else
            {
                Console.WriteLine("it is not pref");
            }


            Console.ReadLine();
        }
    }
}
