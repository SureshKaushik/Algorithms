﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DSAlgorithms
{
    public class Clock
    {
        private int hour;
        private int minute;
        private int second;

        public delegate void TimeChangeHandler(object clock, TimeEventAgrs timeInfo);
        public TimeChangeHandler TimeChanged;

        public void RunClock()
        { 
            while(true)
            {
                Thread.Sleep(100);
                DateTime currentTime = DateTime.Now;

                if(currentTime.Second != this.second)
                {
                    TimeEventAgrs timeEventAgrs = new TimeEventAgrs()
                    {
                        Hour = currentTime.Hour,
                        Minute = currentTime.Minute,
                        Second = currentTime.Second
                    };

                    if (TimeChanged != null)
                    {
                        TimeChanged(this, timeEventAgrs);
                    }

                    this.second = currentTime.Second;
                    this.minute = currentTime.Minute;
                    this.hour = currentTime.Hour;
                }
            }
        }
    }
}
