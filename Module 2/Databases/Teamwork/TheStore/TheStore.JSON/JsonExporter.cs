namespace TheStore.Json
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Runtime.InteropServices;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using TheStore.Context;

    public class JsonExporter
    {
        public void ExportToJson(string exportFolderPath)
        {
            var db = new StoreContext();
            var reports = db.Sales.ToList();

            if (!Directory.Exists(exportFolderPath))
            {
                Directory.CreateDirectory(exportFolderPath);
            }

            var groupedReports = reports
                .GroupBy(r => r.LaptopId)
                .ToList();

            foreach (var report in groupedReports)
            {
                var reportTemplate = report.First();

                var currentReport =
                    JObject.FromObject(
                        new
                        {
                            Id = reportTemplate.LaptopId,
                            reportTemplate.Laptop.Model,
                            Manufacturer = reportTemplate.Laptop.Manufacturer.Name,
                            Sold = report.Sum(r => r.Quantity),
                            Income = reportTemplate.Laptop.Price * report.Sum(r => r.Quantity)
                        });

                using (var writer = new StreamWriter(exportFolderPath + report.First().LaptopId + ".json", false))
                {
                    writer.Write(JsonConvert.SerializeObject(currentReport, Formatting.Indented));
                }

                Console.WriteLine("Created " + reportTemplate.LaptopId + ".json report");
            }
        }
    }
}
