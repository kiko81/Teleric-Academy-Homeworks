/*
Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
The first and the second sequence of bits may not overlap.
*/

using System;

class BitExchange_v2
{
    
    
    static void Main()
    {
        Console.Write("Enter a number: ");
        long number = long.Parse(Console.ReadLine());
        Console.Write("Enter p index: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter q index: ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());           
        
		 	
        if (Math.Abs(p - q) <= k - 1 || p > 32 || q > 32 || p < 0 || q < 0)
        {
            Console.WriteLine("Overlapping or out of range");
        }
        else
        {
            // all bits to k-1 bit are 1 - for masking purposes
            int maskNum = (1 << k) - 1; 
            
            long posP = number & (maskNum << p);
            long posQ = number & (maskNum << q);
            // first excluding the equal bits with the masked values (XOR), after that applying swapped places masks
            if (p < q)
            {
                number = number ^ (posP | posQ) | (posQ >> (q - p)) | (posP << (q - p));
            }
            else
            {
                number = number ^ (posP | posQ) | (posQ << (p - q)) | (posP >> (p - q));
            }
            
            Console.WriteLine(number);
        }
    }
}