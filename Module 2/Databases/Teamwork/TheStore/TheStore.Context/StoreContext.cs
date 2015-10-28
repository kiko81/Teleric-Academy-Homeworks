namespace TheStore.Context
{
    using System.Data.Entity;
    using System.Linq;

    using TheStore.Models.Sql;

    public class StoreContext : DbContext
    {
        public StoreContext()
            : base("StoreDb")
        {
        }

        public DbSet<Manufacturer> Manufacturers { get; set; }

        public DbSet<LaptopClass> Classes { get; set; }

        public DbSet<Mouse> Mice { get; set; }

        public DbSet<Laptop> Laptops { get; set; }

        public DbSet<Town> Towns { get; set; }

        public DbSet<Sales> Sales { get; set; }
    }
}
