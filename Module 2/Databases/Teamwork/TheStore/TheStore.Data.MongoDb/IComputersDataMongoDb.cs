namespace TheStore.Data.MongoDb
{
    using System.Collections.Generic;
    using MongoDB.Driver;
    using TheStore.Models.Mongo;

    public interface IComputersDataMongoDb
    {
        MongoCollection<Laptop> Laptop { get; }

        MongoCollection<Mouse> Mice { get; }

        MongoCollection<Manufacturer> Manufacturer { get; }

        void Save<TDefaultDocument>(string collectionName, List<TDefaultDocument> collection);
    }
}