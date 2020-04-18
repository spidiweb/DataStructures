using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class KnapSack
    {
        //public static void Main()
        //{
        //    //1 2 3
        //    //4 5 1
        //    //4
        //    int[] weights = { 4, 5, 1 };
        //    int[] values = { 1, 2, 3 };
        //    int capacity = 4;

        //    int output = SolveKnapSack(capacity, weights, values, weights.Length);
        //    Console.WriteLine(output);
        //}

        private static int SolveKnapSack(int capacity, int[] weights, int[] values, int n)
        {
            if (n == 0 || capacity == 0)
            {
                return 0;
            }
            if (weights[n - 1] > capacity)
            {
                return SolveKnapSack(capacity, weights, values, n - 1);
            }
            else return Math.Max(values[n - 1] + SolveKnapSack(capacity - weights[n - 1], weights, values, n - 1), SolveKnapSack(capacity, weights, values, n - 1));
        }
    }
}
