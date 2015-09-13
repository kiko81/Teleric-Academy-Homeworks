namespace SingletonDemo
{
    using System;

    public class SingletonDemo
    {
        static void Main()
        {
            // Constructor is protected -- cannot use new 
            Singleton s1 = Singleton.Instance();
            Singleton s2 = Singleton.Instance();

            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }
            else
            {
                // This wont happen because of Singleton pattern
                Console.WriteLine("Objects are different instances");
            }
        }
    }
}


