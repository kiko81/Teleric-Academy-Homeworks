namespace BinaryPasswords
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine((long)1 << Console.ReadLine().Count(ch => ch == '*'));
        }
    }
}
