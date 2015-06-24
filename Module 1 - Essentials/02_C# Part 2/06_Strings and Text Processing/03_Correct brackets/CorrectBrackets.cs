/*
Problem 3. Correct brackets

Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CorrectBrackets
{
    static void Main()
    {
        Console.Write("Enter an expression: ");
        string expression = Console.ReadLine();

        Console.WriteLine(" brackets are correct: " + BracketsAreCorrect(expression));
    }

    private static bool BracketsAreCorrect(string expression)
    {
        int brackets = 0;

        foreach (var sign in expression)
        {
            if (sign == '(')
                ++brackets;
            else if (sign == ')')
                --brackets;

            if (brackets < 0)
                return false;
        }

        return brackets == 0;
    }
}
