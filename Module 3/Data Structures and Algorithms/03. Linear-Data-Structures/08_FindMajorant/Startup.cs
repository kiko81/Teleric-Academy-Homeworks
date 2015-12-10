// * The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
//  Write a program to find the majorant of given array(if exists).

namespace FindMajorant
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FindMajorant
    {
        private static Random rand = new Random();

        public static void Main()
        {
            //// The example
            var sequence = new List<int> { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

            //// Uncomment for random sequence and comment the upper - questionably will get majorant though
            // var sequence = Enumerable
            //   .Repeat(0, rand.Next(100))
            //   .Select(i => rand.Next(10)).ToList();
            Console.WriteLine("Sequence: " + string.Join(", ", sequence));

            var majorant = sequence
                .GroupBy(x => x)
                .FirstOrDefault(g => g.Count() > sequence.Count / 2)?.FirstOrDefault();

            Console.WriteLine("Majorant found - {0}", majorant?.ToString() ?? "false");
        }
    }
}
