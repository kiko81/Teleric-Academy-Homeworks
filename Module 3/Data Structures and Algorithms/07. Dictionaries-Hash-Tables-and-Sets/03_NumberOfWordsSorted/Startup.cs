// Write a program that counts how many times each word from given text file words.txt appears in it.The character casing differences should be ignored.The result words should be ordered by their number of occurrences in the text.Example:

namespace NumberOfWordsSorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        private static readonly char[] Punctuation = { ' ', ',', ':', '!', '?', '-', '.' };

        public static void Main()
        {
            // Example input: This is the TEXT. Text, text, text – THIS TEXT! Is this the text?
            var splittedInput = Console.ReadLine()?.Split(Punctuation, StringSplitOptions.RemoveEmptyEntries);

            var wordsCount = new Dictionary<string, int>();
            foreach (var word in splittedInput)
            {
                if (wordsCount.ContainsKey(word.ToLower()))
                {
                    wordsCount[word.ToLower()]++;
                }
                else
                {
                    wordsCount.Add(word.ToLower(), 1);
                }
            }

            foreach (var word in wordsCount.OrderBy(x => x.Value))
            {
                Console.WriteLine("{0} -> {1} times", word.Key, word.Value);
            }
        }
    }
}
