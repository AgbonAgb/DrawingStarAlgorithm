using System;
using System.Collections.Generic;
using System.Text;

namespace TestingClasses
{
    public class Stack
    {

        public void RunStack()
        {
            //Lifo
            Stack<int> stk = new Stack<int>();

            for(int k=0; k<=10; k++)
            {
                int val = k + 5;
                stk.Push(val);
                Console.WriteLine("Pushed Items = " + val);
            }

            Console.WriteLine("Element at top of stack = " + stk.Peek());
            int size = stk.Count;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Pop from stack = " + stk.Pop());
            }

            Console.WriteLine("Stack Size= " + stk.Count);
        }
    }
}
