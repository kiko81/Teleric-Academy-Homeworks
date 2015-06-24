/*
Problem 6. Save sorted names

Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class SaveSortedNames
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\input.txt"))
        {
            List<string> names = new List<string>();
            for (string currName = reader.ReadLine(); currName != null; currName = reader.ReadLine())
            {
                names.Add(currName);
            }
            names.Sort();
            using (StreamWriter output = new StreamWriter(@"..\..\output.txt"))
            {
                foreach (string name in names)
                {
                    output.WriteLine(name);
                }
            }
        }
    }
}