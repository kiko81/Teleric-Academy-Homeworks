namespace TheStore.Data.MongoDb
{
    using System.Collections.Generic;
    using MongoDB.Driver;

    public interface IComputersContextMongoDb
    {
        MongoCollection<TDefaultDocument> GetCollection<TDefaultDocument>(string collectionName);

        void SaveToCollection<TDefaultDocument>(string collectionName, List<TDefaultDocument> collectionToInsert);

        void DropCollection(string collectionName);
    }
}
