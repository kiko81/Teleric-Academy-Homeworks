/*
Problem 1. Declare Variables

Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
Submit the source code of your Visual Studio project as part of your homework submission.
*/

using System;

class DeclareVariables
{
    static void Main()
    {

        ushort num1 = 52130;
        sbyte num2 = -115;
        int num3 = 4825932;
        byte num4 = 97;
        short num5 = -10000;

        Console.WriteLine("number {0} fits in {1} type variable", num1, num1.GetType());
        Console.WriteLine("number {0} may be stored in {1} type variable", num2, num2.GetType());
        Console.WriteLine("number {0} fits in {1} type variable", num3, num3.GetType());
        Console.WriteLine("number {0} may be stored in {1} type variable", num4, num4.GetType());
        Console.WriteLine("number {0} fits in {1} type variable", num5, num5.GetType());
    }
}