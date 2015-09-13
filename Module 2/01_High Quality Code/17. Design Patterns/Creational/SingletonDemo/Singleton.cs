namespace SingletonDemo
{
    public class Singleton
    {
        private static Singleton instance;

        // Note: Constructor is protected
        protected Singleton()
        {
        }

        public static Singleton Instance()
        {
            // no lazy initialization
            if (instance == null)
            {
                instance = new Singleton();
            }

            return instance;
        }
    }
}