using System;
using System.Collections.Generic;
using System.Text;

namespace TestingClasses
{
    public class ArraySort
    {

        public Array Array1Sort(int [] arr)
        {
            int[] newArr=new int[arr.Length];

            if(arr.Length ==0)
            {
                Console.WriteLine("Zero lehght cannot be sorted");
            
            }
            else
            {
                //sort
                int temp=0;
                //for (int k=0; k<=arr.Length-1;k++)
                //{
                    //
                    int cnt = arr.Length;
                    while(cnt>=0)
                    {
                        for (int i = 0; i < arr.Length-1; i++)
                        {
                            if (arr[i] > arr[i + 1])
                            {
                                temp = arr[i + 1];
                                arr[i + 1] = arr[i];
                                arr[i] = temp;
                            }

                        }
                        cnt--;  
                    }


                // }

                newArr = arr;//.Clone(newArr);

            }
            return newArr; 
        }
    }
}
