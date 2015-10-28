namespace TheStore.Data.MongoDb
{
    using System.Collections.Generic;
    using MongoDB.Driver;

    public class ComputersContextMongoDb : IComputersContextMongoDb
    {
        // private const string LocalDatabaseHost = "mongodb://127.0.0.1:27017";
        private const string MongoDataBaseHost = "mongodb://Team-Dysprosium:telerik@ds041144.mongolab.com:41144/computers";
        private const string LaptopsDatabaseName = "computers";

        private readonly MongoDatabase database;

        public ComputersContextMongoDb()
        {
            this.database = this.ConnectToDatabase(LaptopsDatabaseName);
        }

        public MongoCollection<TDefaultDocument> GetCollection<TDefaultDocument>(string collectionName)
        {
            return this.database.GetCollection<TDefaultDocument>(collectionName);
        }

        public void SaveToCollection<TDefaultDocument>(string collectionName, List<TDefaultDocument> collectionToInsert)
        {
            this.database.GetCollection<TDefaultDocument>(collectionName).InsertBatch(collectionToInsert);
        }

        public void DropCollection(string collectionName)
        {
            this.database.DropCollection(collectionName);
        }

        private MongoDatabase ConnectToDatabase(string dataBaseName)
        {
            var client = new MongoClient(MongoDataBaseHost);
            MongoServer server = client.GetServer();
            return server.GetDatabase(dataBaseName);
        }
    }
}
