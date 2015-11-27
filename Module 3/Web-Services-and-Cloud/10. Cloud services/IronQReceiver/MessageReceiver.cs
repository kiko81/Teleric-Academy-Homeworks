namespace IronQReceiver
{
    using System;
    using System.Threading;

    using IronMQ;
    using IronMQ.Data;

    class MessageReceiver
    {
        static void Main()
        {
            // Messages from all senders are received here
            Client client = new Client(
                "5647a6219195a8000700008f",
                "DJNDNQJFGnj3lltqXGSq");
            
            Queue queue = client.Queue("SampleQueue");

            Console.WriteLine("Listening for new messages from IronMQ server:");
            while (true)
            {
                Message msg = queue.Get();
                if (msg != null)
                {
                    Console.WriteLine(msg.Body);
                    queue.DeleteMessage(msg);
                }
                Thread.Sleep(500);
            }
        }
    }
}
