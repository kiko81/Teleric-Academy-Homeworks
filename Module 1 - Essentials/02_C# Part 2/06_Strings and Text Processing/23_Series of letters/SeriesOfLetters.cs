/*
Problem 23. Series of letters

Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SeriesOfLetters
{
    static void Main()
    {
        Console.Write("write some text: ");
        string text = Console.ReadLine();
        
        StringBuilder letters = new StringBuilder();

        letters.Append(text[0]);

        for (int i = 1; i < text.Length; i++)
        {
            if (text[i] != text[i - 1])
            {
                letters.Append(text[i]);
            }
        }
        Console.WriteLine(letters.ToString());
    }
}