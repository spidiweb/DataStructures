using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class SubArraySumEqualToSpecifiedValue
    {
        static public void Main2()
        {
            int testCases = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                string nAndS = "";
                string arrayString = "";
                try
                {
                    nAndS = Console.ReadLine();
                    int n = Int32.Parse(nAndS.Split(' ')[0]);
                    int s = Int32.Parse(nAndS.Split(' ')[1]);

                    arrayString = Console.ReadLine();
                    int[] arr = arrayString.Split(' ').ToList().Select(p => Int32.Parse(p)).ToArray();

                    int startIndex = 0;
                    int endIndex = -1;
                    int sum = 0;
                    for (int j = 0; j < n; j++)
                    {
                        sum += arr[j];
                        endIndex++;

                        //if (sum > s)
                        //{
                        //    sum -= arr[startIndex];
                        //    startIndex++;
                        //}
                        while (sum > s)
                        {
                            sum -= arr[startIndex];
                            startIndex++;
                        }

                        if (sum == s)
                        {
                            break;
                        }
                    }
                    Console.WriteLine((startIndex + 1) + " " + (endIndex + 1));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(nAndS + " " + arrayString);
                    Console.WriteLine(ex);
                }


            }
        }
    }
}
