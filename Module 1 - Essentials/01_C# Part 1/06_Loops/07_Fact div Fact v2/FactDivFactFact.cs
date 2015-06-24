/*
Problem 7. Calculate N! / (K! * (N-K)!)

In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
*/

using System;
using System.Numerics;

class FactDivFactFact
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        BigInteger resultNDivKFacts = 1;
        BigInteger factNMinusK = 1;
        // calculate n!/k!
        for (int i = k + 1; i <= n; i++)
        {
            resultNDivKFacts *= i;
        }
        // calculate (n-k)!
        for (int j = 1; j <= n - k; j++)
        {
            factNMinusK *= j;
        }

        Console.WriteLine(resultNDivKFacts / factNMinusK);

    }
}