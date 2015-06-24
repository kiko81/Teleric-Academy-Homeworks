/*
Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
*/

using System;

class CheckBitAtPos
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter bit position to check: ");
        int p = int.Parse(Console.ReadLine());

        bool bitIs = (n & (1 << p)) != 0;
        Console.WriteLine("{0} has 1 on bit#{1} position - {2}", n, p, bitIs);
    }
}