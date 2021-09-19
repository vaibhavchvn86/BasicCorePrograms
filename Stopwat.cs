using System;
//using System.Collections.Generic;
//using System.Text;
using System.Diagnostics;
using System.Threading;

namespace Day6Assignment
{
    class Stopwat
    {
        public static void Watch()
        {
            Stopwatch StopW = new Stopwatch();
            StopW.Start();
            Thread.Sleep(1000);
            StopW.Stop();
            TimeSpan T = StopW.Elapsed;
            Console.WriteLine("Stopwatch Runtime= " + T);
        }
    }
}
