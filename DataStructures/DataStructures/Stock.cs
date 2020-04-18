using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures
{
    class Stock
    {
        static public void Main1()
        {
            int testCases = Int32.Parse(Console.ReadLine());
            HashSet<int> elements;
            for (int i = 0; i < testCases; i++)
            {
                string mAndN = "";
                string arrayString = "";
                try
                {
                    mAndN = Console.ReadLine();

                    arrayString = Console.ReadLine();
                    int[] arr = arrayString.Split(' ').ToList().Select(p => Int32.Parse(p)).ToArray();

                    int buyPrice = 0;
                    int buyDay = 0;
                    bool buyed = false;
                    string res = "";
                    List<KeyValuePair<int, int>> results = new List<KeyValuePair<int, int>>();
                    for (int day = 1; day < arr.Length; day++)
                    {
                        if (day == 0)
                        {

                        }
                        else if (!buyed && arr[day - 1] < arr[day])
                        {
                            res = res + "(" + (day - 1);
                            results.Add(new KeyValuePair<int, int>(day - 1, arr[day - 1]));
                            buyed = true;
                        }
                        else if (buyed && arr[day - 1] > arr[day])
                        {
                            res = res + " " + (day - 1) + ")";
                            results.Add(new KeyValuePair<int, int>(day - 1, arr[day - 1]));
                            buyed = false;
                        }

                    }
                    if (buyed)
                    {
                        results.Add(new KeyValuePair<int, int>(arr.Length - 1, arr[arr.Length - 1]));
                    }
                    string resultString = "";
                    for (int x = 0; x < results.Count; x++)
                    {
                        if (x % 2 == 0)
                        {
                            resultString = resultString + "(" + results[x].Key;
                        }
                        else
                        {
                            resultString = resultString + " " + results[x].Key + ") ";
                        }
                    }
                    resultString.Trim();
                    Console.WriteLine(res);
                    Console.WriteLine(resultString);

                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
