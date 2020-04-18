using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class RemoveDuplicates
    {
        public static void Main2()
        {
            List<String> names = new List<string>();
            names.Add("Aman");
            names.Add("Aman");
            names.Add("Aman");
            names.Add("Aman");
            names.Add("Aman");
            names.Add("Paras");
            names.Add("Paras");
            names.Add("Paras");
            names.Add("Paras");
            names.Add("Paras");
            names.Add("Aman");
            names.Add("Aman");

            for (int i = 0; i < names.Count; i++)
            {
                for (int j = i + 1; j < names.Count; j++)
                {
                    if (names[i] == names[j])
                    {
                        names.RemoveAt(j);
                        j--;
                    }
                }
            }
        }
    }
}
