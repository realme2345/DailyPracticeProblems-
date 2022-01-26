using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6PracticeProblems
{
    class StopWatch
    {
        public static void DisplayStopWatch()
        {
            var watch = new Stopwatch();
            watch.Start();
            using (var task = Task.Delay(2000))
            {
                task.Wait();
            }

            watch.Stop();

            Console.WriteLine("Time elapsed: " + watch.Elapsed);
            
            
        }       
    }
}
