namespace TheStore.Xml.Exporters
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Xml.Linq;
    using TheStore.Context;

    public class XmlFileExporter
    {
        public static void GenerateXmlReport(string filePath, StoreContext db)
        {
            var manufacturers = db.Manufacturers.
                                Join(db.Laptops,
                                m => m.Id, l => l.ManufacturerId,
                                (m, l) => new
                                {
                                    Manufacturer = m.Name,
                                    Model = l.Model,
                                    Class = l.Class.Name
                                }).ToList();

            var doc = new XDocument(new XElement(
                "manufacturers",
                from manufacturer in manufacturers
                select new XElement(
                    "manufacturer",
                new XElement("manufacturer", manufacturer.Manufacturer),
                new XElement("model", manufacturer.Model),
                new XElement("class", manufacturer.Class))));


            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            string fileName = AddUniqueFilenameSuffix(@"\Manufacturers");
            var fullPath = filePath + fileName;
            doc.Save(fullPath);
        }

        private static string AddUniqueFilenameSuffix(string fileName)
        {
            DateTime currentDate = DateTime.Now;
            string fileNameSuffix = string.Format(
                "-{0}.{1}.{2}-{3}.{4}.{5}.xml",
                currentDate.Day,
                currentDate.Month,
                currentDate.Year,
                currentDate.Hour,
                currentDate.Minute,
                currentDate.Second);

            fileName = fileName + fileNameSuffix;
            return fileName;
        }
    }
}