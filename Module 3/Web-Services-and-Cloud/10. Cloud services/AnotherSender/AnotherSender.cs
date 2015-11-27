namespace AnotherSender
{
    using System;
    using System.Net;

    using IronMQ;

    public class AnotherSender
    {
        static void Main()
        {
            // Run both senders and the receiver for testing
            Client client = new Client(
                "5647a6219195a8000700008f",
                "DJNDNQJFGnj3lltqXGSq");
            Queue queue = client.Queue("SampleQueue");
            string ipAddress = new WebClient().DownloadString("http://icanhazip.com").Trim();
            Console.WriteLine("Enter messages to be sent to the IronMQ server:");
            while (true)
            {
                string msg = Console.ReadLine();
                queue.Push(string.Format("{0} (other): {1}", ipAddress, msg));
                Console.WriteLine("Message sent to the IronMQ server.");
            }
        }
    }
}
