using QuanLyCLB.Properties;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLB.Utils
{
    public static class StringExtensions
    {
        public static string SafeSubstring(this string text, int start)
        {
            return text.Substring(Math.Min(text.Length, start));
        }

        public static string SafeSubstring(this string text, int start, int length)
        {
            return text.Substring(Math.Min(text.Length, start), Math.Min(text.Length - start, length));
        }

        public static string SafeRemove(this string text, int start)
        {
            return text.Remove(Math.Min(text.Length, start));
        }

        public static string SafeRemove(this string text, int start, int length)
        {
            return text.Remove(Math.Min(text.Length, start), Math.Min(text.Length - start, length));
        }
    }
}
