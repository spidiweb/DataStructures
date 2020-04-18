using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class FactorialUsingMemo
    {

        static void Main1(String[] args)
        {
            for (; true;)
            {
                int fabNo = -1;
                if (Int32.TryParse(Console.ReadLine(), out fabNo))
                {
                    Console.WriteLine(GetFab(fabNo));
                }
                else
                {
                    break;
                }
            }
        }
        static ulong GetFab(int no, ulong[] memo = null)
        {
            if (no < 1)
            {
                return 0;
            }

            if (memo == null)
            {
                memo = new ulong[no + 1];
                memo[0] = 0;
                memo[1] = 1;
            }

            if (memo[no] != 0)
            {
                return memo[no];
            }

            //for (int i = 1; i <= no; i++)
            //{

            memo[no] = GetFab(no - 1, memo) + GetFab(no - 2, memo);

            //}
            return memo[no];
        }
    }
}
