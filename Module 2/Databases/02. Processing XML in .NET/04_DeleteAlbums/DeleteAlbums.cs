namespace DeleteAlbums
{
    using System;
    using System.Xml;

    public static class DeleteAlbums
    {
        private const string PathToFile = "../../../catalog.xml";
        private const double MaxPrice = 20.0d;

        public static void Main()
        {
            var doc = new XmlDocument();
            doc.Load(PathToFile);

            var root = doc.DocumentElement;
            
            PrintAlbums(root);

            foreach (XmlElement album in root.SelectNodes("album"))
            {
                var xmlPrice = album["price"].InnerText.Substring(1);
                var price = double.Parse(xmlPrice);

                if (price > MaxPrice)
                {
                    root.RemoveChild(album);
                }
            }

            Console.WriteLine("------------------");
            Console.WriteLine("Albums less than $20:");

            PrintAlbums(root);
        }

        private static void PrintAlbums(XmlElement root)
        {
            foreach (XmlElement album in root)
            {
                Console.WriteLine("{0} - price {1}", album["name"].InnerText, album["price"].InnerText);
            }
        }
    }
}
