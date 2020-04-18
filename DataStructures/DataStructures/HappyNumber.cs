using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    public static class HappyNumber
    {
        public static bool IsHappy(int n)
        {
            List<int> states = new List<int>();

            states.Add(n);
            int calcHappy = n;
            while (calcHappy != 1)
            {
                calcHappy = calcHappy.ToString().Split("").Select(p => Int32.Parse(p) * Int32.Parse(p)).Sum();
                Console.WriteLine(calcHappy);
                if (calcHappy == 1)
                {
                    return true;
                }
                else if (states.IndexOf(calcHappy) >= 0)
                {
                    return false;
                }
                states.Add(calcHappy);
            }
            return true;
        }

        public static void Main1()
        {
            IsHappy(19);
        }
    }
}
