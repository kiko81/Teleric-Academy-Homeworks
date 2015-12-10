// Modify the previous program to skip duplicates

namespace SkipDuplicates
{
    using System;
    using System.Collections.Generic;

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
                    GenerateCombinationsNoRepetitions(index + 1, i + 1, arr, n, k);
                }
            }
        }
    }
}