// Write a recursive program for generating and printing all the combinations with duplicates of k elements from n-element set.

namespace CombinationsWithDuplicates
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public class Startup
    {
        private static IList<string> result = new List<string>();

        public static void Main()
        {
            Console.Write("Total number of elements: ");
            var n = int.Parse(Console.ReadLine());
            Console.Write("Number of elements in combination (should be <= total elements): ");
            var k = int.Parse(Console.ReadLine());
            var arr = new int[k];

            GenerateCombinationsNoRepetitions(0, 1, arr, n, k);
            Console.WriteLine(string.Join(", ", result));
        }

        private static void GenerateCombinationsNoRepetitions(int index, int start, IList<int> arr, int n, int k)
        {
            if (index >= k)
            {
                result.Add($"({string.Join(" ", arr)})");
            }
            else
            {
                for (var i = start; i <= n; i++)
                {
                    arr[index] = i;
                    GenerateCombinationsNoRepetitions(index + 1, i, arr, n, k);
                }
            }
        }
    }
}