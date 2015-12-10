// Write a program for generating and printing all subsets of k strings from given set of strings.

namespace Subsets
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        private static IList<string> result = new List<string>();

        public static void Main()
        {
            int k = 2;
            string[] elements = { "test", "rock", "fun" };
            string[] combinations = new string[k];

            GenerateCombinationsWithNoDuplicates(0, elements.Length, k, elements, combinations);
            Console.WriteLine(string.Join(", ", result));
        }

        private static void GenerateCombinationsWithNoDuplicates(int index, int n, int k, string[] elements, string[] combinations)
        {
            if (index == k)
            {
                result.Add($"({string.Join(", ", combinations)})");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    combinations[index] = elements[i];
                    if (index > 0 && string.Compare(combinations[index], combinations[index - 1], StringComparison.Ordinal) >= 0)
                    {
                        continue;
                    }

                    GenerateCombinationsWithNoDuplicates(index + 1, n, k, elements, combinations);
                }
            }
        }
    }
}