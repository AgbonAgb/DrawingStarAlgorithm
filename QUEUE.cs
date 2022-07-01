using System;
using System.Collections.Generic;
using System.Text;

namespace TestingClasses
{
    public class QUEUE
    {

        public void Qrun()
        {
            Queue<int> Tq = new Queue<int> ();

            for(int k=0; k<=10; k++)
            {
                Console.WriteLine(k);
                Tq.Enqueue (k+5);
            }

            Console.WriteLine("Initial Topmost Value" + Tq.Peek());
            Console.WriteLine("");
            foreach (int vs in Tq)
            {
                Console.WriteLine("Q Values are " + vs.ToString());
            }

            Console.WriteLine("Dequeue from queue = " + Tq.Dequeue());
            Console.WriteLine(""); 
            Console.WriteLine("Topmost Value now " + Tq.Peek());
            Console.WriteLine("");

            //int size = Tq.Count;
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine("Dequeue from queue = " + Tq.Dequeue());
            //}

        }
    }
}
