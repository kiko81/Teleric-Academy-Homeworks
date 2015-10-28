namespace TheStore.Models.Mongo
{
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public class Laptop
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public string Class { get; set; }

        public decimal Price { get; set; }
    }
}
