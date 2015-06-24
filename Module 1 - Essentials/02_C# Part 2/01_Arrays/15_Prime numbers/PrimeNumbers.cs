/*
Problem 15. Prime numbers

Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
*/

using System;

class PrimeNumbers
{
    static void Main()
    {
        bool[] primes = new bool[100];

        for (int i = 2; i < Math.Sqrt(primes.Length); i++)
        {
            for (int j = i * i; j < primes.Length; j += i)
            {
                primes[j] = true;
            }
        }

        for (int i = 2; i < primes.Length; i++)
        {
            if (!primes[i]) Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}