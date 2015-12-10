// Write a program that finds a set of words(e.g. 1000 words) in a large text(e.g. 100 MB text file).
// * Print how many times each word occurs in the text.
// * Hint: you may find a C# trie in Internet.

namespace FindWords
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Text;

    using Trie;

    public class Startup
    {
        public static void Main()
        {
            Trie<int> trie = new Trie<int>();

            BuildUp(@"../../Lorem Ipsum.txt", trie);

            LookUp("lorem", trie);
            LookUp("ipsum", trie);
            LookUp("amet", trie);
        }

        private static void BuildUp(string fileName, Trie<int> trie)
        {
            IEnumerable<WordAndLine> allWordsInFile = GetWordsFromFile(fileName);
            foreach (WordAndLine wordAndLine in allWordsInFile)
            {
                trie.Add(wordAndLine.Word, wordAndLine.Line);
            }
        }

        private static void LookUp(string searchString, Trie<int> trie)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Look-up for string '{0}'", searchString);

            var result = trie.Retrieve(searchString).ToArray();

            string matchesText = string.Join(",", result);
            int matchesCount = result.Count();

            if (matchesCount == 0)
            {
                Console.WriteLine("No matches found.");
            }
            else
            {
                Console.WriteLine(" {0} matches found. \tLines: {1}", matchesCount, matchesText);
            }
        }

        private static IEnumerable<WordAndLine> GetWordsFromFile(string file)
        {
            using (StreamReader reader = File.OpenText(file))
            {
                Console.WriteLine("Processing file {0} ...", file);
                var lineNo = 0;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    lineNo++;
                    IEnumerable<string> words = GetWordsFromLine(line);
                    foreach (string word in words)
                    {
                        yield return new WordAndLine { Line = lineNo, Word = word };
                    }
                }

                Console.WriteLine("Lines:{0}", lineNo);
            }
        }

        private static IEnumerable<string> GetWordsFromLine(string line)
        {
            var word = new StringBuilder();
            foreach (char ch in line)
            {
                if (char.IsLetter(ch))
                {
                    word.Append(ch);
                }
                else
                {
                    if (word.Length == 0)
                    {
                        continue;
                    }

                    yield return word.ToString();
                    word.Clear();
                }
            }
        }

        private struct WordAndLine
        {
            public int Line;
            public string Word;
        }
    }
}
