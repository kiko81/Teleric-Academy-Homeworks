/*
Problem 19. Dates from text in Canada

Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
Display them in the standard date format for Canada.
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class DatesInCanada
{
    static void Main()
    {
        Console.Write("write some text containing DD.MM.YYYY");
        string text = Console.ReadLine();

        DateTime date;

        foreach (var item in Regex.Matches(text,@"\d+\.\d+\.\d+"))
        {
            string[] dateArr = item.ToString().Split('.');
            date = new DateTime(int.Parse(dateArr[2]), int.Parse(dateArr[1]), int.Parse(dateArr[0]));
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
            Console.WriteLine(date.ToString("dddd, MMMM dd, yyyy h:mm:ss tt"));
    }
}