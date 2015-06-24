namespace DivTo7and3
{
    using System;
    using System.Linq;

    class Program
    {
        public static Random r = new Random();

        static void Main(string[] args)
        {
            var array = Enumerable
            .Repeat(0, r.Next(5, 100))
            .Select(i => r.Next(200))
            .ToArray();

            Console.WriteLine("array: {" + string.Join(", ", array) + "}");

            //lambda
            var lambdaDiv = array.Where(x => x % 7 == 0 && x % 3 == 0);

            Console.WriteLine("divisible to 3 and 7: " + string.Join(", ", lambdaDiv)); 

            //LINQ
            var LINQdiv =
                from nr in array
                where nr % 7 == 0 && nr % 3 == 0
                select nr;

            Console.WriteLine("divisible to 3 and 7: " + string.Join(", ", LINQdiv));
                



        }
    }
}
