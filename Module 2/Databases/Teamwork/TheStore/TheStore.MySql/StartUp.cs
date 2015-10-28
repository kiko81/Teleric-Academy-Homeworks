namespace TheStore.MySql
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var reporter = new MySqlData();

            MySqlSeed.Seed(reporter);
        }
    }
}
