namespace FindOrdersIn97NativeSQL
{
    using System;

    using NorthWindDBContext;

    public class Startup
    {
        private const string NativeSqlQuery =
            @"SELECT ContactName
            FROM Customers c
            WHERE EXISTS(
                SELECT *
                FROM Orders o
                WHERE Year(o.OrderDate) = 1997 
                    AND o.ShipCountry = 'Canada' 
                    AND o.CustomerID = c.CustomerID)";

        public static void Main()
        {
            using (var db = new NorthwindEntities())
            {
                var customers = db.Database.SqlQuery<OrdersView>(NativeSqlQuery);

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.ContactName);
                }
            }   
        }
    }
}
