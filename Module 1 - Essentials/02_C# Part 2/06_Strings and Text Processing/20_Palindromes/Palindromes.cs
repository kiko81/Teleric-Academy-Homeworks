/*
Problem 20. Palindromes

Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Palindromes
{
    static void Main()
    {
        Console.Write("enter some text : ");  //  ABBA, lamal, exe
        string text = Console.ReadLine();
        
        char[] signArray = { ',', '!', '#', '$', '%', '&', '*', '+', '-', '/', '=', '?', '^', '_', '`', '{', '|', '}', '~', '\'', ' ', '.', '\\' };

        var splittedText = text.Split(signArray, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < splittedText.Length; i++)
        {
            bool isPalindrome = true;
            for (int j = 0; j < splittedText[i].Length / 2; j++)
            {
                if (splittedText[i][i] != splittedText[i][splittedText[i].Length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome && splittedText[i].Length > 1)
            {
                Console.WriteLine(splittedText[i]);
            }
        }
    }
}
