namespace TraverseDirectoryWithLINQ
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    public static class TraverseDirectoryWithLinq
    {
        public static void Main()
        {
            var path = "../../../";

            var folder = Traverse(path);
            folder.Save("../../../fileSystemLINQ.xml");
            Console.WriteLine("result saved to fileSystemLINQ.xml");
        }

        private static XElement Traverse(string dir)
        {
            var element = new XElement("dir", new XAttribute("path", dir));

            foreach (var directory in Directory.GetDirectories(dir))
            {
                element.Add(Traverse(directory));
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                var fileToAdd = new XElement("file", new XAttribute("ext", Path.GetExtension(file)));
                fileToAdd.SetValue(Path.GetFileNameWithoutExtension(file));

                element.Add(fileToAdd);
            }

            return element;
        }
    }
}
