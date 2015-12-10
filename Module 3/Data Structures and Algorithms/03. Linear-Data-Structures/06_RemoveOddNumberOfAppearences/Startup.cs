// Write a program that removes from given sequence all numbers that occur odd number of times.

namespace RemoveOddNumberOfAppearences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveOddNumberOfAppearences
    {
        private const string ManipulationResultMessage = "Sequence of elements appearing even number of times: ";
        private static Random rand = new Random();

        public static void Main()
        {
            //// The example
            var sequence = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            //// Uncomment for random sequence and comment the upper
            // var sequence = Enumerable
            //    .Repeat(0, rand.Next(5, 50))
            //    .Select(i => rand.Next(20)).ToList();
            Console.WriteLine("Sequence: " + string.Join(", ", sequence));

            var numbersAppearingEvenTimes = sequence
                .GroupBy(x => x)
                .Where(x => x.Count() % 2 != 1)
                .Select(x => x.Key);

            var outputSequence = sequence
                .Where(x => numbersAppearingEvenTimes.Contains(x));

            Console.WriteLine(ManipulationResultMessage + string.Join(", ", outputSequence));
        }
    }
}
