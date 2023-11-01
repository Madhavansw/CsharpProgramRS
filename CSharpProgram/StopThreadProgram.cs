using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpProgram
{
   public class StopThreadProgram
    {
        static void Main(string[] args)
        {

            //var _stopwatch = Stopwatch.StartNew();
            //Thread.Sleep(500);
            //_stopwatch.Stop();
            var stopwatch = Stopwatch.StartNew();
            Thread.Sleep(500);
            stopwatch.Stop();
            Console.WriteLine("Elapsed Milliseconds : {0}",
                              stopwatch.ElapsedMilliseconds);
            Console.WriteLine("Elapsed Ticks : {0}", stopwatch.ElapsedTicks);
            Console.WriteLine("Present Date and Time : {0}",
                              DateTime.Now.ToLongTimeString());
            Console.ReadLine();


        }
    }
}
