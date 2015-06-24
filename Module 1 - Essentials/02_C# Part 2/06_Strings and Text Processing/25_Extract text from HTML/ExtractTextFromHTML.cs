/*
Problem 25. Extract text from HTML

Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class ExtractTextFromHTML
{
    static void Main()
    {
        Console.WriteLine("paste some HTML text: "); // <html><head><title>News</title></head><body><p><a href=\"http://academy.telerik.com\">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body></html> 
        string text = Console.ReadLine();

        MatchCollection tags = Regex.Matches(text, @"((?<=^|>)[^><]+?(?=<|$))");
        int count = 1;

        foreach (Match tag in tags)
        {
            if (count == 1)
            {
                Console.WriteLine("Title: {0}", tag);
                Console.Write("Text: ");
            }
            else
            {
                Console.Write(tag + " ");
            }
            count++;
        }
        Console.WriteLine();
    }
}
