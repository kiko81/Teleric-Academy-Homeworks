/*
Problem 14. Quick sort

Write a program that sorts an array of strings using the Quick sort algorithm.
*/

using System;

class Program
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

        QuickSort(array, 0, array.Length - 1);
        for (int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");

        Console.WriteLine();
    }

    static public void QuickSort(int[] array, int left, int right)
    {
        // For Recusrion
        if (left < right)
        {
            int pivot = Partition(array, left, right);

            if (pivot > 1)
                QuickSort(array, left, pivot - 1);

            if (pivot + 1 < right)
                QuickSort(array, pivot + 1, right);
        }
    }

    static public int Partition(int[] array, int left, int right)
    {
        int pivot = array[left];
        while (true)
        {
            while (array[left] < pivot)
                left++;

            while (array[right] > pivot)
                right--;
            
            if (array[right] == pivot && array[left] == pivot)
            {
                left++;
            }

            if (left < right)
            {
                array[left] ^= array[right];
                array[right] ^= array[left];
                array[left] ^= array[right];
            }
            else
            {
                return right;
            }
        }
    }
}
