using System;
using System.Collections.Generic;
using System.Text;

namespace TestingClasses
{
    public class NearestNumber
    {


        public static void minAbsDiffPairs(List<int> lint)
        {
            List<List<int>> solution = new List<List<int>>();
            int n = lint.Count;

            // Sort the array
            lint.Sort();

            // Stores the minimal Absolute difference
            int smallestDiff = int.MaxValue;

            for (int i = 0; i < n - 1; i++)
                smallestDiff = Math.Min(smallestDiff, Math.Abs(lint[i] - lint[i + 1]));

            for (int i = 0; i < n - 1; i++)
            {
                List<int> Values = new List<int>();
                if (Math.Abs(lint[i] - lint[i + 1]) == smallestDiff)
                {
                    Values.Add(Math.Min(lint[i], lint[i + 1]));
                    Values.Add(Math.Max(lint[i], lint[i + 1]));
                    solution.Add(Values);
                }
            }

            //Print all pairs
            // System.out.println(solution);
            foreach (List<int> v in solution)
            {
                foreach (int w in v)
                    Console.Write(w + " ");
                Console.WriteLine("");
            }
        }
    }
}
