/*
Problem 2. Random numbers

Write a program that generates and prints to the console 10 random values in the range [100, 200].
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RandomNumbers
{
    static Random r = new Random();
    static void Main()
    {
        var array = Enumerable
            .Repeat(0, 10)
            .Select(i => r.Next(100, 201))
            .ToArray();
        Console.WriteLine(string.Join(", ", array));
    }
}