namespace PubNub
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Net;

    class PubNub
    {
        static void Main()
        {
            // Start the HTML5 Pubnub client
            Process.Start("..\\..\\PubNub-HTML5-Client.html");

            System.Threading.Thread.Sleep(2000);

            PubnubAPI pubnub = new PubnubAPI(
                "pub-c-c8e12013-c187-4311-97f6-37f19f472922",               // PUBLISH_KEY
                "sub-c-a8243ee0-8b88-11e5-9320-02ee2ddab7fe",               // SUBSCRIBE_KEY
                "sec-c-NmU5MGU5YjMtYWQxNC00MmRhLTg2NTctNWI0OWM0NjVjNjUz"
            );
            string channel = "test-channel";

            // Publish a sample message to Pubnub
            List<object> publishResult = pubnub.Publish(channel, "Hello");
            Console.WriteLine(
                "Publish Success: " + publishResult[0].ToString() + "\n" +
                "Publish Info: " + publishResult[1]
            );

            // Show PubNub server time
            object serverTime = pubnub.Time();
            Console.WriteLine("Server Time: " + serverTime.ToString());

            // Subscribe for receiving messages (in a background task to avoid blocking)
            //System.Threading.Tasks.Task t = new System.Threading.Tasks.Task(
            //    () =>
            //    pubnub.Subscribe(
            //        channel,
            //        delegate (object message)
            //        {
            //            Console.WriteLine("Received Message -> '" + message + "'");
            //            return true;
            //        }
            //    )
            //);
            //t.Start();

            // Read messages from the console and publish them to Pubnub
            string ipAddress = new WebClient().DownloadString("http://icanhazip.com").Trim();
            while (true)
            {
                Console.Write("Enter a message to be sent to Pubnub: ");
                string msg = string.Format("{0}: {1}", ipAddress, Console.ReadLine());
                pubnub.Publish(channel, msg);
                Console.WriteLine("Message {0} sent.", msg);
            }
        }
    }
}
