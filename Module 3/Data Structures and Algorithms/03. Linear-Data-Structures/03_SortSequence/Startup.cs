// Write a program that reads a sequence of integers(List<int>) ending with an empty line and sorts them in an increasing order.

namespace SortSequence
{
    using System;
    using System.Linq;

    public class SortSequence
    {
        private const string SortedSequenceMessage = "Sorted in increasing order: ";
        private static Random rand = new Random();

        public static void Main()
        {
            var sequence = Enumerable
                .Repeat(0, rand.Next(5, 50))
                .Select(i => rand.Next(-20, 20))
                .ToList();

            Console.WriteLine("Sequence: " + string.Join(", ", sequence));
            sequence.Sort();
            Console.WriteLine(SortedSequenceMessage + string.Join(", ", sequence));
        }
    }
}
