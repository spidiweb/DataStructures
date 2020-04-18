using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    class MAxSubArray
    {
        //static public void Main()
        //{
        //    System.Collections.Generic.LinkedList<int> linkedList = new LinkedList<int>();
        //    linkedList.Reverse();

        //    int testCases = Int32.Parse(Console.ReadLine());

        //    for (int testCase = 0; testCase < testCases; testCase++)
        //    {
        //        int n = Int32.Parse(Console.ReadLine());

        //        int[] arr = Console.ReadLine().Split(' ').ToList().Select(p => Int32.Parse(p)).ToArray();

        //        int maxSum = MAxSubArray.GetMaxSum(arr);

        //        Console.WriteLine(maxSum);
        //    }
        //}

        //public static int GetMaxSum(Int32[] array)
        //{
        //    int maxSum = Int32.MinValue;
        //    int localMaxSum = Int32.MinValue;


        //    //int [] memo = new int [array.Length];
        //    //  1         2         3         -2        5
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (i == 0)
        //        {
        //            localMaxSum = array[i];
        //        }
        //        else
        //        {
        //            localMaxSum = Math.Max(array[i], localMaxSum + array[i]);
        //        }


        //        if (localMaxSum > maxSum)
        //        {
        //            maxSum = localMaxSum;
        //        }
        //    }
        //    //int csum = array[0];
        //    //int msum = array[0];
        //    //int start = 0;
        //    //int end = 0;
        //    //int ans = 0;
        //    //int i = 1;

        //    //while (i < array.Length)
        //    //{
        //    //    csum = Math.Max(array[i], array[i] + csum);
        //    //    if (array[i] >= (array[i] + csum))
        //    //    {
        //    //        start = i;
        //    //    }
        //    //    msum = Math.Max(csum, msum);
        //    //    if (csum == msum)
        //    //    {
        //    //        end = i;
        //    //    }
        //    //    i++;
        //    //}
        //    return maxSum;
        //}
    }


}
