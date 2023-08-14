using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace execp
{
    internal class ExceptionHandling
    {
        private int num1,num2,num3;
//private int[] num4;

        public ExceptionHandling(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
         //   this.num4 = num4;
        }

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }
        public int Num3 { get => num3; set => num3 = value; }
      //  public int[] Num4 { get => num4; set => num4 = value; }

        public int  add()
        {
            num3=num1+num2;
            return num3;
        }
        
        public void div()
        {
            num3 = num1 / num2;
            Console.WriteLine(num3);

            /*            try
                        {
                            num3 = num1 / num2;
                            Console.WriteLine(num3);


            *//*                for (int i= 0; i < 5; i++)
                            {
                                int qu = num4[i] / num2;

                            }
            *//*            }
                        catch(ArithmeticException ex)
                        {
                            Console.WriteLine("it's a error");
                        }
                        catch(IndexOutOfRangeException  ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

            */
        }

        public void checkage()
        {
            int age = num2;
            if(age <18)
            {
                throw new Ageexception();
            }
            else
            {
                Console.WriteLine("ok");
            }
        }

    }
}
