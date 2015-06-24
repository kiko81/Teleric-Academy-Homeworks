// Write an expression that checks if given integer is odd or even.

using System;

    class OddEvenIntegers
    {
        static void Main()
        {
            Console.Write("Write an integer: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0 )
            {
                Console.WriteLine("Number {0} is even", num);
            }
            else
            {
                Console.WriteLine("Number {0} is odd", num);
            }
        }
    }