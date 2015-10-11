namespace JSON_Processing
{
    using Newtonsoft.Json;

    public class Video
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("yt:videoId")]
        public string Id { get; set; }
    }
}