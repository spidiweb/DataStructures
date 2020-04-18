using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class GridSearch
    {

        // Complete the gridSearch function below.
        static string gridSearch(string[] G, string[] P)
        {
            int j = 0;
            int index = -1;
            int elementCountInP = P[0].Length;
            for (int i = 0; i < G.Length; i++)
            {
                if (j == 0)
                {
                    index = G[i].Trim().IndexOf(P[j].Trim());
                    if (index >= 0)
                    {
                        j++;
                    }
                }
                else
                {
                    if (j < P.Length && G[i].Trim().IndexOf(P[j].Trim()) == index)
                    {
                        if (elementCountInP != P[j].Length)
                        {
                            break;
                        }
                        j++;
                    }
                    else
                    {
                        index = -1;
                        j = 0;
                        i--;
                    }
                    if (j >= P.Length)
                    {

                        return "YES";
                    }
                }
            }
            return "NO";
        }

        static void Main1(string[] args)
        {
            
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] RC = Console.ReadLine().Split(' ');

                int R = Convert.ToInt32(RC[0]);

                int C = Convert.ToInt32(RC[1]);

                string[] G = new string[R];

                for (int i = 0; i < R; i++)
                {
                    string GItem = Console.ReadLine();
                    G[i] = GItem;
                }

                string[] rc = Console.ReadLine().Split(' ');

                int r = Convert.ToInt32(rc[0]);

                int c = Convert.ToInt32(rc[1]);

                string[] P = new string[r];

                for (int i = 0; i < r; i++)
                {
                    string PItem = Console.ReadLine();
                    P[i] = PItem;
                }

                string result = gridSearch(G, P);

            }

        }
    }

}
