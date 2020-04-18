using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class NQueens
    {
        //public static void Main(String[] args)
        //{
        //    Get8QueensSolutions();
        //}

        private static void Get8QueensSolutions()
        {
            int[,] board = new int[8, 8];

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (row == 0 && col == 0)
                    {
                        board[row, col] = 1;
                        break;
                    }
                }
            }
        }

        private static bool CheckForConflicts(int[,] board, int row, int col)
        {
            for (int i = 0; i < row; i++)
            {
                if (board[i, col] == 1)
                {
                    return false;
                }
            }
            for (int i = 0; i < col; i++)
            {
                if (board[row, i] == 1)
                {
                    return false;
                }
            }

            for (int i = row, j = col; j >= 0 && i < 8; i++, j--)
            {
                if (board[i, j] == 1)
                    return false;
            }

            for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
                if (board[i, j] == 1)
                    return false;
            return true;
        }
    }
}
