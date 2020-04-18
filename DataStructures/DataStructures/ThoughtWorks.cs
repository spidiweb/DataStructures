using System;
using System.Collections.Generic;
using System.Text;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace DataStructures
{
    //class ThoughtWorks
    //{
    //    public static void Main()
    //    {

    //    }
    //}




    //class Result
    //{

    //    /*
    //     * Complete the 'degreeOfArray' function below.
    //     *
    //     * The function is expected to return an INTEGER.
    //     * The function accepts INTEGER_ARRAY arr as parameter.
    //     */

    //    // public static int degreeOfArray(List<int> arr)
    //    // {
    //    //     int maxOccurance  = arr.GroupBy(s => s).OrderByDescending(s => s.Count()).First().Key;
    //    //     Console.WriteLine(maxOccurance);
    //    //     return 0;
    //    // }
    //    // public static int degreeOfArray(List<int> arr)
    //    // {
    //    //     Dictionary<int,int> repeatationCount = new Dictionary<int,int>();
    //    //     // int [] repeatationCount = new int[arr.Count()];
    //    //     List<int> elementsWithHighestDegree = new List<int>();

    //    //     for( int i = 0 ; i < arr.Count() ; i++ )
    //    //     {
    //    //         if(repetationCount.ContainsKey(arr[i]))
    //    //         {
    //    //            repetationCount[arr[i]]++;
    //    //         }
    //    //         // repeatationCount[arr[i]]++;
    //    //     }
    //    //     int highestDegree = repeatationCount.Values.Max();

    //    //     for(int i = 0 ; i < repeatationCount.Keys.Count() ; i++)
    //    //     {
    //    //         if(repeatationCount[i]==highestDegree)
    //    //         {
    //    //             elementsWithHighestDegree.Add(i);   
    //    //         }
    //    //     }
    //    //     int [] shortestSubArray = new int[elementsWithHighestDegree.Count()];
    //    //     int [] a = arr.ToArray();
    //    //     for(int i =0;i< elementsWithHighestDegree.Count();i++)
    //    //     {
    //    //         shortestSubArray[i] = Array.LastIndexOf(a, elementsWithHighestDegree[i]) - Array.IndexOf(a, elementsWithHighestDegree[i]);
    //    //     }
    //    //     return shortestSubArray.ToList().Min() + 1;
    //    //     //return 0;
    //    // }
    //    public static int degreeOfArray(List<int> arr)
    //    {
    //        Dictionary<int, int> repeatationCount = new Dictionary<int, int>();
    //        // int [] repeatationCount = new int[arr.Count()];
    //        List<int> elementsWithHighestDegree = new List<int>();

    //        for (int i = 0; i < arr.Count(); i++)
    //        {
    //            if (repeatationCount.ContainsKey(arr[i]))
    //            {
    //                repeatationCount[arr[i]]++;
    //            }
    //            else
    //            {
    //                repeatationCount[arr[i]] = 1;// ++
    //            }
    //            // repeatationCount[arr[i]]++;
    //        }
    //        int highestDegree = repeatationCount.Values.Max();


    //        elementsWithHighestDegree = repeatationCount.Where(p => p.Value == highestDegree).Select(q => q.Key).ToList();
    //        //for (int i = 0; i < repeatationCount.Keys.Count(); i++)
    //        //{
    //        //    if (repeatationCount[i] == highestDegree)
    //        //    {
    //        //        elementsWithHighestDegree.Add(i);
    //        //    }
    //        //}
    //        int[] shortestSubArray = new int[elementsWithHighestDegree.Count()];
    //        int[] a = arr.ToArray();
    //        for (int i = 0; i < elementsWithHighestDegree.Count(); i++)
    //        {
    //            shortestSubArray[i] = Array.LastIndexOf(a, elementsWithHighestDegree[i]) - Array.IndexOf(a, elementsWithHighestDegree[i]);
    //        }
    //        return shortestSubArray.ToList().Min() + 1;
    //        //return 0;
    //    }

    //}

    //class Solution
    //{
    //    public static void Main(string[] args)
    //    {
    //        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

    //        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

    //        List<int> arr = new List<int>();

    //        for (int i = 0; i < arrCount; i++)
    //        {
    //            int arrItem = Convert.ToInt32(Console.ReadLine().Trim());
    //            arr.Add(arrItem);
    //        }

    //        int result = Result.degreeOfArray(arr);

    //        //textWriter.WriteLine(result);

    //        //textWriter.Flush();
    //        //textWriter.Close();
    //    }
    //}

    class Result
    {

        /*
         * Complete the 'maxTrailing' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY levels as parameter.
         */

        public static int maxTrailing(List<int> levels)
        {

            int maxTrail = -1;
            for (int i = 1; i <levels.Count();i++)
            {
                int min = levels.GetRange(0, i).Min();
                int localTrail = levels[i] - min;
                if(maxTrail<localTrail)
                {
                    maxTrail = localTrail;
                }
            }
            return maxTrail;


            //int maxTrail = -1;
            //for (int i = 1; i < levels.Count(); i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        int currTrail = levels[i] - levels[j];
            //        if (currTrail > maxTrail)
            //        {
            //            maxTrail = currTrail;
            //        }
            //    }
            //}
            //return maxTrail;
        }

    }
    class Solution
    {
        public static void Main1(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int levelsCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> levels = new List<int>();

            for (int i = 0; i < levelsCount; i++)
            {
                int levelsItem = Convert.ToInt32(Console.ReadLine().Trim());
                levels.Add(levelsItem);
            }

            int result = Result.maxTrailing(levels);

            //textWriter.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }

}
