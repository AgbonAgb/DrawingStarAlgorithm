using System;
using System.Collections.Generic;
using System.Text;

namespace TestingClasses
{
    public class StringReversal
    {
        public StringReversal()
        {

        }

        public string Reversal(string [] wd)
        {
            string Fword = "";

            int cnt = wd.Length-1;

            while(cnt >= 0)
            {
                Fword = Fword + wd[cnt] +",";

                cnt--;  
            }



            return Fword;
        }
    }
}
