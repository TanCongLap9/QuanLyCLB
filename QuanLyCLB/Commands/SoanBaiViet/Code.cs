using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyCLB.Commands.SoanBaiViet
{
    public class Code : Command
    {
        public Code(TextBox textBox) : base(textBox) { }

        public override void Execute()
        {
            int selStart = TextBox.SelectionStart;
            int selLen = TextBox.SelectionLength;
            Regex start = new Regex(@"(?'start'^```\w*\r\n)");
            Regex end = new Regex(@"(?'end'\r\n```)");
            string startCode = "```html\r\n";
            string endCode = "\r\n```";
            Match match;

            SelectBlock();
            if (IsSurround(start, end, out match))
            {
                Group gStart = match.Groups["start"];
                Group gEnd = match.Groups["end"];
                TextBox.Select(gEnd.Index, gEnd.Length);
                TextBox.SelectedText = string.Empty;
                TextBox.Select(gStart.Index, gStart.Length);
                TextBox.SelectedText = string.Empty;
                selStart -= gStart.Length;
            }
            else
            {
                Surround(startCode, endCode);
                selStart += startCode.Length;
            }
            TextBox.Select(Math.Max(0, selStart), selLen);
            TextBox.Focus();
        }
    }
}
