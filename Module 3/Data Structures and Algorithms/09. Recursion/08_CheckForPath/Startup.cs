// Modify the above program (task 7) to check whether a path exists between two cells without finding all possible paths.
// * Test it over an empty 100 x 100 matrix.

namespace CheckForPath
{
    using System;

    public class Startup
    {
        private static int[,] matrix;

        private static bool pathFound;

        public static void Main()
        {
            matrix = new int[100, 100];
            matrix[95, 97] = 1;
            PrintAllPaths(0, 0);
        }

        private static void PrintAllPaths(int row, int col)
        {
            while (true)
            {
                if (pathFound)
                {
                    return;
                }

                if (row < 0 || row >= matrix.GetLength(0)
                || col < 0 || col >= matrix.GetLength(1))
                {
                    return;
                }

                if (matrix[row, col] == 1)
                {
                    Console.WriteLine("Path found!");
                    pathFound = true;
                    return;
                }

                if (matrix[row, col] == -1)
                {
                    return;
                }

                matrix[row, col] = -1;
                PrintAllPaths(row - 1, col);
                PrintAllPaths(row, col + 1);
                PrintAllPaths(row + 1, col);
                PrintAllPaths(row, col - 1);
            }
        }
    }
}