/*
Problem 7. Selection sort

Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
*/

using System;

class SelectionSort
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

        for (int j = 0; j < array.Length; j++)
        {
            int min = array[j];
            int minIndex = j;
            for (int k = j + 1; k < array.Length; k++)
            {
                if (array[k] < array[j])
                {
                    min = array[k];
                    minIndex = k;
                }
            }

            int temp = array[j];
            array[j] = min;
            array[minIndex] = temp;
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]);
            if (i != array.Length - 1) Console.Write(", ");
        }
        Console.WriteLine();
    }
}