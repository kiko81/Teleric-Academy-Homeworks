/*
Problem 15. Hexadecimal to Decimal Number

Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
*/

using System;

class HexToDecimal
{
    static void Main()
    {

        Console.WriteLine("Enter a hexadecimal number, valid 0-9, a-f, A-F:");
        string hex = Console.ReadLine();
        long number = 0;
        long pow = 1;

        for (int i = hex.Length - 1; i >= 0; i--)
        {
            int digit;
            switch (hex[i])
            {
                case 'A':
                case 'a':
                    digit = 10;
                    break;
                case 'B':
                case 'b':
                    digit = 11;
                    break;
                case 'C':
                case 'c':
                    digit = 12;
                    break;
                case 'D':
                case 'd':
                    digit = 13;
                    break;
                case 'E':
                case 'e':
                    digit = 14;
                    break;
                case 'F':
                case 'f':
                    digit = 15;
                    break;
                default: digit = hex[i] - 48;
                    break;
            }
            number += digit * pow;
            pow *= 16;
        }
        Console.WriteLine(number);
    }
}