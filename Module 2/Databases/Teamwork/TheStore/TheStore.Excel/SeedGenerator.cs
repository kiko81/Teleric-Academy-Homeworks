namespace TheStore.Excel
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using TheStore.Context;

    public class SeedGenerator
    {
        private const int NumberOfReports = 200;

        private readonly string[] towns = { "Sofia", "Plovdiv", "Varna", "Bourgas", "Pleven", "Haskovo", "Kyustendil" };
        private readonly Random random = new Random();

        public void Generate()
        {
            var seeder = new Seeder();
            var db = new StoreContext();
            var laptops = db.Laptops.ToList();
            var productsCount = laptops.Count;

            for (int report = 0; report < NumberOfReports; report++)
            {
                if (report % 10 == 0)
                {
                    Console.Write("...");
                }

                var date = new DateTime(this.random.Next(2002, 2016), this.random.Next(1, 13), this.random.Next(1, 29));
                var productsToBeAdded = new List<SalesInfo>();

                productsToBeAdded.AddRange(laptops.Select((x) => new SalesInfo(x.Id, x.Price, this.random.Next(1, 10))));

               seeder.Seed(this.towns[this.random.Next(0, this.towns.Length)], date, "Sales/", productsToBeAdded);
            }
        }
    }
}
