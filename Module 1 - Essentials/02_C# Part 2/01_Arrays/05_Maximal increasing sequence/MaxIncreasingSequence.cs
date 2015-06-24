/*
Problem 5. Maximal increasing sequence

Write a program that finds the maximal increasing sequence in an array.
*/

using System;
using System.Collections.Generic;


class MaxIncreasingSequence
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

        List<int> temp = new List<int>() {array[0]};
        List<int> maxSequence = new List<int>();

        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j + 1] > array[j])
            {
                temp.Add(array[j + 1]);
            }
            else
            {
                temp = new List<int> {array[j + 1]};
            }
            if (temp.Count > maxSequence.Count)
            {
                maxSequence = new List<int>(temp);
            }
        }


        for (int k = 0; k < maxSequence.Count; k++)
        {
            Console.Write(maxSequence[k]);
            if (k != maxSequence.Count - 1) Console.Write(", ");
        }

        Console.WriteLine();
    }
}