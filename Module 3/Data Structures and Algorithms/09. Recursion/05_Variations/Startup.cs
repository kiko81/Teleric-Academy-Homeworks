// Write a recursive program for generating and printing all ordered k-element subsets from n-element set.

namespace Variations
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        private const int N = 3;
        private const int K = 2;

        private static readonly string[] Set = { "hi", "a", "b" };
        private static readonly int[] Arr = new int[K];
        private static IList<string> result = new List<string>();

        public static void Main()
        {
            GenerateVariationsWithRepetitions(0);
            Console.WriteLine(string.Join(", ", result));
        }

        private static void GenerateVariationsWithRepetitions(int index)
        {
            if (index >= K)
            {
                result.Add($"({string.Join(" ", Arr)})");
            }
            else
            {
                for (var i = 1; i <= N; i++)
                {
                    Arr[index] = i;
                    GenerateVariationsWithRepetitions(index + 1);
                }
            }
        }
    }
}