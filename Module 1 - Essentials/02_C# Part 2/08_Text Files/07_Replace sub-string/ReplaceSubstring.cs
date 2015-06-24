/*
Problem 7. Replace sub-string

Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
Ensure it will work with large files (e.g. 100 MB).
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReplaceSubstring
{
    static void Main()
    {
        using (StreamWriter writer = new StreamWriter(@"..\..\output.txt"))
        {
            using (StreamReader reader = new StreamReader(@"..\..\test.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Replace("start", "finish");
                    writer.WriteLine(line);
                }
            }
        }
    }
}