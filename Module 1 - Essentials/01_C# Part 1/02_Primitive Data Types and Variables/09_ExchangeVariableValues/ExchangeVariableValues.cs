/*
Problem 9. Exchange Variable Values

Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
Print the variable values before and after the exchange.
*/

using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5, b = 10;

        Console.WriteLine("Values before the swap for a: {0}, for b: {1}", a, b);
        a ^= b;
        b ^= a;
        a ^= b;
        Console.WriteLine("Values after the swap for a: {0}, for b: {1}", a, b);
    }
}