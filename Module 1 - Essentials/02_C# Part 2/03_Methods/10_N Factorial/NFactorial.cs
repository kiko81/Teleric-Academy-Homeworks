/*
Problem 10. N Factorial

Write a program to calculate n! for each n in the range [1..100].
Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
*/

using System;
using System.Linq;
using System.Numerics;


class NFactorial
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0}!=", i);
            Console.WriteLine(Factorial(i));
        }
      
    }
    public static BigInteger Factorial(int n)
    {

        return Enumerable.Range(1, n).Select(x => new BigInteger(x)).Aggregate((x, y) => x * y);
    }
}

