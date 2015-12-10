// Write a recursive program for generating and printing all permutations of the numbers 1, 2, ..., n for given integer number n

namespace Permutations
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        private static IList<string> result = new List<string>();

        public static void Main()
        {
            var n = 3;
            var elements = new int[3];
            for (var i = 0; i < n; i++)
            {
                elements[i] = i + 1;
            }

            GeneratePermutations(elements, 0);
            Console.WriteLine(string.Join(", ", result));
        }

        private static void GeneratePermutations<T>(T[] arr, int k)
        {
            if (k >= arr.Length)
            {
                result.Add($"({string.Join(", ", arr)})");
            }
            else
            {
                GeneratePermutations(arr, k + 1);
                for (var i = k + 1; i < arr.Length; i++)
                {
                    Swap(ref arr[k], ref arr[i]);
                    GeneratePermutations(arr, k + 1);
                    Swap(ref arr[k], ref arr[i]);
                }
            }
        }

        private static void Swap<T>(ref T first, ref T second)
        {
            var oldFirst = first;
            first = second;
            second = oldFirst;
        }
    }
}