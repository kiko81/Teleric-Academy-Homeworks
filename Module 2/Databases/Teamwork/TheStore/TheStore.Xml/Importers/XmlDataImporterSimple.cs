namespace TheStore.Xml.Importers
{
    using System;
    using System.Collections.Generic;
    using System.Xml;
    using TheStore.Models;
    using TheStore.Models.Sql;

    public static class XmlDataImporterSimple
    {
        public static HashSet<Manufacturer> ImportXmlData(string filepath)
        {
            var reader = XmlReader.Create(filepath);
            var manufacturersToImport = new HashSet<Manufacturer>();
            string manufacturerName = string.Empty;
            using (reader)
            {
                while (reader.Read())
                {
                    try
                    {
                        if (reader.NodeType == XmlNodeType.Element && reader.Name == "name")
                        {
                            manufacturerName = reader.ReadElementContentAsString();

                            var manufacturer = new Manufacturer()
                            {
                                Name = manufacturerName.Trim()
                            };

                            manufacturersToImport.Add(manufacturer);
                        }
                    }
                    catch (FormatException)
                    {
                    }
                }

                return manufacturersToImport;
            }
        }
    }
}