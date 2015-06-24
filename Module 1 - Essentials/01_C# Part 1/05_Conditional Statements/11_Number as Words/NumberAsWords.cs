/*
Problem 11.* Number as Words

Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
*/

using System;

class NumberAsWords
{
    static void Main()
    {
        Console.Write("Enter 3 digit integer: ");
        int number = int.Parse(Console.ReadLine());

        string x = " hundred";
        string stringA, stringB, stringC, stringNum;
        
        // extract each digit - abc
        int a = number / 100;
        int b = (number / 10) % 10;
        int c = number % 10;
      
        // assign strings to digits
        switch (a)
        {
            case 1: stringA = "one" + x; break;
            case 2: stringA = "two" + x; break;
            case 3: stringA = "three" + x; break;
            case 4: stringA = "four" + x; break;
            case 5: stringA = "five" + x; break;
            case 6: stringA = "six" + x; break;
            case 7: stringA = "seven" + x; break;
            case 8: stringA = "eight" + x; break;
            case 9: stringA = "nine" + x;
                break;
            default: stringA = "";
                break;
        }

        if (b == 1)
        {
            stringC = "";
            switch (c)
            {
                case 1: stringB = "eleven"; break;
                case 2: stringB = "twelve"; break;
                case 3: stringB = "thirteen"; break;
                case 4: stringB = "fourteen"; break;
                case 5: stringB = "fifteen"; break;
                case 6: stringB = "sixteen"; break;
                case 7: stringB = "seventeen"; break;
                case 8: stringB = "eighteen"; break;
                case 9: stringB = "nineteen";
                    break;
                default: stringB = "ten";
                    break;
            }
        }

        else
        {
            switch (b)
            {
                case 2: stringB = "twenty "; break;
                case 3: stringB = "thirty "; break;
                case 4: stringB = "fourty "; break;
                case 5: stringB = "fifty "; break;
                case 6: stringB = "sixty "; break;
                case 7: stringB = "seventy "; break;
                case 8: stringB = "eighty "; break;
                case 9: stringB = "ninety ";
                    break;
                default: stringB = "";
                    break;
            }

            switch (c)
            {
                case 1: stringC = "one"; break;
                case 2: stringC = "two"; break;
                case 3: stringC = "three"; break;
                case 4: stringC = "four"; break;
                case 5: stringC = "five"; break;
                case 6: stringC = "six"; break;
                case 7: stringC = "seven"; break;
                case 8: stringC = "eight"; break;
                case 9: stringC = "nine";
                    break;
                default: stringC = "";
                    break;
            }
        }

        // cases
        if (b == 0 && c == 0)
        {
            if (a == 0) stringNum = "zero";          
            else stringNum = stringA;
        }
        else if (a == 0) stringNum = stringB + stringC;
        else stringNum = stringA + " and " + stringB + stringC;

        // Output with capitalizing 1st letter 
        Console.WriteLine(char.ToUpper(stringNum[0]) + stringNum.Substring(1));
    }
}