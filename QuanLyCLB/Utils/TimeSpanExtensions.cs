using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCLB.Utils
{
    public static class TimeSpanExtensions
    {
        public static TimeSpan SetTicks(this TimeSpan _, int ticks)
        {
            return new TimeSpan(ticks);
        }

        public static TimeSpan SetDays(this TimeSpan ts, int days)
        {
            return new TimeSpan(days, ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
        }

        public static TimeSpan SetHours(this TimeSpan ts, int hours)
        {
            return new TimeSpan(ts.Days, hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
        }

        public static TimeSpan SetMinutes(this TimeSpan ts, int minutes)
        {
            return new TimeSpan(ts.Days, ts.Hours, minutes, ts.Seconds, ts.Milliseconds);
        }

        public static TimeSpan SetSeconds(this TimeSpan ts, int seconds)
        {
            return new TimeSpan(ts.Days, ts.Hours, ts.Minutes, seconds, ts.Milliseconds);
        }

        public static TimeSpan SetMilliseconds(this TimeSpan ts, int milliseconds)
        {
            return new TimeSpan(ts.Days, ts.Hours, ts.Minutes, ts.Seconds, milliseconds);
        }
    }
}
