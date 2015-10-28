namespace TheStore.Json
{
    using System.Data.Entity;

    using TheStore.Context;
    using TheStore.Context.Migrations;

    public class Startup
    {
        private const string JsonReportsPath = "../../../Exports/Json-Reports/";

        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StoreContext, Configuration>());
            var exporter = new JsonExporter();
            exporter.ExportToJson(JsonReportsPath);
        }
    }
}
