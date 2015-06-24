/*
Problem 1. Say Hello

Write a method that asks the user for his name and prints “Hello, <name>”
Write a program to test this method.
*/

using System;

class SayHello
{
    static void Main()
    {
        string name = EnterName();
        PrintGreeting(name);
    }

    private static string EnterName()
    {
        Console.Write("Your name: ");
        string name = Console.ReadLine();
        return name;
    }

    private static void PrintGreeting(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }

}
