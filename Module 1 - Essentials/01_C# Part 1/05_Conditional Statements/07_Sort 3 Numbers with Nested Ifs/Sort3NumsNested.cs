/*
Problem 7. Sort 3 Numbers with Nested Ifs

Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
*/

using System;

class Sort3NumsNested
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
        double bigger;
        double smallest;

        if (a >= b && a >= c)
        {
            biggest = a;
            if (b >= c)
            {
                bigger = b;
                smallest = c;
            }
            else
            {
                bigger = c;
                smallest = b;
            }
        }
        else if (b >= c)
        {
            biggest = b;
            if (a >= c)
            {
                bigger = a;
                smallest = c;
            }
            else
            {
                bigger = c;
                smallest = a;
            }
        }
        else
        {
            biggest = c;
            if (a >= b)
            {
                bigger = a;
                smallest = b;
            }
            else
            {
                bigger = b;
                smallest = a;
            }
        }
        Console.WriteLine("{0} {1} {2}", biggest, bigger, smallest);
    }
}