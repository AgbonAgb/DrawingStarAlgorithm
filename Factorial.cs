using System;
using System.Collections.Generic;
using System.Text;

namespace TestingClasses
{
    public class Factorial
    {
        public Factorial(int n)
        {
            int Vl = n;
            //6! = 6 X 5 X 4 X 3 X 2 X 1
            if(n==0)
            {
                Console.WriteLine("Zero cannot be acted on");
            }
            else
            {
                int Val = n;// -1;//6
                int factorial = n;                
                while(n > 1)
                {
                    factorial = factorial * (n - 1);// * n;// output * Val;
                    n--;
                }

                Console.WriteLine($"Factorial of {Vl} is {factorial}");
                Console.ReadKey();
            }
        }
    }
}
