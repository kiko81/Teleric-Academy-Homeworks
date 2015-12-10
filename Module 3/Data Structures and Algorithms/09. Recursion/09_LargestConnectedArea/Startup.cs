// Write a recursive program to find the largest connected area of adjacent empty cells in a matrix.

namespace LargestConnectedArea
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        private static int[,] matrix =
            {
                { 0, 0, 0, 1, 0, 1 },
                { 0, 1, 0, 1, 0, 1 },
                { 0, 0, 1, 0, 1, 0 },
                { 0, 1, 0, 0, 0, 0 },
                { 0, 0, 0, 1, 1, 0 },
                { 0, 0, 0, 1, 0, 1 }
            };

        private static void Main()
        {
            var answer = 0;
            var bestAnswer = 0;
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        answer = TraverseBFS(i, j);
                    }

                    if (answer > bestAnswer)
                    {
                        bestAnswer = answer;
                    }
                }
            }

            Console.WriteLine("Largest connected area of free cells: " + bestAnswer);
        }

        private static int TraverseBFS(int startRow, int startColumn)
        {
            var queue = new Queue<Index>();
            var root = new Index(startRow, startColumn);

            var count = 0;
            queue.Enqueue(root);
            matrix[root.Row, root.Col]++;
            while (queue.Count != 0)
            {
                var currRoot = queue.Dequeue();
                count++;

                if (currRoot.Row + 1 < matrix.GetLength(0) && matrix[currRoot.Row + 1, currRoot.Col] == 0)
                {
                    queue.Enqueue(new Index(currRoot.Row + 1, currRoot.Col));
                    matrix[currRoot.Row + 1, currRoot.Col]++;
                }

                if (currRoot.Col + 1 < matrix.GetLength(0) && matrix[currRoot.Row, currRoot.Col + 1] == 0)
                {
                    queue.Enqueue(new Index(currRoot.Row, currRoot.Col + 1));
                    matrix[currRoot.Row, currRoot.Col + 1]++;
                }

                if (currRoot.Row - 1 >= 0 && matrix[currRoot.Row - 1, currRoot.Col] == 0)
                {
                    queue.Enqueue(new Index(currRoot.Row - 1, currRoot.Col));
                    matrix[currRoot.Row - 1, currRoot.Col]++;
                }

                if (currRoot.Col - 1 >= 0 && matrix[currRoot.Row, currRoot.Col - 1] == 0)
                {
                    queue.Enqueue(new Index(currRoot.Row, currRoot.Col - 1));
                    matrix[currRoot.Row, currRoot.Col - 1]++;
                }
            }

            return count;
        }
    }
}
