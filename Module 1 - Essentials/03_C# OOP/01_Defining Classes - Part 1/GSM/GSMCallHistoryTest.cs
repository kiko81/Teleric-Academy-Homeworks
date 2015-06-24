﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace GSM
{
    public class GSMCallHistoryTest //problem 12
    {
        private const decimal pricePerMinute = 0.37m;
        public static GSM testGSM = new GSM("Yabylka", "aifon");

        public static Call[] testCalls = 
        {
            new Call(DateTime.Parse("15/03/2015 08:00:00"), 36, "12345678"),
            new Call(DateTime.Parse("14/03/2015 17:45:29"), 43, "555555"),
            new Call(DateTime.Parse("13/03/2015 13:13:31"), 13, "8678678"),

        };
        public static void CreateCalltestHistory()
        {
            for (int i = 0; i < testCalls.Length; i++)
            {
                testGSM.AddCalls(testCalls[i]);
            }
        }
        public static void DisplayCalltestHistory()
        {
            Console.WriteLine(testGSM.PrintCallHistory()); 
        }
        public static void CalculatePrice()
        {
            Console.WriteLine("Total price: {0:f2}", testGSM.CalculateTotalCallsPrice(pricePerMinute));
        }
        public static void RemoveLongestCall()
        {
            testGSM.DeleteCalls(testGSM.CallHistory.OrderBy(x => x.Duration).ToArray()[testGSM.CallHistory.Count - 1]);
        }
    }
}