using System;
using System.Linq;
using System.Collections.Generic;

namespace DataStructures
{

    public class Tripplets
    {
        static public void Main3()
        {
            int testCases = Int32.Parse(Console.ReadLine());
            HashSet<int> elements;
            for (int i = 0; i < testCases; i++)
            {
                string nStr = "";
                string arrayString = "";
                try
                {
                    nStr = Console.ReadLine();
                    int n = Int32.Parse(nStr);

                    arrayString = Console.ReadLine();
                    int[] arr = arrayString.Split(' ').ToList().Select(p => Int32.Parse(p)).ToArray();
                    elements = new HashSet<int>(arr);
                    int tripplets = 0;
                    for (int j = 0; j < arr.Length; j++)
                    {
                        for (int k = j + 1; k < arr.Length; k++)
                        {
                            if (elements.Contains(arr[j] + arr[k]))
                            {
                                tripplets++;
                            }
                        }
                    }
                    Console.WriteLine(tripplets);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(nStr + " " + arrayString);
                    Console.WriteLine(ex);
                }


            }
        }
    }
}
