using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    class Spiral2DTraversal
    {
        static public void Main1()
        {
            int testCases = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                string mAndN = "";
                string arrayString = "";
                try
                {
                    mAndN = Console.ReadLine();
                    int m = Int32.Parse(mAndN.Split(' ')[0]);
                    int n = Int32.Parse(mAndN.Split(' ')[1]);
                    arrayString = Console.ReadLine();
                    int [,] arr = new int[m,n];
                    int rowNum = -1; int colNum = 0;
                    for (int j = 0; j < m * n; j++)
                    {
                        if (j % n == 0)
                        {
                            rowNum++;
                            colNum = 0;
                        }
                        else
                        {
                            colNum++;
                        }
                        arr[rowNum, colNum] = Int32.Parse(arrayString.Split(' ')[j]);
                    }
                    string result = "";
                    int xMin = 0, xMax = n - 1;
                    int yMin = 0, yMax = m - 1;
                    for (int k = 0; xMax >= xMin || yMax >= yMin; k++)
                    {
                        for (int l = xMin; l <= xMax; l++)
                        {
                            result = result + arr[yMin, l] + " ";
                        }
                        yMin++;

                        for (int p = yMin; p <= yMax; p++)
                        {
                            result = result + arr[p, xMax] + " ";
                        }
                        xMax--;
                        for (int q = xMax; q >= xMin; q--)
                        {
                            result = result + arr[yMax, q] + " ";
                        }
                        yMax--;
                        for (int o = yMax; o >= yMin; o--)
                        {
                            result = result + arr[o, xMin] + " ";
                        }
                        xMin++;
                    }
                    Console.WriteLine(result);

                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
