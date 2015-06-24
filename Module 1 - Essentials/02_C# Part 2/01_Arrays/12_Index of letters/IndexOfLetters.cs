/*
Problem 12. Index of letters

Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.
*/

using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] array = new char[('z' - 'a' + 1) * 2];
        for (int i = 0; i < array.Length; i++)
        {
            if (i <= ('z' - 'a' + 1)) array[i] = (char)(i + 65); // A - 65 in unicode table
            else array[i] = (char)(i + 71); // a - 97 in unicode            
        }
        Console.Write("enter word to read");
        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (word[i] == array[j])
                {
                    Console.WriteLine("Letter {0} has index {1} in the letter character array", word[i], j);
                    break;
                }
            }
        }
    }
}