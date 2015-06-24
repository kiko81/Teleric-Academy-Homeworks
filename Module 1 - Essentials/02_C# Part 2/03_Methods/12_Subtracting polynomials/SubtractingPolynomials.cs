/*
Problem 12. Subtracting polynomials

Extend the previous program to support also subtraction and multiplication of polynomials.
*/

using System;
using System.Linq;

class SubtractingPolynomials
{
    static Random r = new Random();

    static void Main()
    {
        Console.Write("first polynom Max power: ");
        int firstMaxPow = int.Parse(Console.ReadLine());
        int[] array1 = CreateCoefs(firstMaxPow);
        PrintPolynomial(array1);
        
        Console.Write("second polynom Max power: ");
        int secondMaxPow = int.Parse(Console.ReadLine());
        int[] array2 = CreateCoefs(secondMaxPow);
        PrintPolynomial(array2);
        
        Console.WriteLine("substraction of the polynomials:");
        PrintPolynomial(SubstractCoeficents(array1, array2));
        
        Console.WriteLine("multiplication of the polynomials:");
        PrintPolynomial(Multiply(array1, array2));
       
    }

    private static int[] Multiply(int[] array1, int[] array2)
    {
        var multiplyArray = new int[array1.Length + array2.Length - 1];
        for (int i = 0; i < array1.Length; i++)
        {
            for (int j = 0; j < array2.Length; j++)
            {
                multiplyArray[i + j] += (array2[j] * array1[i]);
            }
        }
        return multiplyArray;
    }

    private static int[] SubstractCoeficents(int[] array1, int[] array2)
    {
        var substractArray = new int[Math.Max(array1.Length, array2.Length)];
        for (int i = 0; i < Math.Min(array1.Length, array2.Length); i++)
        {
            substractArray[i] = array1[i] - array2[i];
        }
        if (array1.Length > array2.Length)
        {
            for (int i = array2.Length; i < array1.Length; i++)
            {
                substractArray[i] = array1[i];
            }
        }
        else
        {
            for (int i = array1.Length; i < array2.Length; i++)
            {
                substractArray[i] = -array2[i];
            }
        }
        return substractArray;
    }

    private static int[] CreateCoefs(int maxPow)
    {
        int[] array = Enumerable
            .Repeat(0, maxPow + 1)
            .Select(i => r.Next(-10, 10))
            .ToArray();
        Console.WriteLine("coeficents - random {-10, 10}: " + string.Join(", ", array));
        return array;
    }

    private static void PrintPolynomial(int[] array)
    {
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (array[i] == 0)
            {
                continue;
            }
            if (i == array.Length - 1)
            {
                if (Math.Abs(array[i]) == 1) Console.Write("{0}x^{1} ", array[i] > 0 ? "" : "-", i);
                else Console.Write("{0}{1}x^{2} ", array[i] > 0 ? "" : "-", Math.Abs(array[i]), i);
            }
            else if (i == 0)
            {
                if (array[i] < 0) Console.Write("{0} {1} ", "-", -array[i]);
                else Console.Write("{0} {1} ", "+", array[i]);
            }
            else if (i == 1)
            {
                if (Math.Abs(array[i]) == 1) Console.Write("{0} x ", array[i] > 0 ? "+" : "-");
                else Console.Write("{0} {1}x ", array[i] > 0 ? "+" : "-", Math.Abs(array[i]));
            }
            else
            {
                if (Math.Abs(array[i]) == 1)
                {
                    if (array[i] < 0) Console.Write("{0} x^{1} ", "-", i);
                    else Console.Write("{0} x^{1} ", "+", i);
                }
                else
                {
                    if (array[i] < 0) Console.Write("{0} {1}x^{2} ", "-", -array[i], i);
                    else Console.Write("{0} {1}x^{2} ", "+", array[i], i);
                }
                
            }
        }
        Console.WriteLine("\n");
    }
}