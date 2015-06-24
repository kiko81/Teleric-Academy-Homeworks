/*
Problem 4. Number Comparer

Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.
*/

using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Please enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second number: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("The greater number is {0}", a > b ? a : b);
    }
}