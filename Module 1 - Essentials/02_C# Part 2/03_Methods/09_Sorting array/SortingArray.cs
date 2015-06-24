/*
Problem 9. Sorting array

Write a method that return the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order.
*/

using System;
using System.Linq;

class SortingArray
{
    static Random r = new Random();

    static void Main()
    {
        //int[] array = Enumerable
        //    .Repeat(0, r.Next(5, 100))
        //    .Select(i => r.Next(100))
        //    .ToArray();
        //Console.WriteLine("array: {" + string.Join(", ", array) + "}");

        //Console.Write("enter index to search after (0 - {0}): ", array.Length - 1);
        //int k = int.Parse(Console.ReadLine());

        //Console.WriteLine("maximum element in the portion is {0}", array[GetMaxIndex(array, k)]);      

        //int[] partition = PortionSelectionSort(array, k);
        //Console.WriteLine("only portion sorted");
        //Console.WriteLine("portion ascending: {" + string.Join(", ", partition.Reverse()) + "}");
        //Console.WriteLine("portion descending: {" + string.Join(", ", partition) + "}");
    }

    private static int[] PortionSelectionSort(int[] array, int k)
    {
        var portion = new int[array.Length - k];
        for (int i = k; i < array.Length; i++)
        {
            int bestIndex = GetMaxIndex(array, i);
            int biggest = array[bestIndex];
            if (array[i] > biggest)
            {
                portion[i - k] = array[i];
            }
            else
            {
                portion[i - k] = array[bestIndex];
                array[bestIndex] = array[i];
            }
        }
        return portion;
    }

    private static int GetMaxIndex(int[] array, int k)
    {
        int max = int.MinValue;
        int maxIndex = k;
        for (int i = k; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }
        return maxIndex;
    }
}
