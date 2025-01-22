using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyCLB.Commands.SoanBaiViet
{
    public abstract class Command
    {
        public static readonly Regex LineIndentRegex = new Regex(@"^\s*()");
        protected TextBox TextBox;

        protected Command(TextBox textBox)
        {
            TextBox = textBox;
        }

        public abstract void Execute();

        public string GetStartLine()
        {
            if (TextBox.Lines.Length == 0) return string.Empty;
            int startLine = GetLineFromCharIndex(TextBox.SelectionStart);
            return TextBox.Lines[startLine];
        }

        public string GetEndLine()
        {
            if (TextBox.Lines.Length == 0) return string.Empty;
            int endLine = GetLineFromCharIndex(TextBox.SelectionStart + TextBox.SelectionLength);
            return TextBox.Lines[endLine];
        }

        public int GetFirstCharIndexFromLine(int lineIndex)
        {
            if (TextBox.Lines.Length != 0 && (lineIndex < 0 || lineIndex >= TextBox.Lines.Length))
                throw new ArgumentOutOfRangeException(nameof(lineIndex), lineIndex, "Line index is outside of TextBox lines range");
            int total = 0;
            for (int i = 0; i < TextBox.Lines.Length; i++)
            {
                string line = TextBox.Lines[i];
                if (i == lineIndex) return total;
                total += line.Length + 2; // \r\n
            }
            return 0;
        }

        public int GetFirstCharIndexOfCurrentLine()
        {
            int total = 0;
            for (int i = 0; i < TextBox.Lines.Length; i++)
            {
                string line = TextBox.Lines[i];
                if (TextBox.SelectionStart >= total && TextBox.SelectionStart < total + line.Length + 2) return total;
                total += line.Length + 2; // \r\n
            }
            return 0;
        }

        public int GetLineFromCharIndex(int index)
        {
            int total = 0;
            if (TextBox.Lines.Length == 0) return 0;
            for (int i = 0; i < TextBox.Lines.Length; i++)
            {
                string line = TextBox.Lines[i];
                if (index >= total && index < total + line.Length + 2) return i;
                total += line.Length + 2; // \r\n
            }
            return -1;
        }

        public void Surround(string symbolStart, string symbolEnd)
        {
            int selLen = TextBox.SelectionLength;
            TextBox.SelectionLength = 0;
            TextBox.SelectedText = symbolStart;
            TextBox.SelectionStart += selLen;
            TextBox.SelectedText = symbolEnd;
            TextBox.SelectionStart -= selLen + symbolEnd.Length;
            TextBox.SelectionLength = selLen;
        }

        public bool IsSurround(string symbolStart, string symbolEnd)
        {
            int selStart = TextBox.SelectionStart;
            int selLen = TextBox.SelectionLength;
            return selStart >= symbolStart.Length && selStart + selLen < TextBox.TextLength &&
                TextBox.Text.Substring(selStart - symbolStart.Length).StartsWith(symbolStart) &&
                TextBox.Text.Substring(selStart + selLen).StartsWith(symbolEnd);
        }

        public bool IsSurround(Regex regexStart, Regex regexEnd)
        {
            Regex regex = new Regex($"(?<={regexStart})(.*?)(?={regexEnd})", RegexOptions.Singleline | RegexOptions.Multiline);
            Match match = regex.Match(TextBox.Text, TextBox.SelectionStart);
            return match.Success && match.Value == TextBox.SelectedText;
        }

        public bool IsSurround(Regex regexStart, Regex regexEnd, out Match match, string contentName = null)
        {
            Regex regex = new Regex(contentName == null
                ? $"(?<={regexStart})(.*?)(?={regexEnd})"
                : $"(?<={regexStart})(?'{contentName}'.*)(?={regexEnd})", RegexOptions.Singleline | RegexOptions.Multiline);
            match = regex.Match(TextBox.Text, TextBox.SelectionStart);
            return match.Success && match.Value == TextBox.SelectedText;
        }

        // Select a block of text from start line to end line
        public void SelectBlock()
        {
            if (TextBox.Lines.Length == 0) return;
            int selStart = TextBox.SelectionStart;
            int selLen = TextBox.SelectionLength;
            int startLineIndex = GetLineFromCharIndex(selStart);
            int endLineIndex = GetLineFromCharIndex(selStart + selLen);
            int firstIndexOfStart = GetFirstCharIndexFromLine(startLineIndex);
            int firstIndexOfEnd = GetFirstCharIndexFromLine(endLineIndex);
            TextBox.Select(firstIndexOfStart, firstIndexOfEnd - firstIndexOfStart + TextBox.Lines[endLineIndex].Length);
        }
    }
}
