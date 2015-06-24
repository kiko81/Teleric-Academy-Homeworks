// Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class BitsExchange
{
    static void Main()
    {

        Console.Write("Enter a number: ");
        ulong number = uint.Parse(Console.ReadLine());

        //7 = 111 in binary
        ulong pos3to5 = number & (7 << 3);
        ulong pos24to26 = number & (7 << 24);

        // first excluding the equal bits with the masked values (XOR), after that applying swapped places masks
        number = number ^ (pos3to5 | pos24to26) | (pos24to26 >> 21) | (pos3to5 << 21);
        Console.WriteLine(number);
    }
}