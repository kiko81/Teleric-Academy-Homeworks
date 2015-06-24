/*
Problem 8. Replace whole word

Modify the solution of the previous problem to replace only whole words (not strings).
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReplaceWholeWord
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\test.txt"))
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\result.txt"))
            {
                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    for (int i = line.IndexOf("start"); i != -1; i = line.IndexOf("start", i + 1))
                    {
                        if ((i - 1 < 0 || !Char.IsLetter(line[i - 1])) && (i + 5 >= line.Length) || !Char.IsLetter(line[i + 5]))
                        {
                            line = line.Insert(i, "finish").Remove(i + 6, 5);
                        }
                    }
                    writer.WriteLine(line);
                }
            }
        }
    }
}