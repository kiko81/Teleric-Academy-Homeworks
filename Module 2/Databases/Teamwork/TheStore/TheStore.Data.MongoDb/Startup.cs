namespace TheStore.Data.MongoDb
{
    using System;
    using System.Collections.Generic;
    using TheStore.Models.Mongo;

    public class Startup
    {
        public static void Main()
        {
            var databaseContext = new ComputersContextMongoDb();
            var data = new ComputerDataMongoDb(databaseContext);

            // var collection = data.Laptop.FindAll();
            var collection = data.Mice.FindAll();

            foreach (var item in collection)
            {
                Console.WriteLine(item.Model);
            }

            // var laptopCollection = new List<Laptop> 
            // {
            //     new Laptop { Model = "Lenovo", Manufacturer = "Lenovo Corp.", Class = "Business" , Price = 2500},
            //     new Laptop { Model = "Dell", Manufacturer = "Dell Corp.", Class = "Business", Price = 2600},
            //     new Laptop { Model = "HP", Manufacturer = "HP Corp.", Class = "Business", Price = 2800 }
            // };

            // var mouseCollection = new List<Mouse>
            // {
            //     new Mouse {Model = "Naga Epic Chroma", Dpi = 8200, Manufacturer = "Razer", IsWireless = true, Price = 350},
            //     new Mouse {Model = "Copperhead", Dpi = 8200, Manufacturer = "Razer", IsWireless = true, Price = 250},
            //     new Mouse {Model = "Taipan", Dpi = 8200, Manufacturer = "Razer", IsWireless = false, Price = 300},
            // };

            // data.Save<Laptop>("laptops", laptopCollection);
            // data.Save<Mouse>("mice", mouseCollection);

            // data.Delete("laptops");
            // data.Delete("mice");
        }
    }
}