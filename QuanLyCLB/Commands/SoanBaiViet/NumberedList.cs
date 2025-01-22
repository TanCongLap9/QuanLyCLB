using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyCLB.Commands.SoanBaiViet
{
    public class NumberedList : Command
    {
        public static readonly Regex NumberRegex = new Regex(@"^\s*((\d+)\. )");
        public NumberedList(TextBox textBox) : base(textBox) { }

        public static int GetNextNumber(int startLineIndex, string[] lines)
        {
            Match match;
            int lastNumber = 0;
            if (startLineIndex > 0 && (match = NumberRegex.Match(lines[startLineIndex - 1])).Success)
                lastNumber = int.Parse(match.Groups[2].Value);
            return lastNumber + 1;
        }

        public override void Execute()
        {
            int selStart = TextBox.SelectionStart;
            int selLen = TextBox.SelectionLength;
            int firstIndex = GetFirstCharIndexOfCurrentLine();
            int startLineIndex = GetLineFromCharIndex(selStart);
            string startLine = GetStartLine();

            Match match;
            if ((match = NumberRegex.Match(startLine)).Success)
            {
                Group gNumber = match.Groups[1];
                TextBox.Select(firstIndex + gNumber.Index, gNumber.Length);
                TextBox.SelectedText = string.Empty;
                selStart -= gNumber.Length;
            }
            else if ((match = BulletedList.BulletRegex.Match(startLine)).Success)
            {
                Group gBullet = match.Groups[1];
                string number = GetNextNumber(startLineIndex, TextBox.Lines) + ". ";
                TextBox.Select(firstIndex + gBullet.Index, gBullet.Length);
                TextBox.SelectedText = number;
                selStart += number.Length - gBullet.Length;
            }
            else if ((match = LineIndentRegex.Match(startLine)).Success)
            {
                Group gIndent = match.Groups[1];
                string number = GetNextNumber(startLineIndex, TextBox.Lines) + ". ";
                TextBox.Select(firstIndex + gIndent.Index, 0);
                TextBox.SelectedText = number;
                selStart += number.Length;
            }
            TextBox.Select(Math.Max(firstIndex, selStart), selLen);
            TextBox.Focus();
        }
    }
}
