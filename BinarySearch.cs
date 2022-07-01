using System;
using System.Collections.Generic;
using System.Text;

namespace TestingClasses
{
    public class BinarySearch
    {
        public BinarySearch()
        {

        }

        public int searchedItem(int [] arr, int target)
        {
            
            int findat = 0;
            if(arr.Length==1)
            {
             if(arr[0]==target)
                {
                    findat = 0;
                }
            }

            if (arr.Length == 0)
            {
                findat = 0;
            }

            //First half the list and check side A

            int midPosition = (arr.Length) / 2;
            if(target == arr[midPosition])
            {
                findat = midPosition;

            }
            if(target < arr[midPosition])
            {
                //search position 1 to mid
                for(int k=0; k < midPosition; k++)
                {
                    if(target== arr[k])
                    {
                        findat = k;
                    }
                }

            }
            else
            {
                for (int k = midPosition; k < arr.Length-1; k++)
                {
                    if (target == arr[k])
                    {
                        findat = k;
                    }
                }

            }

                return findat;
        }
    }
}
