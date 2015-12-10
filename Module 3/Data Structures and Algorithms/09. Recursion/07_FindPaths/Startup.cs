// We are given a matrix of passable and non-passable cells.
// * Write a recursive program for finding all paths between two cells in the matrix.

namespace FindPaths
{
    using System;

    public class Startup
    {
        private static char[,] matrix =
        {
            { ' ', ' ', ' ', '*', ' ', ' ', ' ' },
            { '*', '*', ' ', '*', ' ', '*', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', ' ' },
            { ' ', '*', '*', '*', '*', '*', ' ' },
            { ' ', ' ', ' ', ' ', ' ', ' ', 'e' }
        };

        private static int pathsFound;

        private static void Main()
        {
            PrintAllPaths(0, 0);
            Console.WriteLine("Paths found: " + pathsFound);
        }

        private static void PrintAllPaths(int row, int col)
        {
            if (row < 0 || row >= matrix.GetLength(0)
                || col < 0 || col >= matrix.GetLength(1))
            {
                return;
            }

            if (matrix[row, col] == 'e')
            {
                pathsFound++;
                return;
            }

            if (matrix[row, col] == '*' || matrix[row, col] == 'u')
            {
                return;
            }

            matrix[row, col] = 'u';
            PrintAllPaths(row - 1, col);
            PrintAllPaths(row, col + 1);
            PrintAllPaths(row + 1, col);
            PrintAllPaths(row, col - 1);
            matrix[row, col] = ' ';
        }
    }
}