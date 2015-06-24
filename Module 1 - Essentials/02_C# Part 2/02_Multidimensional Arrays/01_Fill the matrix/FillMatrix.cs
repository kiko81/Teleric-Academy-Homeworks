/*
Problem 1. Fill the matrix

Write a program that fills and prints a matrix of size (n, n) 
*/

using System;

class FillMatrix
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        
        Console.WriteLine("a)");

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = j * n + i + 1;
            }
        }
        PrintQuadMatrix(n, matrix);

        Console.WriteLine("b)");

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j % 2 == 1) matrix[i, j] = (j + 1) * n - i;
                else matrix[i, j] = j * n + i + 1;              
            }
        }
        PrintQuadMatrix(n, matrix);


        Console.WriteLine("c)");

        int r = 0;
        int c = 0;
        int number = 1;
    
        for (int i = n - 1; i >= 0; i--)
        {
            r = i;
            c = 0;
            while (r < n && c < n)
            {
                matrix[r++, c++] = number++;
            }
        }

        for (int j = 1; j < n; j++)
        {
            r = j;
            c = 0;
            while (r < n && c < n)
            {
                matrix[c++, r++] = number++;
            }
        }
        PrintQuadMatrix(n, matrix);
     

        Console.WriteLine("d*)");
        number = 1;
        int padding = 0;
        int row = 0;
        int col = 0;
        while (number <= n * n)         
        {
            for (row = padding; row < n - padding; row++)
            {
                col = padding;
                matrix[row, col] = number;
                number++;
            }
            for (col = 1 + padding; col < n - padding; col++)
            {
                row = n - 1 - padding;
                matrix[row, col] = number;
                number++;
            }
            for (row = n - 2 - padding; row >= padding; row--)
            {
                col = n - 1 - padding;
                matrix[row, col] = number;
                number++;
            }
            for (col = n - 2 - padding; col >= padding + 1; col--)
            {
                row = padding;
                matrix[row, col] = number;
                number++;
            }
            padding++;
        }
        PrintQuadMatrix(n, matrix);
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
