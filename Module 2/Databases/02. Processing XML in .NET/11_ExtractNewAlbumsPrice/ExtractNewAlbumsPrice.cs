namespace ExtractNewAlbumsPrice
{
    using System;
    using System.Xml;

    public static class ExtractNewAlbumsPrice
    {
        private const string Path = "../../../catalog.xml";

        public static void Main()
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(Path);

            var albums = xmlDoc.SelectNodes("/albums/album[year]");

            foreach (XmlNode album in albums)
            {
                var year = int.Parse(album["year"].InnerText);

                if (year >= DateTime.Now.Year - 5)
                {
                    Console.WriteLine("{0} - price: {1}", album["name"].InnerText, album["price"].InnerText);
                }
            }
        }
    }
}
