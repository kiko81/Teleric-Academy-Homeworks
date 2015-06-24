/*
Problem 13. Reverse sentence

Write a program that reverses the words in given sentence.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseSentence
{
    static void Main()
    {
        Console.Write("enter some text : ");  //  C# is not C++, not PHP and not Delphi!
        string text = Console.ReadLine();

        //get words with the signs
        var splittedText = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
        
        char[] signArray = { ',', ':', '!', '?', ';', '\\', '/', ' ', '-' };

        // make dict with the signs key - to which word its attached, value - the sign
        Dictionary<int, char> signs= new Dictionary<int, char>();
        for (int i = 0; i < splittedText.Length; i++)
        {
            if (signArray.Contains(splittedText[i][splittedText[i].Length - 1]))
            {
                signs.Add(i, splittedText[i][splittedText[i].Length - 1]);
                splittedText[i] = splittedText[i].Trim(signArray);
            }
        }

        Array.Reverse(splittedText);
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < splittedText.Length; i++)
        {

            result.Append(splittedText[i]); 
            if (signs.ContainsKey(i))
            {
                result.Append(signs[i]);
            }
            result.Append(' ');
        }
        Console.WriteLine(result.ToString());


       
    }
}
