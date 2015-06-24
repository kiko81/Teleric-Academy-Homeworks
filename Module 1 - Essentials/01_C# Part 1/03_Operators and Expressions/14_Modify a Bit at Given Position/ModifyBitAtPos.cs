/*
We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
*/

using System;

class ModifyBitAtPos
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter bit position to change: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter value of the bit#{0} (0 or 1): ", p);
        byte v = byte.Parse(Console.ReadLine());

        n = v == 1 ? /*set bit*/n = n | (1 << p) : /*unset bit*/n = n & ~(1 << p);
        
        Console.WriteLine("Your number after modification is {0}", n);
    }
}