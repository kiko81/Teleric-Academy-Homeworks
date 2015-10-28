namespace TheStore.Excel
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    using Bytescout.Spreadsheet;

    using TheStore.Context;
    using TheStore.Models.Sql;

    public class Program
    {
        public static void Main()
        {
            var seedGenerator = new SeedGenerator();
            var seeder = new Seeder();
            seedGenerator.Generate();
            var zipPath = "sales-reports.zip";
            seeder.SendToZip("Sales/", zipPath);
            seeder.Unzip(zipPath, "Export/");

            var root = new DirectoryInfo(@"Export\sales-reports");
            var db = new StoreContext();
            var towns = new Dictionary<string, Town>();

            string pattern = "yyyy MMM dd";
            foreach (var directory in root.GetDirectories())
            {
                DateTime parsedDate;
                DateTime.TryParseExact(directory.Name, pattern, null, DateTimeStyles.None, out parsedDate);

                foreach (var file in directory.GetFiles())
                {
                    var townName = Path.GetFileNameWithoutExtension(file.FullName);
                    if (!towns.ContainsKey(townName))
                    {
                        if (db.Towns.Any(x => x.Name == townName))
                        {
                            towns.Add(townName, db.Towns.First(x => x.Name == townName));
                        }
                        else
                        {
                            towns.Add(townName, new Town { Name = townName });
                        }
                    }

                    using (Spreadsheet document = new Spreadsheet())
                    {
                        var row = 1;

                        document.LoadFromFile(file.FullName);
                        Worksheet worksheet = document.Workbook.Worksheets.ByName("SalesReport");

                        while (!worksheet.Cell(row, 0).Merged)
                        {
                            db.Sales.Add(new Sales
                                             {
                                                 Date = parsedDate,
                                                 Town = towns[townName],
                                                 LaptopId = worksheet.Cell(row, 0).ValueAsInteger,
                                                 Quantity = worksheet.Cell(row, 2).ValueAsInteger
                                             });

                            ++row;
                        }
                    }
                }
            }

            db.SaveChanges();

            // document.LoadFromFile(@"Export\sales-reports\2002 Feb 27\Bourgas.xls");
            // Worksheet worksheet = document.Workbook.Worksheets.ByName("SalesReport");
            // Console.WriteLine(worksheet.Cell(4, 0).Merged);
        }
    }
}
