using System.Linq;
using System.Windows.Forms;

namespace QuanLyCLB.Commands.SoanBaiViet
{
    public class Tab : Command
    {
        public const int SoftTabsAmount = 4;
        public Tab(TextBox textBox) : base(textBox) { }

        public override void Execute()
        {
            int selStart = TextBox.SelectionStart;
            int selLen = TextBox.SelectionLength;
            int startLineIndex = GetLineFromCharIndex(selStart);
            int endLineIndex = GetLineFromCharIndex(selStart + selLen);
            int firstIndexOfStart = GetFirstCharIndexFromLine(startLineIndex);
            int firstIndexOfEnd = GetFirstCharIndexFromLine(endLineIndex);
            if (startLineIndex == endLineIndex)
            {
                int firstIndexOfStartRel = selStart - firstIndexOfStart;
                string softTab = new string(' ', SoftTabsAmount - firstIndexOfStartRel % SoftTabsAmount);
                TextBox.SelectedText = softTab;
            }
            else
            {
                int minIndent = Enumerable.Range(startLineIndex, endLineIndex - startLineIndex + 1)
                    .Select(i => LineIndentRegex.Match(TextBox.Lines[i]).Groups[1].Index)
                    .Min();
                string softTab = new string(' ', SoftTabsAmount - minIndent % SoftTabsAmount);
                for (int i = startLineIndex; i <= endLineIndex; i++)
                {
                    int firstIndeXOfCurrentLine = GetFirstCharIndexFromLine(i);
                    TextBox.Select(firstIndeXOfCurrentLine, 0);
                    TextBox.SelectedText = softTab;
                }
                firstIndexOfEnd = GetFirstCharIndexFromLine(endLineIndex);
                TextBox.Select(firstIndexOfStart, firstIndexOfEnd - firstIndexOfStart + TextBox.Lines[endLineIndex].Length);
            }
            TextBox.Focus();
        }
    }
}