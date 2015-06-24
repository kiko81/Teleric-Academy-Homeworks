/*
Problem 6. Maximal K sum

Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.
*/

using System;

class MaxSum
{
    static void Main()
    {
        Console.Write("enter array lenght n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("enter number of elements to sum k: ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Insert element {0} of the array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
       
        Array.Sort(array);
        int sum = 0;

        Console.Write("K elements with max sum from the array are: ");
        for (int j = array.Length - k; j < array.Length; j++)
        {
            Console.Write(array[j]);
            if (j != array.Length - 1) Console.Write(", ");
            sum += array[j];
        }
        Console.WriteLine();
        Console.WriteLine("Sum of these elements is {0}", sum);
    }
}