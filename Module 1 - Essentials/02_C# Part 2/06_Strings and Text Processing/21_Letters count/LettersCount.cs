/*
Problem 21. Letters count

Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LettersCount
{
    static void Main()
    {
        Console.Write("enter some text : ");
        string text = Console.ReadLine();
        char[] letters = new char[255];

        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsLetter(text[i]))
            {
                letters[text[i]]++;
            }
        }

        for (int i = 65; i <= 122; i++)
        {
            if (char.IsLetter((char)i) && letters[i] > 0)
            {
                Console.WriteLine("{0}- {1} times", (char)i, (int)letters[i]);
            }
        }
    }
}
