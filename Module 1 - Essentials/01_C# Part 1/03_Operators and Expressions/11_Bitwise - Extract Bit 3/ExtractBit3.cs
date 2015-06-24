/*
Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.
*/

using System;

class ExtractBit3
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        //4rd pos 3 right shifted to become first AND 1
        Console.WriteLine(number >> 3 & 1);
    }
}