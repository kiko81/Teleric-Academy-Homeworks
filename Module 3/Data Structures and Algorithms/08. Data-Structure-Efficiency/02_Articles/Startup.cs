namespace Articles
{
    using System;
    using System.Linq;

    using Wintellect.PowerCollections;

    public class Startup
    {
        private const int ArticlesCount = 1000000;
        private const decimal MaxPrice = 150;
        private const decimal MinPrice = 50;

        private static void Main()
        {
            var articles = new OrderedMultiDictionary<decimal, Article>(false);
            var rand = new RandomGenerator();

            Console.WriteLine($"Populating {ArticlesCount} articles");
            for (var i = 0; i < ArticlesCount; i++)
            {
                var title = rand.GetRandomString();
                var vendor = rand.GetRandomString();
                var price = rand.GetRandomInteger(10, 2500);
                var barcode = rand.GetRandomString(10, 15);

                var article = new Article(title, barcode, vendor, price);
                articles.Add(price, article);
            }

            Console.WriteLine($"Searching for articles in price range {MinPrice} - {MaxPrice}");
            var extractedArticles = articles.Range(MinPrice, true, MaxPrice, true);

            Console.WriteLine("Finished search. Man that was fast!\nPress a key to start printing to console...");
            Console.ReadLine();

            foreach (var article in extractedArticles.SelectMany(priceArticles => priceArticles.Value))
            {
                Console.WriteLine($"Title: {article.Title}, price: {article.Price}");
            }

            Console.WriteLine($"\n\nThats all articles in price range {MinPrice} - {MaxPrice} for {ArticlesCount} articles.\n\n");
        }
    }
}