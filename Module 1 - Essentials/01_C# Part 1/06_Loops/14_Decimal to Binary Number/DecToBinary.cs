/*
Problem 14. Decimal to Binary Number

Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
*/

using System;

class DecToBinary
{
    static void Main()
    {
        Console.WriteLine("Enter integer to convert to binary: ");
        long num = long.Parse(Console.ReadLine());
        int stringLenght = 0;

        // get the lenght ot the binary representation
        for (int i = 0; i < int.MaxValue; i++)
        {
            if (num - (1 << i) < 0)
            {
                stringLenght = i;
                break;
            }
        }

        // write the binary
        for (int j = 0; j <= stringLenght - 1; j++)
        {
            if (num - (1 << (stringLenght - 1 - j)) >= 0)
            {
                Console.Write("1");
                num -= (1 << (stringLenght - 1 - j));
            }
            else Console.Write("0");
        }
        Console.WriteLine();
    }
}