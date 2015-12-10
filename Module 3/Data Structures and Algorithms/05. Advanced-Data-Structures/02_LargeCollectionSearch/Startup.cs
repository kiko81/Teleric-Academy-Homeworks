// Write a program to read a large collection of products(name + price) and efficiently find the first 20  products in the price range[a…b].
// * Test for 500 000 products and 10 000 price searches.
// * Hint: you may use OrderedBag<T> and sub-ranges.

namespace LargeCollectionSearch
{
    using System;
    using System.Collections;
    using System.Linq;

    using Wintellect.PowerCollections;

    public class Startup
    {
        private static Random rand = new Random();

        public static void Main()
        {
            var orderedBag = new OrderedBag<Product>((pr, pr1) => pr.Price.CompareTo(pr1.Price));
            for (var i = 0; i < 500000; i++)
            {
                orderedBag.Add(new Product { Name = "Product" + (i + 1), Price = rand.Next(1000, 50000) });
            }

            var start = DateTime.Now;
            var twentyProductsInRange = GetTwentyProductsInRange(orderedBag);
            Console.WriteLine("Estimated time for 1 search: " + (DateTime.Now - start));
            
            Console.WriteLine("First 20 products in range:");
            foreach (var product in twentyProductsInRange)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine();

            start = DateTime.Now;
            for (var i = 0; i < 10000; i++)
            {
                twentyProductsInRange = GetTwentyProductsInRange(orderedBag);
                twentyProductsInRange.GetEnumerator();
                ////foreach (var product in twentyProductsInRange)
                ////{
                ////    Console.WriteLine(product);
                ////}
            }

            Console.WriteLine("Estimated time for 10000 searches: " + (DateTime.Now - start));
        }

        private static IEnumerable GetTwentyProductsInRange(OrderedBag<Product> orderedBag)
        {
            var initialPrice = rand.Next(1000, 50000);
            return orderedBag.Range(new Product { Price = initialPrice }, true, new Product { Price = initialPrice + 20000 }, true).Take(20).ToList();
        }
    }
}
