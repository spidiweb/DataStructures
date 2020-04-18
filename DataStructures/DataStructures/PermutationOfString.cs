using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataStructures
{
    class PermutationOfString
    {
        //public static void Main()
        //{
        //    string s = "abc";

        //    List<String> outputs = new List<string>();

        //    PermuteString(s, 0, s.Length - 1, outputs);
        //    outputs = outputs.Distinct().ToList();
        //}

        public static void PermuteString(string input, int l, int r, List<String> list)
        {
            if (l == r)
            {
                list.Add(input);
                return;
            }
            for (int i = 0; i < input.Length; i++)
            {
                input = Swap(input, l, i);
                PermuteString(input, l + 1, r, list);
                input = Swap(input, l, i);
            }
        }

        public static String Swap(String s, int idx1, int idx2)
        {
            Char[] arr = s.ToArray();
            char a = ' ';
            a = arr[idx1];
            arr[idx1] = arr[idx2];
            arr[idx2] = a;
            return new string(arr);
        }
    }
}
