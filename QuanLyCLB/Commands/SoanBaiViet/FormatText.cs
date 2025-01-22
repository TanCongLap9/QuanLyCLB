using System;
using System.Windows.Forms;

namespace QuanLyCLB.Commands.SoanBaiViet
{
    public class FormatText : Command
    {
        public const string Bold = "**";
        public const string Italic = "*";
        public const string Strike = "~~";
        public const string Sub = "~";
        public const string Sup = "^";
        public const string UnderlineStart = "<u>";
        public const string UnderlineEnd = "</u>";
        private readonly string SymbolStart;
        private readonly string SymbolEnd;

        public FormatText(TextBox textBox, string symbol) : base(textBox)
        {
            SymbolStart = SymbolEnd = symbol;
        }

        public FormatText(TextBox textBox, string symbolStart, string symbolEnd) : base(textBox)
        {
            SymbolStart = symbolStart;
            SymbolEnd = symbolEnd;
        }

        public override void Execute()
        {
            int selStart = TextBox.SelectionStart;
            int selLen = TextBox.SelectionLength;
            if (SymbolStart == "*" && SymbolEnd == "*"
                ? IsSurround("***", "***") || IsSurround("*", "*") && !IsSurround("**", "**")
                : IsSurround(SymbolStart, SymbolEnd))
            {
                TextBox.Select(selStart + selLen, SymbolEnd.Length);
                TextBox.SelectedText = string.Empty;
                TextBox.Select(selStart - SymbolStart.Length, SymbolStart.Length);
                TextBox.SelectedText = string.Empty;
                selStart -= SymbolStart.Length;
                TextBox.Select(Math.Max(0, selStart), selLen);
            }
            else Surround(SymbolStart, SymbolEnd);
            TextBox.Focus();
        }
    }
}
