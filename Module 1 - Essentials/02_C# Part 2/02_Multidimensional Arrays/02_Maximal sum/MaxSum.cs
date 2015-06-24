/*
Problem 2. Maximal sum

Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
*/

using System;

class MaxSum
{
    static void Main()
    {
        //create matrix with random numbers - for best visual experience upto 10 rows & cols
        Console.WriteLine("rows of the matrix n - upto 10: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("columns of the matrix m - upto 10: ");
        int m = int.Parse(Console.ReadLine());
        Random r = new Random();
        int[,] matrix = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = r.Next(1, n * m);
                Console.Write("{0, 3}", matrix[i, j]);
            }
        Console.WriteLine();
        }

        Console.WriteLine();

        int bestSum = int.MinValue;
        int bestN = 0, bestM =0;

        for (int i = 1; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 1; j < matrix.GetLength(1) - 1; j++)
            {
                // setting middle element of the 3x3 matrix as a base
                int sum = matrix[i - 1, j - 1] + matrix[i - 1, j] + matrix[i - 1, j + 1] + matrix[i, j - 1] + matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j - 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestN = i;
                    bestM = j;
                }
            }  
        }

        int[,] biggestSum = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                biggestSum[i, j] = matrix[bestN - 1 + i, bestM - 1+ j];
            }
        }
        Console.WriteLine("3x3 matrix with best sum");
        PrintQuadMatrix(3, biggestSum);
        Console.WriteLine("and best sum is " + bestSum);
    }
    private static void PrintQuadMatrix(int n, int[,] matrix)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0, 3}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}
