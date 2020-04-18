using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    class TwoDServerGrid
    {
        public static void Main1()
        {
            int row, col = 0;
            
            //row = 5;
            //col = 6;
            //int[,] servers = new int[5, 6] { { 0, 0, 1, 0, 0, 0 }, { 0, 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0, 1 }, { 0, 0, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0, 0 } };

            row = 5;
            col = 5;
            int[,] servers = new int[5, 5] { { 1, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 0, 1, 0 }, { 0, 0, 0, 0, 1 } };
            int days = 0;
            while (Enumerable.Range(0, servers.GetUpperBound(0) + 1).SelectMany(x => Enumerable.Range(0, servers.GetUpperBound(1) + 1).Select(y => servers[x, y])).Where(p => (int)p == 0).ToList().Count > 0)
            {
                days++;

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (servers[i, j] == -1)
                        {
                            servers[i, j] = 1;
                        }
                    }
                }

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        //right
                        if (i + 1 < row && servers[i + 1, j] == 0 && servers[i,j] == 1)
                        {
                            servers[i + 1, j] = -1;
                        }

                        //left
                        if (i - 1 >= 0 && servers[i - 1, j] == 0 && servers[i, j] == 1)
                        {
                            servers[i -1, j] = -1;
                        }

                        //top
                        if (j - 1 >= 0 && servers[i, j - 1] == 0 && servers[i, j] == 1)
                        {
                            servers[i, j - 1] = -1;
                        }
                        //bottom
                        if (j + 1 < col && servers[i, j + 1] == 0 && servers[i, j] == 1)
                        {
                            servers[i, j + 1] = -1;
                        }
                    }
                }
            }
            Console.WriteLine(days);
        }
    }
}
