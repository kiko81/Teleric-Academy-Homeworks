/*
Problem 5. Hexadecimal to binary

Write a program to convert hexadecimal numbers to binary numbers (directly).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class HexadecimalToBinary
{
    static void Main()
    {
        Console.Write("Enter hexadecimal number, valid 0-9, a-f, A-F:");
        string hex = Console.ReadLine();

        char[] hexArray = hex.ToUpper().ToCharArray();
        StringBuilder bin = new StringBuilder();
       
        for (int i = 0; i < hexArray.Length; i++)
        {
            switch (hexArray[i])
            {  
                case '0': bin.Append("0000"); break;
                case '1': bin.Append("0001"); break;
                case '2': bin.Append("0010"); break;
                case '3': bin.Append("0011"); break;
                case '4': bin.Append("0100"); break;
                case '5': bin.Append("0101"); break;
                case '6': bin.Append("0110"); break;
                case '7': bin.Append("0111"); break;
                case '8': bin.Append("1000"); break;
                case '9': bin.Append("1001"); break;
                case 'A': bin.Append("1010"); break;
                case 'B': bin.Append("1011"); break;
                case 'C': bin.Append("1100"); break;
                case 'D': bin.Append("1101"); break;
                case 'E': bin.Append("1110"); break;
                case 'F': bin.Append("1111"); 
                    break;
            }
        }
        Console.WriteLine("binary representation: " + bin.ToString().TrimStart('0'));
    }
}
