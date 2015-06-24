/*
Problem 15.* Age after 10 Years

Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
*/

using System;

class AgeAfterTenYears
{
    static void Main()
    {
        byte day, month;
        short year;

    Day:
        Console.Write("Please enter your day of birth: ");
        string inputDay = Console.ReadLine();

        while ((!byte.TryParse(inputDay, out day)) || (day < 1) || (day > 31))
        {
            Console.WriteLine("Not a valid range or number, try again. Valid input 1-31\n");
            goto Day;
        }
        Console.WriteLine("OK\n");

    Month:
        Console.Write("And the month: ");
        string inputMonth = Console.ReadLine();

        while ((!byte.TryParse(inputMonth, out month)) || (month < 1) || (month > 12))
        {
            Console.WriteLine("Not a valid range or number, try again. Valid input 1-12\n");
            goto Month;
        }
        if (month == 4 || month == 6 || month == 9 || month == 11 && day > 30)
        {
            Console.WriteLine("The selected month has no more than 30 days.\n");
            goto Day;
        }
        if (month == 2 && day > 29)
        {
            Console.WriteLine("The month of February has no more than 29 days.\n");
            goto Day;
        }

        Console.WriteLine("OK\n");

    Year:
        Console.Write("And the year of your birth: ");
        string inputYear = Console.ReadLine();

        while ((!short.TryParse(inputYear, out year)) || (year < 1900) || (year > DateTime.Now.Year))
        {
            Console.WriteLine("Not a valid range or number, try again. Valid input 1900-Now\n");
            goto Year;
        }
        if (year % 4 != 0 && month == 2 && day == 29)
        {
            Console.WriteLine("That year the month of February had no more than 28 days.\n");
            goto Day;
        }

        Console.WriteLine("\nYour birth date is {0}/{1}/{2}\n", day, month, year);

        if (DateTime.Now.Month > month)
        {
            Console.WriteLine("Now You are {0} years old\n", DateTime.Now.Year - year);
            Console.WriteLine("In 10 years You'll be {0} years old\n", DateTime.Now.Year - year + 10);
        }
        if (DateTime.Now.Month < month)
        {
            Console.WriteLine("Now You are {0} years old\n", DateTime.Now.Year - year - 1);
            Console.WriteLine("In 10 years You'll be {0} years old\n", DateTime.Now.Year - year + 9);
        }
        else if (DateTime.Now.Day > day)
        {
            Console.WriteLine("Now You are {0} years old\n", DateTime.Now.Year - year);
            Console.WriteLine("In 10 years You'll be {0} years old\n", DateTime.Now.Year - year + 10);
        }
        if (DateTime.Now.Day < day)
        {
            Console.WriteLine("Now You are {0} years old\n", DateTime.Now.Year - year - 1);
            Console.WriteLine("In 10 years You'll be {0} years old\n", DateTime.Now.Year - year + 9);
        }
        else
        {
            Console.WriteLine("\t!!!Happy Birthday!!!\n\nNow You are {0} years old\n", DateTime.Now.Year - year);
            Console.WriteLine("In 10 years You'll be {0} years old\n", DateTime.Now.Year - year + 10);
        }
    }
}