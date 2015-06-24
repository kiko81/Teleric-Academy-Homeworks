/*
Problem 14. Word dictionary

A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WordDictionary
{
    static void Main()
    {
        Dictionary<string, string> dict = new Dictionary<string, string>
		{
			{".NET", "platform for applications from Microsoft"},
			{"CLR", "managed execution environment for .NET"},
			{"NAMESPACE", "hierarchical organization of classes"}
		};

        Console.WriteLine("available words: {0}", string.Join(", ", dict.Keys));

        Console.Write("enter word: ");
        string word = Console.ReadLine().ToUpper();

        Console.WriteLine(dict.ContainsKey(word) ? string.Format("{0} - {1}", word, dict[word])
                          : string.Format("Dictionary does not contain word \"{0}\"", word));
    }
}
