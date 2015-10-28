namespace TheStore.Sqlite
{
    using System.Data.Entity;
    using System.Data.Entity.Core.Common;
    using System.Data.SQLite;
    using System.Data.SQLite.Linq;

    public class CombinationsContext : DbContext
    {
        public CombinationsContext()
            : base("CombinationsSqlDb")
        {
            this.Database.CreateIfNotExists();
        }

        public DbSet<Combinations> Combinations { get; set; }
    }
}
