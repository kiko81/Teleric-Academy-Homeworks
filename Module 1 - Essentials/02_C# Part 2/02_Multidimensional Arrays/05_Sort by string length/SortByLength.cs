/*
Problem 5. Sort by string length

You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
*/


using System;
using System.Linq;

class SortByLength
{
    static void Main()
    {
        Console.Write("Enter length of the array: ");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("array element {0}: ", i);
            array[i] = Console.ReadLine();
        }
        Console.WriteLine();
        Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
