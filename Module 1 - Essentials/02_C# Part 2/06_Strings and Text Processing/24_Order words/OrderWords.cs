/*
Problem 24. Order words

Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OrderWords
{
    static void Main()
    {
        Console.Write("write some words separated by space: ");
        string text = Console.ReadLine();
        string[] words = text.Split(' ');

        Array.Sort(words);
        Console.Write("alphabetical order: ");
        Console.WriteLine(string.Join(" ", words));
    }
}