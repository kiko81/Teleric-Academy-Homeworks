/*
Problem 2. Binary to decimal

Write a program to convert binary numbers to their decimal representation.
*/

using System;
using System.Collections.Generic;
using System.Linq;

class BinaryToDecimal
{
    static Random r = new Random();

    static void Main()
    {
        // you may check trough programmer's calculator if you wish to
        var array = Enumerable
            .Repeat(1, r.Next(32))
            .Select(i => r.Next(2))
            .ToArray();
        Console.WriteLine("random binary: " + string.Join(string.Empty, array));

        double number = 0;

        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] == 1) number += Math.Pow(2, array.Length - 1 - i);
            
        }

        Console.WriteLine("in decimal: " + number);
    }
}