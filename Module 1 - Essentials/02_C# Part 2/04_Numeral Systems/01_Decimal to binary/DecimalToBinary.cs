/*
Problem 1. Decimal to binary

Write a program to convert decimal numbers to their binary representation.
*/

using System;
using System.Collections.Generic;
using System.Linq;
class DecimalToBinary
{
    static void Main()
    {
        Console.Write("enter integer to convert: ");
        int n = int.Parse(Console.ReadLine());
        var array = new List<int>();
        while (n > 0)
        {
            array.Add(n % 2);
            n /= 2;
        }

        array.Reverse();
        Console.WriteLine(string.Join(string.Empty, array));
    }
}