namespace TheStore.MySql
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Telerik.OpenAccess;

    using TheStore.MySql.Repositories;

    public class MySqlData
    {
        private const string ConnectionString = "server=localhost;database=thestore;uid=root;pwd={0};";

        private readonly MySqlContext context;

        public MySqlData()
        {
            var password = this.MySqlPasswordPrompt();

            this.context = new MySqlContext(string.Format(ConnectionString, password));

            this.SalesReport = new MySqlSalesRepository(this.context);

            this.VerifyDatabase();
        }

        public IMySqlSalesRepository SalesReport { get; private set; }

        private void VerifyDatabase()
        {
            var schemaHandler = this.context.GetSchemaHandler();
            this.EnsureDB(schemaHandler);
        }

        private void EnsureDB(ISchemaHandler schemaHandler)
        {
            string script;

            if (schemaHandler.DatabaseExists())
            {
                script = schemaHandler.CreateUpdateDDLScript(null);
            }
            else
            {
                schemaHandler.CreateDatabase();
                script = schemaHandler.CreateDDLScript();
            }

            if (!string.IsNullOrEmpty(script))
            {
                schemaHandler.ExecuteDDLScript(script);
            }
        }

        private string MySqlPasswordPrompt()
        {
            Console.Write("Please enter your password for 'root' account: ");
            Console.ForegroundColor = Console.BackgroundColor;
            var password = Console.ReadLine().Trim();
            Console.ResetColor();

            return password;
        }
    }
}
