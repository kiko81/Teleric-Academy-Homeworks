/*
Problem 2. Float or Double?

Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
Write a program to assign the numbers in variables and print them to ensure no precision is lost.
*/

using System;
using System.Text;
using System.Threading;
using System.Globalization;

class FloatOrDouble
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        
        //Declaring values as strings
        string num1String = "34.567839023";
        string num2String = "12.345";
        string num3String = "8923.1234857";
        string num4String = "3456.091";

        // Checking if the string length changes after double conversion: -> to float -> back to string (Doubles which do not fit in float range will reduce in length)
       
        if (num1String == Convert.ToString(Convert.ToSingle(num2String)))
        {
            float num1 = Convert.ToSingle(num1String);
            Console.WriteLine("{0} fits in float type variable", num1);
        }
        else
        {
            double num1 = Convert.ToDouble(num1String);
            Console.WriteLine("{0} may be stored in double type variable", num1);
        }
        if (num2String == Convert.ToString(Convert.ToSingle(num2String)))
        {
            float num2 = Convert.ToSingle(num2String);
            Console.WriteLine("{0} fits in float type variable", num2);
        }
        else
        {
            double num2 = Convert.ToDouble(num2String);
            Console.WriteLine("{0} may be stored in double type variable", num2);
        }
        if (num3String == Convert.ToString(Convert.ToSingle(num3String)))
        {
            float num3 = Convert.ToSingle(num3String);
            Console.WriteLine("{0} fits in float type variable", num3);
        }
        else
        {
            double num3 = Convert.ToDouble(num3String);
            Console.WriteLine("{0} may be stored in double type variable", num3);
        }
        if (num4String == Convert.ToString(Convert.ToSingle(num4String)))
        {
            float num4 = Convert.ToSingle(num4String);
            Console.WriteLine("{0} fits in float type variable", num4);
        }
        else
        {
            double num4 = Convert.ToDouble(num4String);
            Console.WriteLine("{0} may be stored in double type variable", num4);
        }
        
        Console.Write("\nWrite your number to check: ");
        string customNum = Console.ReadLine();
        if (customNum == Convert.ToString(Convert.ToSingle(customNum)))
        {
            float num = Convert.ToSingle(customNum);
            Console.WriteLine("{0} fits in float type variable", num);
        }
        else
        {
            double num = Convert.ToDouble(customNum);
            Console.WriteLine("{0} may be stored in double type variable", num);
        }
    }
}