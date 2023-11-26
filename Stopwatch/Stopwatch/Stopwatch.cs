using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Stopwatch
{
    public class Stopwatch
    {
        private System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
        private TimeSpan timeSpan;

        public void Start()
        {
            if (stopWatch.IsRunning)
            {
                throw new InvalidOperationException("Cannon start: Already running");
            }
            stopWatch.Start();
        }

        public void Stop()
        {
            if (!stopWatch.IsRunning)
            {
                throw new InvalidOperationException("Cannot stop: Already stopped");
            }
            stopWatch.Stop();
        }

        public TimeSpan DisplayTime()
        {
            timeSpan = stopWatch.Elapsed;
            stopWatch.Reset();
            return timeSpan;
        }
    }
}
