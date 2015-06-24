using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class DecimalToHexadecimal
{
    static void Main()
    {
        Console.Write("number to convert: ");
        int n = int.Parse(Console.ReadLine());

        StringBuilder hex = new StringBuilder();

        while (n > 0)
        {
            switch (n % 16)
            {
                case 10: hex.Append('A'); break;
                case 11: hex.Append('B'); break;
                case 12: hex.Append('C'); break;
                case 13: hex.Append('D'); break;
                case 14: hex.Append('E'); break;
                case 15: hex.Append('F'); break;
                default: hex.Append(n % 16);
                    break;
            }
            n /= 16;            
        }
        Console.WriteLine("hexadecimal presenation: 0x" + new string(hex.ToString().ToCharArray().Reverse().ToArray()));
    }
}