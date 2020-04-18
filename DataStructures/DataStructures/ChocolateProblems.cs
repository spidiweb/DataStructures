using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataStructures
{
    class ChocolateProblems
    {
        //static public void Main()
        //{
        //    int testCases = Int32.Parse(Console.ReadLine());
        //    for (int testCase = 0; testCase < testCases; testCase++)
        //    {
        //        int days = Int32.Parse(Console.ReadLine());
        //        string ratesString = Console.ReadLine();
        //        try
        //        {
        //            int[] rates = ratesString.Trim().Split(' ').ToList().Select(p => Int32.Parse(p)).ToArray();
        //            int[] buySellDays = new int[days / 2 + 10];
        //            int buySellDaysLength = -1;
        //            bool buyed = false;
        //            for (int i = 0; i < days - 1; i++)
        //            {
        //                if (!buyed)
        //                {
        //                    if (rates[i] < rates[i + 1])
        //                    {
        //                        buySellDays[++buySellDaysLength] = i;
        //                        buyed = true;
        //                    }
        //                }
        //                else
        //                {
        //                    if (rates[i] > rates[i + 1])
        //                    {
        //                        buySellDays[++buySellDaysLength] = i;
        //                        buyed = false;
        //                    }
        //                }
        //            }
        //            if (buyed)
        //            {
        //                buySellDays[++buySellDaysLength] = days - 1;
        //            }
        //            string output = "";
        //            for (int i = 0; i < buySellDaysLength; i = i + 2)
        //            {
        //                output += "(" + buySellDays[i] + " " + buySellDays[i + 1] + ") ";
        //            }
        //            Console.WriteLine(output.Trim());
        //        }
        //        catch (Exception ex)
        //        {

        //        }
        //    }
        //}
        //Chocolates
        //static public void Main()
        //{
        //    int testCases = Int32.Parse(Console.ReadLine());
        //    for (int testCase = 0; testCase < testCases; testCase++)
        //    {
        //        int packetCount = Int32.Parse(Console.ReadLine());
        //        string chocolateArrayString = Console.ReadLine();
        //        try
        //        {


        //            int[] chocolatePackets = chocolateArrayString.Trim().Split(' ').ToList().Select(p => Int32.Parse(p)).ToArray();
        //            int students = Int32.Parse(Console.ReadLine());

        //            List<int> chocolatePacketList = chocolatePackets.ToList();
        //            chocolatePacketList.Sort();
        //            chocolatePackets = chocolatePacketList.ToArray();

        //            int minDifference = Int32.MaxValue;
        //            if (students < 2)
        //            {
        //                Console.WriteLine(0);
        //            }
        //            else
        //            {
        //                int loopCount = packetCount - students + 1;
        //                for (int i = 0; i < loopCount; i++)
        //                {
        //                    int diff = chocolatePackets[students - 1 + i] - chocolatePackets[i];
        //                    if (diff < minDifference)
        //                    {
        //                        minDifference = diff;
        //                    }
        //                }
        //                Console.WriteLine(minDifference);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Exception: " + chocolateArrayString);
        //        }
        //    }
        //}
    }
}
