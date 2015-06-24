/*
Problem 7. Sum of 5 Numbers

Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
*/

using System;
using System.Linq;

class Sum5Numbers
    {
        static void Main()
        {
            Console.Write("Enter 5 numbers divided by space: ");
            string stringNums = Console.ReadLine();
            double[] numbers = stringNums.Split(' ').Select(double.Parse).ToArray();
            double sum = numbers.Sum();
            Console.WriteLine("The sum of all numbers is {0}", sum);
        }
    }