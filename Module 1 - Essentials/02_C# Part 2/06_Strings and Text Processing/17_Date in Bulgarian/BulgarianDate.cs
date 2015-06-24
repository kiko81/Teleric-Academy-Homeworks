using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class BulgarianDate
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.Write("Enter the date (dd.MM.yyyy HH:mm:ss): ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy H:m:s", CultureInfo.GetCultureInfo("BG-bg"));
        date = date.AddHours(6.5);
        Console.WriteLine(date.ToString("dd.MM.yyyy HH:mm:ss dddd"), CultureInfo.GetCultureInfo("BG-bg"));
    }
}
