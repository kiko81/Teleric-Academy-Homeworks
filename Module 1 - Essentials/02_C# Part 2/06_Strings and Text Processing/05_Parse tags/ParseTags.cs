/*
Problem 5. Parse tags

You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ParseTags
{
    static void Main()
    {
        //Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
        string text = Console.ReadLine();
        string open = "<upcase>";
        string close = "</upcase>";
        StringBuilder edited = new StringBuilder();
        for (int i = 0; i < text.Length; i++)
        {
            if ((i + open.Length + close.Length) <= text.Length && text.Substring(i, open.Length) == open)
            {
                i += open.Length;
                while (text.Substring(i, close.Length) != close)
                {
                    edited.Append(text[i].ToString().ToUpper());
                    i++;
                }
                i += close.Length - 1;
            }
            else edited.Append(text[i]); 
        }
        Console.WriteLine(edited.ToString());
    }
}