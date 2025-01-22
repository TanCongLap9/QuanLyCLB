using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCLB.Utils
{
    public static class DateTimeExtensions
    {
        public static DateTime SetTick(this DateTime _, int tick)
        {
            return new DateTime(tick);
        }

        public static DateTime SetYear(this DateTime dt, int year)
        {
            return new DateTime(year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, dt.Millisecond);
        }

        public static DateTime SetMonth(this DateTime dt, int month)
        {
            return new DateTime(dt.Year, month, dt.Day, dt.Hour, dt.Minute, dt.Second, dt.Millisecond);
        }

        public static DateTime SetDay(this DateTime dt, int day)
        {
            return new DateTime(dt.Year, dt.Month, day, dt.Hour, dt.Minute, dt.Second, dt.Millisecond);
        }

        public static DateTime SetHour(this DateTime dt, int hour)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, hour, dt.Minute, dt.Second, dt.Millisecond);
        }

        public static DateTime SetMinute(this DateTime dt, int minute)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, minute, dt.Second, dt.Millisecond);
        }

        public static DateTime SetSecond(this DateTime dt, int second)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, second, dt.Millisecond);
        }

        public static DateTime SetMillisecond(this DateTime dt, int millisecond)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, millisecond);
        }
    }
}
