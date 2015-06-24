/*
Problem 13. Solve tasks

Write a program that can solve these tasks:
    Reverses the digits of a number
    Calculates the average of a sequence of integers
    Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
    The decimal number should be non-negative
    The sequence should not be empty
    a should not be equal to 0
*/

using System;
using System.Linq;

class SolveTasks
{
    static void Main()
    {
        string userChoice = string.Empty;

        while (userChoice == string.Empty)
        {
            Console.WriteLine("1 - Reverse the digits of a number");
            Console.WriteLine("2 - Calculate the average of a sequence of integers");
            Console.WriteLine("3 - Solve linear equation");

            Console.WriteLine("make your choice 1, 2 or 3");
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1": ReverseDigits(); break;
                case "2": AverageSum(); break;
                case "3": LinearEquation(); break;
                default:
                    Console.Clear();
                    userChoice = string.Empty;
                    break;
            }
        }
    }

    private static void LinearEquation()
    {
        Console.WriteLine("ax + b = 0");
        int a = 0;
        do
        {
            Console.Write("(non-zero) a = ");
            a = int.Parse(Console.ReadLine());
        }
        while (a == 0);
        
        Console.Write("b = ");
        decimal b = decimal.Parse(Console.ReadLine());

        Console.WriteLine("x = {0}", -b / a);
    }

    private static void AverageSum()
    {
        int n = 0;
        do
        {
            Console.Write("numbers count n: ");
            n = int.Parse(Console.ReadLine());
        } while (n < 1);

        var array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("{0}: ",i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("average of these numbers: {0}", array.Average());
    }

    private static void ReverseDigits()
    {
        decimal number = 0;
        do
        {
            Console.Write("enter number to reverse: ");
            number = decimal.Parse(Console.ReadLine());
        } while (number < 0);

        Console.Write("reversed: ");
        Console.WriteLine(new string(number.ToString().ToCharArray().Reverse().ToArray()));
    }
}

