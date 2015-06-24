/*
Problem 6. First larger than neighbours

Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
Use the method from the previous exercise.
*/

using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static Random r = new Random();

    static void Main()
    {
        Console.Write("enter array length: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = Enumerable
            .Repeat(0, n)
            .Select(i => r.Next(n))
            .ToArray();
        Console.WriteLine("random elements array: {" + string.Join(", ", array) + "}");

        int firstIndex = -1;

        for (int i = 1; i < array.Length - 1; i++)
        {
            if (BiggerThanNeighbours(i, array) == true)
            {
                firstIndex = i;
                break;
            }
        }

        Console.WriteLine("first element bigger than its neighbours is at index [{0}]", firstIndex);
    }

    private static bool BiggerThanNeighbours(int index, int[] array)
    {
        bool bigger = false;
        if (array[index] > array[index - 1] && array[index] > array[index + 1]) bigger = true;
        return bigger;
    }
}
