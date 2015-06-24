/*
Problem 1. Odd lines

Write a program that reads a text file and prints on the console its odd lines.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class OddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\test.txt", Encoding.ASCII);
        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                lineNumber++;
                if (lineNumber % 2  == 1)
                {
                    Console.WriteLine(line);
                }
                line = reader.ReadLine();
            }

        }
    }
}

