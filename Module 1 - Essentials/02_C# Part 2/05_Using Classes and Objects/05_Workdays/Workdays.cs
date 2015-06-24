/*
Problem 5. Workdays

Write a method that calculates the number of workdays between today and given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Workdays
{
    static void Main()
    {
        DateTime[] holidays =
	{
		new DateTime(2015, 1, 1), new DateTime(2015, 3, 3), new DateTime(2015, 4, 10),
		new DateTime(2015, 4, 13), new DateTime(2015, 5, 1), new DateTime(2015, 5, 6),
		new DateTime(2015, 5, 24), new DateTime(2015, 9, 6), new DateTime(2015, 9, 22),
		new DateTime(2015, 12, 24), new DateTime(2015, 12, 25)
	};

        DateTime dateNow = DateTime.Now;

        Console.Write("Please enter a future date from today in the format yyyy-mm-dd: ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        int workDays = 0;
        while (dateNow <= date)
        {
            if (!holidays.Contains(dateNow) && dateNow.DayOfWeek != DayOfWeek.Saturday
            && dateNow.DayOfWeek != DayOfWeek.Sunday) workDays++;
            dateNow = dateNow.AddDays(1);
        }

        Console.WriteLine("there are {0} days till {2:yyyy-mm-dd}", workDays, DateTime.Now, date);

    }
}
