/*
Problem 10. Unicode characters

Write a program that converts a string to a sequence of C# Unicode character literals.
Use format strings.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UnicodeCharacters
{
    static void Main()
    {
        string unicode = string.Empty;
        foreach (int ch in Console.ReadLine())
        {
            unicode += string.Format("\\u" + ch.ToString("X").PadLeft(4, '0'));
        }
        Console.WriteLine(unicode);
    }
}