/*
Problem 13. Count words

Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
Handle all possible exceptions in your methods.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class CountWords
{
    static void Main()
    {
        try
        {
            string[] words = File.ReadAllLines(@"..\..\words.txt");
            var counter = new int[words.Length];

            using (StreamReader reader = new StreamReader(@"..\..\test.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        counter[i] = counter[i] + Regex.Matches(line, "\\b" + words[i] + "\\b").Count;
                    }
                    line = reader.ReadLine();
                }
            }
            Array.Sort(counter, words);

            using (StreamWriter writer = new StreamWriter(@"..\..\result.txt"))
            {
                for (int i = words.Length - 1; i >= 0; i--)
                {
                    writer.WriteLine( words[i] + "->" + counter[i]);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.GetType().Name + ex.Message);
        }
    }
}
