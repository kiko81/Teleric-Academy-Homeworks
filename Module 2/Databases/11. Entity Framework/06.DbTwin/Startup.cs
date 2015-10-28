namespace DbTwin
{
    using System;

    using NorthWindDBContext;

    public class Startup
    {
        public static void Main()
        {
            using (var db = new NorthwindEntities())
            {
                // To solve this task you need to change in the app.config file the connection string to:
                // initial catalog=NorthwindTwin
                Console.WriteLine(db.Database.CreateIfNotExists() ? "NorthwindTwin created!!" : "NorthWindTwin already exists");
            }
        }
    }
}
