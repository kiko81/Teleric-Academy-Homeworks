/*
Problem 9. Delete odd lines

Write a program that deletes from given text file all odd lines.
The result should be in the same file.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DeleteOddLines
{
    static void Main()
    {
        //placed test.txt in archive - "extract here" works fine
        List<string> evenLines = new List<string>();
        using (StreamReader reader = new StreamReader(@"..\..\test.txt"))
        {
            int lineNum = 1;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineNum % 2 == 0)
                {
                    evenLines.Add(line);
                }
                lineNum++;
                line = reader.ReadLine();
            }
        }
        using (StreamWriter writer = new StreamWriter(@"..\..\test.txt"))
        {
            for (int i = 0; i < evenLines.Count; i++)
            {
                writer.WriteLine(evenLines[i]);
            }
        }
    }
}