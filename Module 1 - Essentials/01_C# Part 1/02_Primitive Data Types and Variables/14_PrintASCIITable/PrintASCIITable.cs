/*
Problem 14.* Print the ASCII Table

Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.

Note: You may need to use for-loops (learn in Internet how).
*/

using System;
using System.Text;
using System.Threading;
using System.Globalization;

class PrintASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        //first 32 symbols cannot be displayed, 33rd - space
        for (int i = 33; i <= 255; i++)
        {
            Console.WriteLine("{0} - {1}", i, (char)i);
        }
    }
}