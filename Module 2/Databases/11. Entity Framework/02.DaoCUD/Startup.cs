namespace DaoCUD
{
    using NorthWindDBContext;

    public class Startup
    {
        public static void Main()
        {
            using (var db = new NorthwindEntities())
            {
                // Comment/uncomment to check each functionality - 
                Dao.InsertNewCustomersToDb(db);
                Dao.ModifyNewInsertedCustomer(db);
                Dao.DeleteNewInsertedCustomer(db);
            }
        }
    }
}
