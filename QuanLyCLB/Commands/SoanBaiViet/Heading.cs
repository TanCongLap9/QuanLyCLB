using System;
using System.Windows.Forms;

namespace QuanLyCLB.Commands.SoanBaiViet
{
    public class Heading : Command
    {
        public Heading(TextBox textBox) : base(textBox) { }

        public override void Execute()
        {
            int selStart = TextBox.SelectionStart;
            int selLen = TextBox.SelectionLength;
            int startLineIndex = GetLineFromCharIndex(selStart);
            int firstIndex = GetFirstCharIndexFromLine(startLineIndex);
            string startLine = GetStartLine();

            for (int i = 1; i <= 6; i++)
            {
                string hashes = new string('#', i) + " ";
                if (!startLine.StartsWith(hashes)) continue;
                string newHashes = i == 6 ? string.Empty : new string('#', i + 1) + " ";
                TextBox.Select(firstIndex, hashes.Length);
                TextBox.SelectedText = newHashes;
                selStart += newHashes.Length - hashes.Length;
                TextBox.Select(Math.Max(firstIndex, selStart), selLen);
                TextBox.Focus();
                return;
            }
            TextBox.Select(firstIndex, 0);
            TextBox.SelectedText = "# ";
            TextBox.Select(selStart + "# ".Length, selLen);
            TextBox.Focus();
        }
    }
}
