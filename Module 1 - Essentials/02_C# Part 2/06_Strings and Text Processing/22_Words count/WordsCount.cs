/*
Problem 22. Words count

Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WordsCount
{
    static void Main()
    {
        Console.Write("enter some text with repeating words: ");  
        string text = Console.ReadLine();

        char[] signArray = { ',', '!', '#', '$', '%', '&', '*', '+', '-', '/', '=', '?', '^', '_', '`', '{', '|', '}', '~', '\'', ' ', '.', '\\' };

        var splittedText = text.Split(signArray, StringSplitOptions.RemoveEmptyEntries);

        var wordCount = new Dictionary<string, int>();

        foreach (string word in splittedText)
        {
            if (wordCount.ContainsKey(word))
            {
                wordCount[word]++;
            }
            else
            {
                wordCount.Add(word, 1);
            }
        }
        foreach (var word in wordCount)
        {
            Console.WriteLine("{0} - {1} times", word.Key, word.Value);
        }
    }
}