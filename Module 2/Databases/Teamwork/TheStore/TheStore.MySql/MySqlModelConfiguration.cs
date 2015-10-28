namespace TheStore.MySql
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Telerik.OpenAccess.Metadata;
    using Telerik.OpenAccess.Metadata.Fluent;

    using TheStore.Context;
    using TheStore.Models.Sql;
    using TheStore.MySql.Models;

    public class MySqlModelConfiguration : FluentMetadataSource
    {
        public void ExportSalesToMySql()
        {
            var db = new StoreContext();
            var reports = db.Sales.ToList();

            foreach (var sale in reports)
            {
                Console.WriteLine(sale.Town.Name);
            }

            Console.WriteLine(reports.Count);
        }

        protected override IList<MappingConfiguration> PrepareMapping()
        {
            List<MappingConfiguration> configurations = new List<MappingConfiguration>();

            var salesMapping = new MappingConfiguration<SalesReport>();
            salesMapping.HasProperty(c => c.Id).IsIdentity(KeyGenerator.Autoinc);

            salesMapping.MapType(report => new
            {
                // Id = report.Id,
                Town = report.Town,
                Date = report.Date,
                LaptopId = report.LaptopId,
                Quantity = report.Quantity,
                Sum = report.Sum
            }).ToTable("sales");

            configurations.Add(salesMapping);

            return configurations;
        }
    }
}
