/*
Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive
*/

using System;

class PrimeNrCheck
{
    static void Main()
    {
    Input:
        Console.Write("Write a number to check for primality (upto 100): ");
        int num;
        if (!int.TryParse(Console.ReadLine(), out num) || num < 1 || num > 100)
        {
            Console.WriteLine("Wrong input number, try again");
            goto Input;
        }

        if (num == 1)
        {
            Console.WriteLine("Number {0} is prime", num);
        }
        else if (num % 2 == 0)
        {
            Console.WriteLine("Number {0} is even, divides to 2", num);
        }
        else
        {
            //no need to check even numbers
            for (int i = 3; i <= Math.Ceiling(Math.Sqrt(num)); i += 2)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Number {0} is not prime, it divides to {1}", num, i);
                    return;
                }               
            }
            Console.WriteLine("Number {0} is prime", num);
        }
    }
}
