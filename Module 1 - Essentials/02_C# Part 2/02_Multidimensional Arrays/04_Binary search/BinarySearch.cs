/*
Problem 4. Binary search

Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
*/

using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter length of the array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter value to search: ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        int maxValue = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("enter element {0}", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);

        for (int i = 0; i < n; i++)
        {
            if (array[i] <= k) maxValue = array[i];
        }

        if (Array.BinarySearch(array, maxValue) < 0)
        {
            Console.WriteLine("no number lesser or equal to k found");
        }
        else Console.WriteLine("The biggest number <= K is {0}", maxValue);

    }
}