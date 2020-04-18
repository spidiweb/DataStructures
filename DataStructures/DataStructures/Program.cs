using System;
using System.Linq;
namespace DataStructures
{
    class Program
    {
        static void Main1(string[] args)
        {
            //Subarray with given sum
            int testCases = 1;
            //int testCases = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                //string[] sizeAndSum = Console.ReadLine().Split(' ');
                //int n = Int32.Parse(sizeAndSum[0]);
                //int s = Int32.Parse(sizeAndSum[0]);
                //int[] a = Console.ReadLine().Split(' ').ToList().Select(p => Int32.Parse(p)).ToArray();
                int n = 5;
                int s = 12;
                int[] a = { 1, 2, 3, 7, 5 };
                //for (int j = 0; j < a.Length; j++)
                //{
                int sum = 0;
                int j = 0;
                for (int k = 0; k < a.Length; k++)
                {
                    sum += a[k];
                    if (sum > s)
                    {
                        sum -= a[j];
                        j++;
                        //break;
                    }
                    if (sum == s)
                    {
                        Console.WriteLine((j + 1) + " " + (k + 1));
                        break;
                    }
                }
                if (sum == s)
                {
                    break;
                }
                //}
            }
        }
    }
}
