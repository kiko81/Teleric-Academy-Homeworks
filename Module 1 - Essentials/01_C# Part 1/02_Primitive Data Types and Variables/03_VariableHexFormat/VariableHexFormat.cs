/*
Problem 3. Variable in Hexadecimal Format

Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
Use Windows Calculator to find its hexadecimal representation.
Print the variable and ensure that the result is 254.
*/

using System;

class VariableHexFormat
{
    static void Main()
    {
        int num = 254;
        string hexValue = num.ToString("X"); //converts from decimal to hex format
        Console.WriteLine("The hexadecimal representation of number {0} is 0x{1} ", int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber), hexValue);

        // or
        int hex = 0xFE;
        Console.WriteLine("FE in hexadecimal is {0} in decimal", hex);
    }
}
