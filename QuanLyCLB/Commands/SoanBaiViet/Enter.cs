using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyCLB.Commands.SoanBaiViet
{
    public class Enter : Command
    {
        public Enter(TextBox textBox) : base(textBox) { }

        public override void Execute()
        {
            int selStart = TextBox.SelectionStart;
            int startLineIndex = GetLineFromCharIndex(selStart);
            int firstIndexOfStart = GetFirstCharIndexFromLine(startLineIndex);
            string startLine = GetStartLine();

            string symbol = "\r\n";
            Match match;
            MatchCollection matches;
            if ((match = NumberedList.NumberRegex.Match(startLine)).Success) // Numbered list
            {
                symbol += new string(' ', match.Groups[1].Index) +
                    NumberedList.GetNextNumber(startLineIndex + 1, TextBox.Lines) + ". ";
            }
            else if ((matches = Regex.Matches(startLine, @"([^\|]*)\|")).Count >= 2) // Table
            {
                StringBuilder sb = new StringBuilder("|");
                for (int i = 0; i < matches.Count - 1; i++)
                    symbol += matches[i].Groups[1].Length + "|";
                symbol += sb.ToString();
            }
            else if ((match = BulletedList.BulletRegex.Match(startLine)).Success) // Bulleted list
            {
                symbol += new string(' ', match.Groups[1].Index) +
                    match.Groups[1].Value;
            }
            else if (startLine.StartsWith("> ")) // Cite
            {
                if (startLine == "> ")
                {
                    TextBox.Select(firstIndexOfStart, TextBox.Lines[startLineIndex].Length);
                    TextBox.SelectedText = string.Empty;
                }
                else symbol += "> ";
            }
            else // Next paragraph
            {
                symbol += "\r\n";
            }
            TextBox.SelectedText = symbol;
            TextBox.Focus();
        }
    }
}
