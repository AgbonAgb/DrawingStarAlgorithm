using System;
using System.Collections.Generic;
using System.Text;

namespace TestingClasses
{
    public class EvenNumbers
    {

        public void EvenN(int [] arr)
        {
            string alleven = "";
            for(int k=0; k<arr.Length;k++)
            {
                if(arr[k] % 2 == 0)
                {
                    alleven = alleven + "," + arr[k].ToString();
                }
            }

            Console.WriteLine(alleven);
        }
    }
}
