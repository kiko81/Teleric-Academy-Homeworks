/*
Problem 10. Find sum in array

Write a program that finds in given array of integers a sequence of given sum S (if present).
*/

using System;

class SumInArray
{
    static void Main()
    {
        Console.Write("enter sum to seek in subarray s: ");
        int s = int.Parse(Console.ReadLine());

        Console.Write("enter array lenght n: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Insert element {0} of the array: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        bool hasSequence = false;

        for (int i = 0; i < array.Length; i++)
        {
            int sum = array[i];

            if (sum == s)
            {
                Console.WriteLine("element {0} = {1}", array[i], s);
                hasSequence = true;
            }

            for (int j = i + 1; j < array.Length; j++)
            {
                sum += array[j];

                if (sum == s)
                {
                    for (int k = i; k <= j; k++)
                    {
                        Console.Write(array[k]);
                        if (k != j - 1) Console.Write(", ");
                    }
                    hasSequence = true;
                    Console.WriteLine( " = {0}", s);
                }
            }
        }
        if (!hasSequence)
        {
            Console.WriteLine("No sequences found");
        }
    }
}