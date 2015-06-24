/*
Problem 3. Sequence n matrix

We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.
*/

using System;

class SequenceInMatrix
{
    static void Main()
    {
        string[,] matrix = new string[,] { {"ha", "fifi", "ho", "hi"}, 
                                            {"fo", "ha", "hi", "xx"}, 
                                            {"xxx", "ho", "ha", "xx"}
                                         };
        int maxCounter = 1;
        int count = 1;
        string max = "";

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] == matrix[i, j + 1]) maxCounter++;
                else count = 1;
                if (count > maxCounter)
                {
                    maxCounter = count;
                    max = matrix[i, j];
                }
            }
            count = 1;
        }

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0) - 1; j++)
            {
                if (matrix[j, i] == matrix[j + 1, i]) maxCounter++;
                else count = 1;
                if (count > maxCounter)
                {
                    maxCounter = count;
                    max = matrix[j, i];
                }
            }
            count = 1;
        }

        for (int i = 0, j = 0; i < matrix.GetLength(0) - 1 && j < matrix.GetLength(1) - 1; i++, j++)
        {
            if ((matrix[i, j] == matrix[i + 1, j + 1]))
            {
                count++;
            }
            else
            {
                count = 1;
            }
            if (count > maxCounter)
            {
                maxCounter = count;
                max = matrix[i, j];
            }
        }
        count = 1;

        for (int i = 0, j = 0; i < matrix.GetLength(0) - 1 && j > 0; i++, j--)
        {
            if ((matrix[i, j] == matrix[i + 1, j + 1]))
            {
                count++;
            }
            else
            {
                count = 1;
            }
            if (count > maxCounter)
            {
                maxCounter = count;
                max = matrix[i, j];
            }
        }
        count = 1;

        for (int i = 0; i < maxCounter; i++)
        {
            Console.Write(max);
            if (i != maxCounter - 1) Console.Write(", ");
        }
        Console.WriteLine();
    }
}