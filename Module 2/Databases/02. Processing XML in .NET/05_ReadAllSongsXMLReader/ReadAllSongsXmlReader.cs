namespace ReadAllSongsXMLReader
{
    using System;
    using System.Xml;

    public static class ReadAllSongsXmlReader
    {
        public static void Main()
        {
            using (XmlReader reader = new XmlTextReader("../../../catalog.xml"))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "title")
                    {
                        Console.WriteLine(reader.ReadElementString());
                    }
                }
            }
        }
    }
}