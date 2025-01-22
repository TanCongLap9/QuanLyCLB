using System.Windows.Forms;

namespace QuanLyCLB.Commands.SoanBaiViet
{
    public class Cite : Command
    {
        public Cite(TextBox textBox) : base(textBox) { }

        public override void Execute()
        {
            int selStart = TextBox.SelectionStart;
            int selLen = TextBox.SelectionLength;
            int startLineIndex = GetLineFromCharIndex(selStart);
            int firstIndex = GetFirstCharIndexFromLine(startLineIndex);
            TextBox.Select(firstIndex, 0);
            TextBox.SelectedText = "> ";
            selStart += "> ".Length;
            TextBox.Select(selStart, selLen);
            TextBox.Focus();
        }
    }
}
