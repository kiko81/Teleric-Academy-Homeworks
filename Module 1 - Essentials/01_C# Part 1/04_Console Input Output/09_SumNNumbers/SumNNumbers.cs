/*
Problem 9. Sum of n Numbers

Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
*/

using System;

class SumNNumbers
{
    static void Main()
    {
        Console.Write("Enter number n of integers to sum (U'll be asked n more times :) ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter number Nr{0}: ", i);
            double number = int.Parse(Console.ReadLine());
            sum = sum + number;
        }
        Console.WriteLine("The sum of all numbers is {0}", sum);
    }
}