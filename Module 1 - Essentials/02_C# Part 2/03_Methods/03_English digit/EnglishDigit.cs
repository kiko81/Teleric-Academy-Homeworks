/*
Problem 3. English digit

Write a method that returns the last digit of given integer as an English word.
*/

using System;

class EnglishDigit
{
    static void Main()
    {
        Console.Write("enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(LastDigitWord(n));
    }

    private static string LastDigitWord(int n)
    {
        string[] word = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        string lastDigitWord = word[n % 10];
        return lastDigitWord;
    }
}