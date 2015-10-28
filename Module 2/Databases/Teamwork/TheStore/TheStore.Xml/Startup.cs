namespace TheStore.Xml
{
    using System;
    using System.Collections.Generic;
    using TheStore.Context;
    using TheStore.Data.MongoDb;
    using TheStore.Models.Sql;
    using TheStore.Xml.Exporters;
    using TheStore.Xml.Importers;

    public class Startup
    {
        public const string ExportDirectory = @"..\..\Exports";

        public static void Main()
        {
            var db = new StoreContext();
            var databaseContext = new ComputersContextMongoDb();
            var mongoDb = new ComputerDataMongoDb(databaseContext);
            var dataForMongoDb = new List<Manufacturer>();

            var xmlManufacurersToImportWithGeneric = XmlDataImporterGeneric.ImportXmlData<Manufacturer>(@"..\..\LaptopManufacturers.xml");  // TODO make table with Unique values + remove ID?

            Console.WriteLine("Adding Manufacturers....");
            foreach (var manufacturer in xmlManufacurersToImportWithGeneric)
            {
                db.Manufacturers.Add(manufacturer);
                Console.WriteLine("{0} added successfully", manufacturer.Name);
            }

            var xmlManufacurersToImportWithSimple = XmlDataImporterSimple.ImportXmlData(@"..\..\LaptopManufacturers.xml");
            foreach (var manufacturer in xmlManufacurersToImportWithSimple)
            {
                db.Manufacturers.Add(manufacturer);
                dataForMongoDb.Add(manufacturer);

                Console.WriteLine("{0} added successfully", manufacturer.Name);
            }

            db.SaveChanges();
            Console.WriteLine("XML import to SQL complete!");

            mongoDb.Save("manufacturers", dataForMongoDb);
            Console.WriteLine("XML import to MongoDb complete!");

            Console.WriteLine();
            Console.WriteLine("XML Exporting from database.....");
            Console.WriteLine();
            XmlFileExporter.GenerateXmlReport(ExportDirectory, db);
            Console.WriteLine("Report successfully exported to {0}", ExportDirectory);
        }
    }
}