/*
Problem 10.* Beer Time

A beer time is after 1:00 PM and before 3:00 AM.
Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.
*/

using System;
using System.Globalization;


class BeerTime
{
    static void Main()
    {
        
        Input:
        Console.Write("Enter time in the following format hh:mm tt: ");
        DateTime time;
        while (!DateTime.TryParseExact(Console.ReadLine(), "h:mm tt", CultureInfo.CreateSpecificCulture("en-US"), DateTimeStyles.None, out time))
        {
            Console.WriteLine("invalid time \n");
            goto Input;
        }

                
        if (time.TimeOfDay >= new TimeSpan(13, 0, 0) || time.TimeOfDay <= new TimeSpan(3, 0, 0))
        {
            Console.WriteLine("beer time");
        }
        else
        {
            Console.WriteLine("non-beer time");
        }
    }
}