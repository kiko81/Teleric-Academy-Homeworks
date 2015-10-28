namespace TheStore.MySql.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using TheStore.Models.Sql;
    using TheStore.MySql.Models;

    public interface IMySqlSalesRepository
    {
        void Add(SalesReport entity);

        void AddMany(IEnumerable<SalesReport> entities);

        void DeleteAllReports();

        IQueryable<SalesReport> All();

        void SaveChanges();
    }
}
