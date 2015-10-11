namespace ReadAllSongsLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public static class ReadAllSongsLinq
    {
        public static void Main()
        {
            XDocument xmlDoc = XDocument.Load("../../../catalog.xml");
            var songs =
                from song in xmlDoc.Descendants("song")
                select new
                       {
                           Title = song.Element("title")
                                       .Value,
                       };

            foreach (var song in songs)
            {
                Console.WriteLine(song.Title);
            }
        }
    }
}
