/*
Problem 4. Hexadecimal to decimal

Write a program to convert hexadecimal numbers to their decimal representation.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal number, valid 0-9, a-f, A-F:");
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
