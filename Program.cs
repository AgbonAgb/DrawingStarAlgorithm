using System;
using System.Collections.Generic;

namespace TestingClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //Point myPoint = new Point(2, 3);
                //double myPointXCoord = myPoint.X; // Access a property
                //double myPointYCoord = myPoint.Y; // Access a property
                //Console.WriteLine("The X coordinate is: " + myPointXCoord);
                //Console.WriteLine("The Y coordinate is: " + myPointYCoord);


                //Point2D point = new Point2D(3, -2);
                //PrintPoint(point);
                //TryToChangePoint(point);
                //PrintPoint(point);

                //Enum
                //Console.WriteLine(Days.Mon is Days);
                //int mondayValue = (int)Days.Tue;
                //Console.WriteLine(mondayValue);


                //Factorial
                //Factorial fact = new Factorial(5);

                //Array Sorting:
                //int[] arr = { 9, 7, 8,8, 5, 4, 1, 2, 3, 9};
                //ArraySort ArraySort = new ArraySort();
                //Array array = ArraySort.Array1Sort(arr);

                //remove duplicate
                ////RemoveDuplicate Rmv = new RemoveDuplicate();         

                ////int[] arr = { 1, 2, 2, 3, 4, 4, 4, 5, 5 };
                ////int n = arr.Length;

                ////n = Rmv.RemoveDup(arr,n);

                ////// Print updated array
                ////for (int i = 0; i < n; i++)
                ////{
                ////    Console.Write(arr[i] + " ");
                ////}





                // Console.WriteLine("Sorted Values are");
                //foreach (int akk in array)
                //{
                //    Console.Write(akk.ToString() +",");
                //}


                //ReverseWord
                //string [] arr = {"G","o","d","w","i","n"};
                //string[] arr = { "N", "I", "G", "E", "R", "I","A" };
                //StringReversal stR = new StringReversal();
                //string array = stR.Reversal(arr);
                //Console.Write("Swapped Char are " +array);


                //BinarySearch
                //int target = 13;
                //int[] Items = { 1, 2, 3, 4, 5,6,7,8,9,10,11,12,13,14};

                //BinarySearch stR = new BinarySearch();
                //int Position = stR.searchedItem(Items,target);
                //Console.Write("Item found at " + Position.ToString());


                //Console.Write("Tranverse Graph");
                //GraphTranverse.graph();


                //Console.Write("Queue");
                //QUEUE qUEUE = new QUEUE();
                //qUEUE.Qrun();

                //Console.Write("Stack");
                //Stack stk = new Stack();// QUEUE qUEUE = new QUEUE();
                //stk.RunStack();
                // qUEUE.Qrun();



                //Console.WriteLine("List");
                //List stk = new List();// QUEUE qUEUE = new QUEUE();
                //stk.RunList();


                //////Min Jump
                ////int[] itm = {2,3,1,1,4};
                ////MinJump mj = new MinJump();
                ////mj.jump(itm);
                ///

                //EvenNumbers even   = new EvenNumbers();
                //int[] itm = { 1, 2,3,4,5,6,7,8,9,10};
                //even.EvenN(itm);


                //ListNode Reversal

                //ListNode node1 = new ListNode(1);
                //ListNode node2 = new ListNode(2);   
                //ListNode node3 = new ListNode(3);   
                //ListNode node4 = new ListNode(4);
                //ListNode node5 = new ListNode(5); 
                

                //node1.Next = node2;
                //node2.Next = node3; 
                //node3.Next = node4;
                //node4.Next = node5;
                //node5.Next = null;

                //ListNode head = Reverserecursively(node1);
                //printlist(head);

                //Nearest Absolute numbers
                List<int> arr = new List<int>();
                arr.Add(4);
                arr.Add(2);
                arr.Add(1);
                arr.Add(3);


                NearestNumber NN = new NearestNumber();

                NearestNumber.minAbsDiffPairs(arr);



                Console.ReadKey();
                Console.WriteLine("Hello World!");
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private static void printlist(ListNode head)
        {
            throw new NotImplementedException();
        }

        private static ListNode Reverserecursively(ListNode node1)
        {
            throw new NotImplementedException();
        }

        static void PrintPoint(Point2D p)
        {
            Console.WriteLine("({0},{1})", p.X, p.Y);
        }
        static void TryToChangePoint(Point2D p)
        {
            p.X++;
            p.Y++;
        }

        //public static void Reverserecursively(ListNode node)
        //{

        //}
    }

   
}
