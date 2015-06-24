/*
Problem 5. The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers.
*/

using System;

class BiggestOf3
    {
        static void Main()
        {
            Console.Write("Enter the first number: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double c = double.Parse(Console.ReadLine());
            double biggest;

            if (a >= b && a >= c) biggest = a;
            else if (b >= c) biggest = b;
            else biggest = c;

            Console.WriteLine("The biggest of these numbers is {0}", biggest);
        }
    }