/*
Problem 14. Integer calculations

Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
Use variable number of arguments.
*/

using System;
using System.Linq;
using System.Numerics;

class IntegerCalculations
{
    static Random r = new Random();

    static void Main()
    {
        int[] array = Enumerable
            .Repeat(0, r.Next(5, 20))
            .Select(i => r.Next(-20, 21))
            .ToArray();
        Console.WriteLine("random numbers (-20, 20): " + string.Join(", ", array)); 

        Console.WriteLine("Smallest:" + Min(array));
        Console.WriteLine("Biggest: :" + Max(array));
        Console.WriteLine("Average: " + Average(array));
        Console.WriteLine("Sum: " + Sum(array));
        Console.WriteLine("Product of all numbers (may be 0) " + Product(array));
    }

    static int Min(int[] array)
    {
        int min = int.MaxValue;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min) min = array[i];
        }
        return min;
    }

    static int Max(int[] array)
    {
        int max = int.MinValue;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
        }
        return max;
    }

    static int Sum(int[] array)
    {
        return array.Sum();
    }

    static decimal Average(int[] array)
    {
        return (decimal)Sum(array) / array.Length;
    }

    static BigInteger Product(int[] array)
    {
        return array.Select(x => new BigInteger(x)).Aggregate((x, y) => x * y);
    }
}
