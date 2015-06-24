/*
Problem 2. Concatenate text files

Write a program that concatenates two text files into another text file.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class ConcatenateTextFiles
{
    static void Main()
    {
        StreamReader firstFileReader = new StreamReader(@"..\..\test.txt", Encoding.ASCII);
        StreamReader secondFileReader = new StreamReader(@"..\..\test2.txt", Encoding.ASCII);
        StreamWriter streamWriter = new StreamWriter(@"..\..\result.txt", true);

        using (streamWriter)
        {
            streamWriter.WriteLine("1st file");
            using (firstFileReader)
            {
                string line = firstFileReader.ReadLine();
                while (line != null)
                {
                    streamWriter.WriteLine(line);
                    line = firstFileReader.ReadLine();
                }

            }
            streamWriter.WriteLine("2nd file");
            using (secondFileReader)
            {
                string line = secondFileReader.ReadLine();
                while (line != null)
                {
                    streamWriter.WriteLine(line);
                    line = secondFileReader.ReadLine();
                }
            }
        }
    }
}