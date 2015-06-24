/*
Problem 6. Calculate N! / K!

Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.
*/

using System;

class FactDivFact
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        decimal result = 1;

        for (int i = k + 1; i <= n; i++)
        {
            result *= i;
        }
        Console.WriteLine(result);
    }
}