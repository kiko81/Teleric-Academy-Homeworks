// Write a program that counts in a given array of double values the number of occurrences of each value.Use Dictionary<TKey, TValue>.

namespace NumberOfOccurencies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            // Example input: 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5
            var splittedInput = Console.ReadLine()?.Split(',');
            var doubleNumbers = splittedInput?.Select(number => double.Parse(number.Trim())).ToList();

            var occurencies = new Dictionary<double, int>();

            foreach (var number in doubleNumbers)
            {
                if (occurencies.ContainsKey(number))
                {
                    occurencies[number]++;
                }
                else
                {
                    occurencies.Add(number, 1);
                }
            }

            foreach (var key in occurencies)
            {
                Console.WriteLine("{0} -> {1} times", key.Key, key.Value);
            }
        }
    }
}
