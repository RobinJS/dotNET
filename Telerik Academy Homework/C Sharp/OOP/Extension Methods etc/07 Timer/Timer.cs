// Using delegates write a class Timer that has can execute certain method at each t seconds

using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Diagnostics;
using System.Threading;

namespace _07_Timer
{
    public delegate void TimerDelegate(int t, int duration);

    public class Timer
    {
        static void Main()
        {
            int t = 500;
            int duration = 5;
            TimerDelegate timer = new TimerDelegate(OnTimedEvent);
            timer(t, duration);

        }

        static void OnTimedEvent(int t, int duration)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int interval = 0;

            while (interval < duration)
            {
                Console.WriteLine("Hello!");
                Thread.Sleep(t);
                sw.Stop();
                interval++;
            }
        }
    }
}
