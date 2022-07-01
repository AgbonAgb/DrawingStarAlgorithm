using System;
using System.Collections.Generic;
using System.Text;

namespace TestingClasses
{
    public class MinJump
    {

        public int jump(int [] nums)
        {
            int k = 0;
            int n = nums.Length;    
            if(n < 2)
            {
                return 0;
            }

            int Maxindexreachable = nums[0];
            int ans = 1;
            int lim = nums[0];
            for(int i =1; i < n; i++)
            { 
                if(i > lim)
                {
                    ans++;
                    lim = Maxindexreachable;
                }
                Maxindexreachable=Math.Max(Maxindexreachable, i + nums[i]);   
            }

            Console.WriteLine("Min Jump is " + ans.ToString());
            return ans;
        }
    }
}
