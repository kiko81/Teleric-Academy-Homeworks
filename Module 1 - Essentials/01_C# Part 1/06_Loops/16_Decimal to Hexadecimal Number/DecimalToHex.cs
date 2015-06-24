



using System;

class DecimalToHex
{
    static void Main()
    {
        Console.WriteLine("Enter integer to convert to hexadecimal: ");
        long num = long.Parse(Console.ReadLine());
        string hex = string.Empty;
        string[] digits = new string[16] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

        while (num >= 16)
        {
            hex = digits[(num % 16)] + hex;
            num /= 16;
        }

        hex = digits[num] + hex;
        Console.WriteLine(hex);
    }
}