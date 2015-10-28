namespace TheStore.Models.Mongo
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class Mouse
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public int Dpi { get; set; }

        public bool IsWireless { get; set; }

        public decimal Price { get; set; }
    }
}
