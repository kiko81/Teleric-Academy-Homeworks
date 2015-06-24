



using System;

class BiggestOf5
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Enter the fourth number: ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("Enter the fifth number: ");
        double e = double.Parse(Console.ReadLine());
        double biggest;


        if (a >= b && a >= c && a >= d && a >= e) biggest = a;
        else if (b >= c && b >= d && b >= e) biggest = b;
        else if (c >= d && c >= e) biggest = c;
        else if (d >= e) biggest = d;
        else biggest = e;

        Console.WriteLine("The biggest of these numbers is {0}", biggest);
    }
}
