/*
Problem 7. Reverse number

Write a method that reverses the digits of given decimal number.
*/

using System;
using System.Linq;

class ReverseNumber
{
    static void Main(string[] args)
    {
        Console.Write("enter number to reverse: ");
        decimal number = decimal.Parse(Console.ReadLine());
        Console.Write("reversed: ");
        Console.WriteLine(Reverse(number));
    }

    static string Reverse(dynamic x)
    {
        return new string(x.ToString().ToCharArray().Reverse().ToArray());
    }
}

