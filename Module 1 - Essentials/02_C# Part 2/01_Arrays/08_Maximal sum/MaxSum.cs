/*
Problem 8. Maximal sum

Write a program that finds the sequence of maximal sum in given array.
*/

using System;

class MaxSum
{
    static void Main()
    {
        Console.Write("enter array lenght n: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Insert element {0} of the array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        int start = 0;
        int sum = 0;
        int biggestSum = int.MinValue;
        int startIndex = 0;
        int endIndex = 0;

        for (int j = 0; j < array.Length; j++)
        {
            if (sum < 0)
            {
                start = j;
                sum = 0;
            }

            sum += array[j];

            if (sum > biggestSum)
            {
                biggestSum = sum;
                startIndex = start;
                endIndex = j;
            }
        }

        Console.Write("The biggest sum sequence of the array is: ");
        for (int k = startIndex; k <= endIndex; k++)
        {
            // as usual last coma unnecessary
            Console.Write(array[k] + ", ");
        }

        Console.WriteLine();
        Console.WriteLine("Their sum is {0}", biggestSum);
    }
}