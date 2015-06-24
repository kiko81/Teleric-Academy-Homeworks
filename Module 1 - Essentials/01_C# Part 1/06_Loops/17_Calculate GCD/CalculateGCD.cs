/*
Problem 17.* Calculate GCD

Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
Use the Euclidean algorithm (find it in Internet).
*/

using System;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());


        while (b != 0)
        {
            int remains = a % b;
            a = b;
            b = remains;
        }
        Console.WriteLine("GCD is {0}", a);
    }
}