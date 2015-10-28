namespace DaoCUD
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using NorthWindDBContext;

    public static class Dao
    {
        public static void DeleteNewInsertedCustomer(NorthwindEntities db)
        {
            var customer = db.Customers.FirstOrDefault(c => c.CustomerID == "1245");
            db.Customers.Remove(customer);
            db.SaveChanges();
        }

        public static void ModifyNewInsertedCustomer(NorthwindEntities db)
        {
            var customer = db.Customers.FirstOrDefault(c => c.CustomerID == "1245");
            customer.ContactTitle = "Big Boss";
            db.SaveChanges();
        }

        public static void InsertNewCustomersToDb(NorthwindEntities db)
        {
            var newCustomer = new Customer
            {
                CustomerID = "1245",
                CompanyName = "Telerik",
            };

            db.Customers.AddOrUpdate(newCustomer);
            db.SaveChanges();
        }
    }
}
