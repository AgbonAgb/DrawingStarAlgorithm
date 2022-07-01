using System;
using System.Collections.Generic;
using System.Text;

namespace TestingClasses
{
    public class LinkedListReverse
    {
        //Riverse a singly linked recursively
        //1 ->2 ->3 ->4 ->5 ->Null
        //Answer
        //5 ->4 ->3 ->2 ->1 ->Null
    }

    public class ListNode
    {
        public int Value { get; set; }
        public ListNode Next { get; set; }  
        public ListNode(int val)
        {
            Value = val;
        }                        
    }
    

}
