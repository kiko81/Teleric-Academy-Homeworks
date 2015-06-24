/*
Problem 9. Forbidden words

We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ForbiddenWords
{
    static void Main()
    {
        Console.Write("enter some text : ");  //  Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
        string text = Console.ReadLine();

        Console.Write("enter words to forbid separated by coma and space: "); // PHP, CLR, Microsoft
        var words = Console.ReadLine().Split(',', ' ').ToArray();

        var splittedText = text.Split(new char[] { '.', ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < words.Length; i++)
        {
            for (int j = 0; j < splittedText.Length; j++)
            {
                if (splittedText[j] == words[i])
                {
                    text = text.Replace(words[i], string.Empty.PadLeft(words[i].Length, '*'));
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine(text);
    }
}
