using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuanLyCLB.Utils
{
    /// <summary>
    /// Processes environment variables contained in strings and expands it into full form
    /// </summary>
    public static class StringUtils
    {
        public static string Expand(string str)
        {
            Regex variablePattern = new Regex("%(.+?)%");
            return variablePattern.Replace(str, match => {
                string expandedVariable = Environment.GetEnvironmentVariable(match.Groups[1].Value);
                return expandedVariable != null ? expandedVariable : "";
            });
        }
    }
}
