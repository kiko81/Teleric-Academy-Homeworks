// Write an expression that extracts from given integer n the value of given bit at index p.

using System;

class ExtractBitFromInt
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter bit position to check: ");
        int p = int.Parse(Console.ReadLine());

        if ((n & (1 << p)) != 0)
        {
            Console.WriteLine("{0} has 1 on bit#{1} position", n, p);
        }
        else Console.WriteLine("{0} has 0 on bit#{1} position", n, p);
    }
}