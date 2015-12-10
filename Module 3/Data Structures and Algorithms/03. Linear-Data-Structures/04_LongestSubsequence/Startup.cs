// Write a method that finds the longest subsequence of equal numbers in given List and returns the result as new List<int>.
// * Write a program to test whether the method works correctly.

namespace LongestSubsequence
{
    using System;
    using System.Linq;

    public class LongestSubsequence
    {
        private static Random rand = new Random();

        public static void Main()
        {
            var sequence = Enumerable
                .Repeat(0, rand.Next(5, 50))
                .Select(i => rand.Next(5))
                .ToList();

            Console.WriteLine("Sequence: " + string.Join(", ", sequence));

            var currentSequence = 1;
            var maxSequence = 1;
            var lastElement = sequence[0];
            var maxElement = lastElement;
            for (var i = 1; i < sequence.Count; i++)
            {
                if (sequence[i] == lastElement)
                {
                    currentSequence++;
                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                        maxElement = sequence[i];
                    }
                }
                else
                {
                    currentSequence = 1;
                }

                lastElement = sequence[i];
            }

            var newList = Enumerable.Repeat(maxElement, maxSequence);

            Console.WriteLine("First longest subsequence: " + string.Join(", ", newList));
        }
    }
}
