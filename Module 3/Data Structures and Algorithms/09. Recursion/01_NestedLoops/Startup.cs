// Write a recursive program that simulates the execution of n nested loopsfrom 1 to n.

namespace NestedLoops
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Write n to create variations from 1 to n: ");
            var n = int.Parse(Console.ReadLine());
            var arr = new int[n];

            GenerateVariationsWithRepetitions(0, arr, n);
        }

        private static void GenerateVariationsWithRepetitions(int index, IList<int> arr, int n)
        {
            if (index >= n)
            {
                Console.WriteLine(string.Join(" ", arr));
            }
            else
            {
                for (var i = 1; i <= n; i++)
                {
                    arr[index] = i;
                    GenerateVariationsWithRepetitions(index + 1, arr, n);
                }
            }
        }
    }
}
