/*
Problem 8. Extract sentences

Write a program that extracts from a given text all sentences containing given word.

Consider that the sentences are separated by . and the words – by non-letter symbols.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("enter some sentences, separated by . : ");
        //  We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
        string text = Console.ReadLine();
        var sentences = text.Split('.', '!', '?').ToArray();
        Console.Write("enter word to search: "); //in
        string word = Console.ReadLine();
        int counter = 0;
        for (int i = 0; i < sentences.Length; i++)
        {
            var words = sentences[i].Split(' ', ',', ':', ';', '-', '/', '\\').ToArray();
            if (words.Contains(word)) counter++;
        }
        Console.WriteLine("{0} sentences contain the word", counter);
    }
}