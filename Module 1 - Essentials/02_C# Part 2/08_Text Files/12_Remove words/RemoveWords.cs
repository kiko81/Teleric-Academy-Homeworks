/*
Problem 12. Remove words

Write a program that removes from a text file all words listed in given another text file.
Handle all possible exceptions in your methods.
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class RemoveWords
{
    static void Main()
    {
        try
        {
            string allLines = String.Join(" ", File.ReadAllLines(@"..\..\words.txt"));
            string[] allWords = allLines.Split(' ');
            using (StreamReader reader = new StreamReader(@"..\..\test.txt"))
            {
                string line = reader.ReadLine();
                using (StreamWriter writer = new StreamWriter(@"..\..\result.txt"))
                {
                    while (line != null)
                    {
                        for (int i = 0; i < allWords.Length; i++)
                        {
                            string word = "\\b" + allWords[i] + "\\b";
                            line = Regex.Replace(line, word, "");
                        }
                        writer.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.GetType().Name + ex.Message);
        }
    }
}