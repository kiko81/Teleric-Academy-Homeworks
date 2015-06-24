/*
Problem 13. Binary to Decimal Number

Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
*/

using System;

class BinToDec
{
    static void Main()
    {
        Console.WriteLine("Enter binary number: ");
        string bin = Console.ReadLine();

        long number = 0;

        for (int i = bin.Length - 1; i >= 0; i--)
        {
            if (bin[i] == 49) // 49 is unicode code of 1
            {
                number += (1 << (bin.Length - 1 - i));
            }
        }
        Console.WriteLine(number);
    }
}