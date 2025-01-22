using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyCLB.Commands.SoanBaiViet
{
    public class AlignText : Command
    {
        public const string Left = "left";
        public const string Center = "center";
        public const string Right = "right";
        public const string Justify = "justify";
        private readonly string Align;

        public AlignText(TextBox textBox, string align) : base(textBox)
        {
            Align = align;
        }

        public override void Execute()
        {
            string startTag = $"<p align='{Align}'>";
            string endTag = "</p>";

            Match match;
            if (!IsSurround(new Regex("(?'start'<p align='(?'align'left|center|right|justify)'>)"), new Regex("(?'end'</p>)"), out match, "innerHTML"))
            {
                Surround(startTag, endTag);
                TextBox.Focus();
                return;
            }
            Group gStart = match.Groups["start"];
            Group gAlign = match.Groups["align"];
            Group gContent = match.Groups["innerHTML"];
            Group gEnd = match.Groups["end"];
            if (gAlign.Value == Align)
            {
                TextBox.Select(gEnd.Index, gEnd.Length);
                TextBox.SelectedText = string.Empty;
                TextBox.Select(gStart.Index, gStart.Length);
                TextBox.SelectedText = string.Empty;
                TextBox.Select(Math.Max(0, gStart.Index), gContent.Length);
            }
            else
            {
                TextBox.Select(gStart.Index, gStart.Length);
                TextBox.SelectedText = startTag;
                TextBox.Select(Math.Max(0, gStart.Index + startTag.Length), gContent.Length);
            }
            TextBox.Focus();
        }
    }
}
