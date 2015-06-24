using System;
using System.Globalization;

namespace RangeExceptions
{
    class Start
    {
        static void Main()
        {
            Console.WriteLine("enter some integer: ");



            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 100)
            {
                throw new InvalidRangeException<int>(1, 100);
            }


            Console.WriteLine("enter date in format dd/MM/yyyy: ");


            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            var startDate = new DateTime(1980, 1, 1);
            var endDate = new DateTime(2013, 12, 31);

            if (date < startDate || date > endDate)
            {
                throw new InvalidRangeException<DateTime>(startDate, endDate);
            }

        }
    }
}
