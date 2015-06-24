/*
Problem 4. Compare text files

Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
Assume the files have equal number of lines.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        StreamReader firstFileReader = new StreamReader(@"..\..\test.txt", Encoding.ASCII);
        StreamReader secondFileReader = new StreamReader(@"..\..\test2.txt", Encoding.ASCII);

        using (firstFileReader)
        {
            using (secondFileReader)
            {
                string firstFileContent = firstFileReader.ReadLine();
                string secondFileContent = secondFileReader.ReadLine();
                int equal = 0;
                int diff = 0;
                while (firstFileContent != null && secondFileContent != null)
                {
                    if (firstFileContent.CompareTo(secondFileContent) == 0) equal++;
                    else diff++;
                    firstFileContent = firstFileReader.ReadLine();
                    secondFileContent = secondFileReader.ReadLine();
                }
                Console.WriteLine("{0} lines are equal", equal);
                Console.WriteLine("{0} lines are different", diff);

            }
        }
    }
}
