// Write a program that extracts from a given sequence of strings all elements that present in it odd number of times.Example:

namespace FindOddOccurencies
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            // Example input: C#, SQL, PHP, PHP, SQL, SQL
            var splittedInput = Console.ReadLine().Split(',');
            var oddOccurencies = splittedInput.GroupBy(x => x.Trim())
                                              .Where(gr => gr.Count() % 2 != 0)
                                              .Select(gr => gr.Key);

            Console.WriteLine(string.Join(", ", oddOccurencies));
        }
    }
}
