// Write a program that removes from given sequence all negative numbers.

namespace RemoveNegativeNumbers
{
    using System;
    using System.Linq;

    public class RemoveNegativeNumbers
    {
        private static Random rand = new Random();

        public static void Main()
        {
            var sequence = Enumerable
               .Repeat(0, rand.Next(5, 50))
               .Select(i => rand.Next(-5, 5))
               .ToList();

            Console.WriteLine("Sequence: " + string.Join(", ", sequence));

            var positevesOnly = sequence.Where(x => x >= 0);

            Console.WriteLine("Positives only sequence: " + string.Join(", ", positevesOnly));
        }
    }
}
