/*
Problem 5. Larger than neighbours

Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
*/

using System;
using System.Linq;

class LargerThanNeighbours
{
    static Random r = new Random();

    static void Main()
    {    
        int[] array = Enumerable
            .Repeat(0, r.Next(5, 100))
            .Select(i => r.Next(100))
            .ToArray();
        Console.WriteLine("array: {" + string.Join(", ", array) + "}");       
        
        Console.Write("enter index to check (1 - {0}): ", array.Length - 1);
        int index = int.Parse(Console.ReadLine());

        bool isBigger = BiggerThanNeighbours(index, array);

        Console.WriteLine("index {0} is bigger than its neighbours - {1}", index, BiggerThanNeighbours(index, array));
    }

    private static bool BiggerThanNeighbours(int index, int[] array)
    {
        bool bigger = false;
        if (array[index] > array[index - 1] && array[index] > array[index + 1]) bigger = true;
        return bigger;
    }
}