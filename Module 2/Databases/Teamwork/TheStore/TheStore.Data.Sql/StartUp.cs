namespace TheStore.Data.Sql
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using Context;
    using Models.Sql;
    using Pdf;
    using TheStore.Context.Migrations;
    using TheStore.Data.MongoDb;

    public class StartUp
    {
        private const string PdfReportsFolderPath = @"..\..\..\Exports\PDF-Reports\";
        private const string PdfReportsFileName = @"computers-report";
        private const string PdfSalesReportFileName = @"sales-report";

        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StoreContext, Configuration>());

            var databaseContext = new ComputersContextMongoDb();
            var data = new ComputerDataMongoDb(databaseContext);
            var db = new StoreContext();

            var laptopCollection = data.Laptop.FindAll();
            var mouseCollection = data.Mice.FindAll();

            var manufacturers = new Dictionary<string, Manufacturer>();
            var classes = new Dictionary<string, LaptopClass>();

            foreach (var item in laptopCollection)
            {
                if (!manufacturers.ContainsKey(item.Manufacturer))
                {
                    if (db.Manufacturers.Any(x => x.Name == item.Manufacturer))
                    {
                        manufacturers.Add(item.Manufacturer, db.Manufacturers.First(x => x.Name == item.Manufacturer));
                    }
                    else
                    {
                        manufacturers.Add(item.Manufacturer, new Manufacturer { Name = item.Manufacturer });
                    }
                }

                if (!classes.ContainsKey(item.Class))
                {
                    if (db.Classes.Any(x => x.Name == item.Class))
                    {
                        classes.Add(item.Class, db.Classes.First(x => x.Name == item.Class));
                    }
                    else
                    {
                        classes.Add(item.Class, new LaptopClass { Name = item.Class });
                    }
                }

                var laptop = new Laptop
                {
                    Model = item.Model,
                    Manufacturer = manufacturers[item.Manufacturer],
                    Class = classes[item.Class],
                    Price = item.Price
                };

                db.Laptops.AddOrUpdate(laptop);
            }

            foreach (var item in mouseCollection)
            {
                if (!manufacturers.ContainsKey(item.Manufacturer))
                {
                    if (db.Manufacturers.Any(x => x.Name == item.Manufacturer))
                    {
                        manufacturers.Add(item.Manufacturer, db.Manufacturers.First(x => x.Name == item.Manufacturer));
                    }
                    else
                    {
                        manufacturers.Add(item.Manufacturer, new Manufacturer { Name = item.Manufacturer });
                    }
                }

                var mouse = new Mouse
                {
                    Model = item.Model,
                    Manufacturer = manufacturers[item.Manufacturer],
                    Dpi = item.Dpi,
                    IsWireless = item.IsWireless,
                    Price = item.Price
                };

                db.Mice.Add(mouse);
            }

            db.SaveChanges();
            var pdfExporter = new PdfFileExporter();
            pdfExporter.GenerateComputersReports(PdfReportsFolderPath, PdfReportsFileName, db);

            ////var jsonExporter = new JsonExporter();
            //// TODO: Returns default date for some reason - help pls probably culture issue
            ////var date = jsonExporter.GetDate();
            ////jsonExporter.GenerateReportsForGivenDate(JSONReportsFolderPath, date, db);
        }
    }
}
