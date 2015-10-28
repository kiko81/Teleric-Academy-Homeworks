namespace TheStore.MySql
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using TheStore.Context;
    using TheStore.MySql.Models;

    public class MySqlSeed
    {
        public static void Seed(MySqlData mySqlData)
        {
            var db = new StoreContext();

            var reports = db.Sales
                .Select(s => new SalesReport
                {
                    Town = s.Town.Name,
                    Date = s.Date,
                    LaptopId = s.LaptopId,
                    Quantity = s.Quantity,
                    Sum = s.Laptop.Price * s.Quantity
                })
                .ToList();

            Console.WriteLine("Seeding of Sales entries into MySql Db initialized.");
            //// mySqlData.SalesReport.DeleteAllReports();
            mySqlData.SalesReport.AddMany(reports);
            mySqlData.SalesReport.SaveChanges();
            Console.WriteLine("Seeding of Sales entries completed!");
        }
    }
}
