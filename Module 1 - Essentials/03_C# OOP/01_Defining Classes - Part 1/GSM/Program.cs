namespace GSM
{
    using System;
    class Program
    {
        static void Main()
        {
            GSMTest.PrintGSMsInfo(GSMTest.GenerateGSMs(4));
            Console.WriteLine();
            Console.WriteLine("All calls and price for them");
            GSMCallHistoryTest.CreateCalltestHistory();
            GSMCallHistoryTest.DisplayCalltestHistory();
            GSMCallHistoryTest.CalculatePrice();
            Console.WriteLine("\nAll calls except the longest");
            GSMCallHistoryTest.RemoveLongestCall();
            GSMCallHistoryTest.DisplayCalltestHistory();
            GSMCallHistoryTest.CalculatePrice();
            Console.WriteLine("\nCall history cleared");
            GSMCallHistoryTest.testGSM.ClearCallHistory();
            GSMCallHistoryTest.DisplayCalltestHistory();
        }
    }
}
