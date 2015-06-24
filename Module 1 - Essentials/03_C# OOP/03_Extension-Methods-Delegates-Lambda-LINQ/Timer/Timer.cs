using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Timer
{
    public delegate void Repeat(double time);

    class Timer
    {
        static void Main()
        {
            Repeat seconds = delegate(double time)
            {
                while (true)
                {
                    Thread.Sleep((int)time);
                    Console.WriteLine(DateTime.Now);
                }
            };
            Console.WriteLine("Write interval in seconds");
            seconds(int.Parse(Console.ReadLine()) * 1000);
        }
    }
}
