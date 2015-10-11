namespace TraverseDirectoryToXML
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;

    public static class TraverseDirectoryToXml
    {
        public static void Main()
        {
            using (XmlTextWriter writer = new XmlTextWriter("../../../fileSystem.xml", Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = ' ';
                writer.Indentation = 4;

                string path = "../../../";

                writer.WriteStartDocument();
                writer.WriteStartElement("currentProjectFolder");
                Traverse(path, writer);
                writer.WriteEndDocument();
            }

            Console.WriteLine("result saved as dir.xml");
        }

        private static void Traverse(string dir, XmlTextWriter writer)
        {
            foreach (var directory in Directory.GetDirectories(dir))
            {
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("path", directory);
                Traverse(directory, writer);
                writer.WriteEndElement();
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                writer.WriteStartElement("file");
                writer.WriteAttributeString("ext", Path.GetExtension(file));
                writer.WriteValue(Path.GetFileNameWithoutExtension(file));
                writer.WriteEndElement();
            }
        }
    }
}
