namespace TheStore.Xml.Importers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Xml;
    using System.Xml.Linq;
    using TheStore.Models;

    public static class XmlDataImporterGeneric
    {
        public static HashSet<T> ImportXmlData<T>(string filepath) where T : class  
        {
            var typeToImport = typeof(T);
            var dataToImport = new HashSet<T>();
            var modelProperties = typeToImport.GetProperties();
            var nodeName = typeToImport.Name.ToLower();

            XDocument xmlDoc = XDocument.Load(filepath);
            var descendants = xmlDoc.Descendants(nodeName);

            foreach (var node in descendants)
            {
                var objToAdd = (T)Activator.CreateInstance(typeToImport);
                foreach (var prop in modelProperties)
                {
                    var childNode = node.Element(prop.Name.ToLower());
                    if (childNode != null)
                    {
                        var typeOfProperty = prop.PropertyType;
                        var childValue = childNode.Value.Trim();
                        var propValue = Convert.ChangeType(childValue, typeOfProperty);
                        prop.SetValue(objToAdd, propValue, null);
                    }
                }

                dataToImport.Add(objToAdd);
            }

            return dataToImport;
        }
    }
}