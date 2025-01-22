using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCLB.Utils
{
    public static class DateUtils
    {
        public static DateTime GetMonday(DateTime dt)
        {
            return dt.AddDays(-((int)dt.DayOfWeek + 6) % 7);
        }

        public static int GetOffsetFromMonday(DateTime dt)
        {
            return ((int)dt.DayOfWeek + 6) % 7;
        }
    }
}
