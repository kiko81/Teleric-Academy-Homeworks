namespace SchemaValidation
{
    using System;
    using System.Xml.Linq;
    using System.Xml.Schema;

    public static class SchemaValidation
    {
        private static void Main()
        {
            var schema = new XmlSchemaSet();
            schema.Add(string.Empty, "../../../catalog.xsd");

            var doc = XDocument.Load("../../../catalog.xml");
            var invalidDoc = XDocument.Load("../../../invalidCatalog.xml");

            PrintValidationResult(doc, schema, "catalog.xml");
            PrintValidationResult(invalidDoc, schema, "invalidCatalog.xml");
        }

        private static void PrintValidationResult(XDocument doc, XmlSchemaSet schema, string file)
        {
            doc.Validate(schema, (obj, ev) => Console.WriteLine("{0}\n{1}", file, ev.Message));
        }
    }
}