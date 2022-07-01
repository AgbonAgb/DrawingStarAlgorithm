using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestingClasses
{
    public class List
    {

        public void RunList()
        {
            List<string> nlist = new List<string>();
            nlist.Add("Godwin");
            nlist.Add("Agbon");
            nlist.Add("Oliha");

            //var sname = nlist.Where(x => x.Contains());

            //using linq forEach
            //nlist.ForEach(p => Console.WriteLine(p));

            //using foreach loop
            foreach (string names in nlist)
            {
                Console.WriteLine($"The name = {names}");
            }

            //using for loop
            for (int i = 0; i < nlist.Count; i++)
            {
                Console.WriteLine(nlist[i]);
            }
                       

            //using linq forEach with static functi
            nlist.ForEach(Console.WriteLine);

            //using strings.join
            Console.WriteLine(string.Join(", ", nlist));

        }
    }
}
