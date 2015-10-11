namespace ProcessRSSFeed
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Xml.Linq;
    using JSON_Processing;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public static class ProcessRssFeed
    {
        internal static void Main()
        {
            var webclient = new WebClient();
            webclient.DownloadFile("https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw", "../../../rss.xml");
            webclient.Dispose();

            var rss = XDocument.Load("../../../rss.xml");
            var jsonFromXml = JsonConvert.SerializeXNode(rss, Formatting.Indented);
            var jsonObj = JObject.Parse(jsonFromXml);

            //var json = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
            //File.WriteAllText("../../../feed.json", json);

            var entry = jsonObj["feed"]["entry"];
            var titles = entry.Select(t => t["title"]);

            Console.WriteLine("available videos:\n" + string.Join("\n", titles));

            var videos = entry.Select(v => JsonConvert.DeserializeObject<Video>(v.ToString()));

            var html = new StringBuilder();

            foreach (var video in videos)
            {
                html.AppendFormat("<div><iframe width=\"640\" height=\"480\" " +
                                  "src=\"http://www.youtube.com/embed/{0}?autoplay=0\"></iframe>" +
                                  "<h3>{1}</h3></div>",
                                  video.Id, video.Title);
            }

            var htmlCreator = new StreamWriter("../../../videos.html", false, Encoding.UTF8);
            htmlCreator.Write(html.ToString());
            htmlCreator.Close();

            Process.Start(Path.Combine(Environment.CurrentDirectory, "../../../videos.html"));
        }
    }
}
