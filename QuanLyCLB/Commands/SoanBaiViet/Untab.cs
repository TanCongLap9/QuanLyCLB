using System;
using System.Windows.Forms;

namespace QuanLyCLB.Commands.SoanBaiViet
{
    public class Untab : Command
    {
        public const int SoftTabsAmount = 4;
        public Untab(TextBox textBox) : base(textBox) { }

        public override void Execute()
        {
            int selStart = TextBox.SelectionStart;
            int selLen = TextBox.SelectionLength;
            int startLineIndex = GetLineFromCharIndex(selStart);
            int endLineIndex = GetLineFromCharIndex(selStart + selLen);
            int firstIndexOfStart = GetFirstCharIndexFromLine(startLineIndex);
            int firstIndexOfEnd = GetFirstCharIndexFromLine(endLineIndex);
            if (TextBox.Lines.Length == 0) return;
            for (int i = startLineIndex; i <= endLineIndex; i++)
            {
                int indent = LineIndentRegex.Match(TextBox.Lines[i]).Groups[1].Index;
                int firstIndeXOfCurrentLine = GetFirstCharIndexFromLine(i);
                int softTabsToRemove = Math.Min(SoftTabsAmount, indent);
                TextBox.Select(firstIndeXOfCurrentLine, softTabsToRemove);
                TextBox.SelectedText = string.Empty;
                selStart -= softTabsToRemove;
            }
            if (startLineIndex == endLineIndex)
                TextBox.Select(Math.Max(firstIndexOfStart, selStart), selLen);
            else
            {
                firstIndexOfEnd = GetFirstCharIndexFromLine(endLineIndex);
                TextBox.Select(firstIndexOfStart, firstIndexOfEnd - firstIndexOfStart + TextBox.Lines[endLineIndex].Length);
            }
            TextBox.Focus();
        }
    }
}
