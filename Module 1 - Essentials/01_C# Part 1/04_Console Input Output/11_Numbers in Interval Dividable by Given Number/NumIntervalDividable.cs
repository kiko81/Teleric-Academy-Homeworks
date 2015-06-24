/*
Problem 11.* Numbers in Interval Dividable by Given Number

Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
*/

using System;


class NumIntervalDividable
{
    static void Main()
    {
        Console.Write("Please enter first int. number: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Please enter last int. number: ");
        int last = int.Parse(Console.ReadLine());
        int counter = 0;

        for (int i = first; i <= last; i++)
        {
            if ((i % 5 == 0))
            {
                counter++;
                Console.WriteLine(i);
            }
        }
        Console.WriteLine("Number of numbers between {0} and {1} divisible to 5  is {2}", first, last, counter);
    }
}