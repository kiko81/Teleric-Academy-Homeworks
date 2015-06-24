/*
The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
*/

using System;

    class GravitationMoon
    {
        static void Main()
        {
            Console.Write("Your weight is: ");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Yoru weight on the Moon will be {0}", weight * .17);
        }
    }