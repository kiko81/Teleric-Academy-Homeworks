namespace TheStore.Sqlite
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var db = new CombinationsContext();

            db.Combinations.Add(new Combinations { LaptopId = 1, MouseId = 1 });
            db.SaveChanges();

            Console.WriteLine(db.Combinations.Count());
        }
    }
}
