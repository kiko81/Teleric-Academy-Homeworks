namespace TheStore.MySql.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using TheStore.Models.Sql;
    using TheStore.MySql.Models;

    public class MySqlSalesRepository : IMySqlSalesRepository
    {
        private readonly MySqlContext context;

        public MySqlSalesRepository(MySqlContext context)
        {
            this.context = context;
        }

        public void Add(SalesReport entity)
        {
            this.context.Add(entity);
        }

        public void AddMany(IEnumerable<SalesReport> entities)
        {
            this.context.Add(entities);
        }

        public void DeleteAllReports()
        {
            this.context.Delete(this.All());
        }

        public IQueryable<SalesReport> All()
        {
            return this.context.GetAll<SalesReport>();
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }
    }
}
