/*
Problem 4. Sub-string in text

Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubStrings
{
    static void Main()
    {
        Console.Write("write something");
        string text = Console.ReadLine().ToLower();
        Console.Write("write what to search to search");
        string sub = Console.ReadLine().ToLower();

        int counter = 0;
        for (int i = 0; i < text.Length - 1 - sub.Length; i++)
        {
            if (text.Substring(i, sub.Length) == sub) counter++;
        }
        Console.WriteLine(counter);

    }
}
