/*
Problem 18.* Trailing Zeroes in N!

Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
Your program should work well for very big numbers, e.g. n=100000.
*/


using System;
using System.Numerics;

class TrailingZeroes
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        BigInteger counter = 0;
        BigInteger div = 5;
        while (n / div >= 1)
        {
            counter += n / div;
            div *= 5;
        }
        Console.WriteLine("{0}! has {1} trailing zeroes"
                            , n, counter);
    }
}