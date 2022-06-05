using System;
using System.Diagnostics;

namespace Algoritms_Exponentiation
{
    class TimeTest
    {

        public static void Test(int n, double a, func f, string type)
        {

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();


            f(n,a);


            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            Console.WriteLine("RunTime {0}{1} = {2}", type, n, elapsedTime);
            Console.WriteLine("");
        }


        public delegate void func(int n, double a);


    }
}
