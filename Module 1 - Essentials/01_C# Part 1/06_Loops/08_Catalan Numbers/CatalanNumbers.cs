/*
Problem 8. Catalan Numbers
In combinatorics, the Catalan numbers are calculated by the following formula: 
Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).
*/

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger twoNDivNFacts = 1;
        BigInteger nPlus1Fact = 1;
        // calculate (2n)!/n!
        for (int i = n + 1; i <= 2 * n ; i++)
        {
            twoNDivNFacts *= i;
        }
        // calculate (n+1)!
        for (int j = 1; j <= n + 1; j++)
        {
            nPlus1Fact *= j;
        }

        Console.WriteLine("Catalan number for {0} is {1}", n, twoNDivNFacts / nPlus1Fact);
    }
}