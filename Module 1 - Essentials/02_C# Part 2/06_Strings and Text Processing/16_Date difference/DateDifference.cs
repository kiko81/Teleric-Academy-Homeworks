/*
Problem 16. Date difference

Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        Console.Write("Enter the first date [dd.MM.yyyy]: ");
        DateTime start = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
        Console.Write("Enter the second date [dd.MM.yyyy]: ");
        DateTime end = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("Distance: " + Math.Abs((end - start).TotalDays) + " days");
    }
}
