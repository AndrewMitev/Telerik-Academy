using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    class Timer
    {
        private int interval;

        public delegate void Execute();

        public Execute AllMethods {get; set;}

        public int Interval { set; get; }


        public Timer(int t)
        {
            this.interval = t;
        }

        public void ExecuteMethods()
        {
            while (true)
            {
                this.AllMethods();
                Thread.Sleep(this.interval * 1000);
            }
        }


    }
}
