/*
Problem 12. Null Values Arithmetic

Create a program that assigns null values to an integer and to a double variable.
Try to print these variables at the console.
Try to add some number or the null literal to these variables and print the result.
*/

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? nullInt = null;
        double? nullDouble = null;

        Console.WriteLine("Integer with value Null is " + nullInt);
        Console.WriteLine("Double with value Null is " + nullDouble);

        int addToInt = 55;
        double addToDbl = 653.65;
        Console.WriteLine("The sum of null integer with {0} is: {1} ", addToInt, nullInt + 5);
        Console.WriteLine("The sum of null double with {0} is: {1} ", addToDbl, nullDouble + 5.55);
    }
}