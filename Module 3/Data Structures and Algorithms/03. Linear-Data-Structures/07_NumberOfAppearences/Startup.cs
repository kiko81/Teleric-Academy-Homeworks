// Write a program that finds in given array of integers(all belonging to the range[0..1000]) how many times each of them occurs.

namespace NumberOfAppearences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ProNumberOfAppearencesgram
    {
        private static Random rand = new Random();

        public static void Main()
        {
            //// The example
            var sequence = new List<int> { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            //// Uncomment for random sequence and comment the upper
            // var sequence = Enumerable
            //    .Repeat(0, rand.Next(1000))
            //    .Select(i => rand.Next(1000)).ToList();
            Console.WriteLine("Sequence: " + string.Join(", ", sequence));

            var grouped = sequence
                .GroupBy(x => x)
                .OrderBy(x => x.Key);

            foreach (var group in grouped)
            {
                Console.WriteLine("{0} -> {1} times", group.Key, group.Count());
            }
        }
    }
}
