namespace ExtractNewAlbumsPriceLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public static class ExtractNewAlbumsPriceLinq
    {
        private const string Path = "../../../catalog.xml";

        public static void Main()
        {
            {
                var doc = XDocument.Load(Path);

                var albums =
                    from album in doc.Descendants("album")
                    where int.Parse(album.Element("year").Value) >= DateTime.Now.Year - 5
                                 select new
                                 {
                                     name = album.Element("name").Value,
                                     price = album.Element("price").Value
                                 };

                foreach (var album in albums)
                {
                    Console.WriteLine("{0} - price {1}", album.name, album.price);
                }
            }
        }
    }
}