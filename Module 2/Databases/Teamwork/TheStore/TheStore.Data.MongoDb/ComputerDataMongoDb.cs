namespace TheStore.Data.MongoDb
{
    using System.Collections.Generic;
    using MongoDB.Driver;
    using TheStore.Models.Mongo;

    public class ComputerDataMongoDb : IComputersDataMongoDb
    {
        private const string LaptopCollectionName = "laptops";
        private const string MiceCollectionName = "mice";
        private const string ManufacturerCollectionName = "manufacturers";

        private readonly ComputersContextMongoDb databaseContext;

        public ComputerDataMongoDb(ComputersContextMongoDb context)
        {
            this.databaseContext = context;
        }

        public MongoCollection<Laptop> Laptop
        {
            get
            {
                return this.databaseContext.GetCollection<Laptop>(LaptopCollectionName);
            }
        }

        public MongoCollection<Mouse> Mice
        {
            get
            {
                return this.databaseContext.GetCollection<Mouse>(MiceCollectionName);
            }
        }
        public MongoCollection<Manufacturer> Manufacturer
        {
            get
            {
                return this.databaseContext.GetCollection<Manufacturer>(ManufacturerCollectionName);
            }
        }

        public void Save<TDefaultDocument>(string collectionName, List<TDefaultDocument> collection)
        {
            this.databaseContext.SaveToCollection(collectionName, collection);
        }

        public void Delete(string collectionName)
        {
            this.databaseContext.DropCollection(collectionName);
        }
    }
}