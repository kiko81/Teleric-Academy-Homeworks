/*
Problem 11. Binary search

Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
*/

using System;

class BinarySearch
{
    static void Main()
    {
        
        Console.Write("enter array lenght n: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Insert element {0} of the array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter element value to find: ");
        int key = int.Parse(Console.ReadLine());
        
        Array.Sort(array);

        int first = 0;
        int last = array.Length - 1;
        int index = 0;

        bool keyFound = false;
        while (last >= first && !keyFound)
        {
            index = (first + last) / 2;
            if (array[index] > key) last = index - 1;
            else if (array[index] < key) first = index + 1;
            else keyFound = true;      
        }

        if (keyFound)
        {
            Console.WriteLine("The {0} element is at {1} position of the sorted array", key, index);
        }
        else Console.WriteLine("key {0} not found in the array", key);
    }
}