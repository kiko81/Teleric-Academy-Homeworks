/*
Problem 9. Play with Int, Double and String

Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.
*/

using System;

class IntDblStr
{
    static void Main()
    {
        Input:
        Console.Write("Enter number 1-3: 1 for int, 2 for double and 3 for string ");
        string choice = Console.ReadLine();
        
        switch (choice)
        {
            case "1":
                InputInt:  
                Console.Write("Enter integer: ");
                int value;
                while (!int.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("Not an integer, please enter again");
                    goto InputInt;
                }
                Console.WriteLine(value + 1);
                break;
            case "2":
                InputDbl:  
                Console.Write("Enter number: ");
                double value2;
                while (!double.TryParse(Console.ReadLine(), out value2))
                {
                    Console.WriteLine("Not a number, please enter again");
                    goto InputDbl;
                }
                Console.WriteLine(value2 + 1);
                break;
            case "3":
                Console.Write("Write anything: ");
                string value3 = Console.ReadLine();
                Console.WriteLine(value3 + "*");
                break;
            default:
                Console.WriteLine("Not a valid input, please enter 1, 2 or 3");
                goto Input;
                break;
        }
    }
}