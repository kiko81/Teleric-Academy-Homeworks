/*
Problem 7. Encode/decode

Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EncodeDecode
{
    static void Main()
    {
        string text = Console.ReadLine();
        string key = Console.ReadLine();
        var chars = text.ToCharArray();

        for (int i = 0; i < text.Length; i++)
        {
            for (int j = 0; j < key.Length; j++)
            {
                chars[i] ^= key[j];
            }
            i += key.Length - 1;
        }
        text = new string(chars);
        Console.WriteLine(text);
    }
}
