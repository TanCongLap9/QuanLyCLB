using System.Windows.Forms;

namespace QuanLyCLB.Commands.SoanBaiViet
{
    public class HRule : Command
    {
        public HRule(TextBox textBox) : base(textBox) { }

        public override void Execute()
        {
            int startLineIndex = GetLineFromCharIndex(TextBox.SelectionStart);
            int firstIndex = GetFirstCharIndexFromLine(startLineIndex);
            string startLine = GetStartLine();

            if (!string.IsNullOrEmpty(startLine))
            {
                TextBox.Select(firstIndex + startLine.Length, 0);
                if (startLineIndex + 2 < TextBox.Lines.Length && string.IsNullOrEmpty(TextBox.Lines[startLineIndex + 2]))
                    TextBox.SelectionStart += 4;
                else if (startLineIndex + 1 < TextBox.Lines.Length && string.IsNullOrEmpty(TextBox.Lines[startLineIndex + 1]))
                {
                    TextBox.SelectionStart += 2;
                    TextBox.SelectedText = "\r\n";
                }
                else TextBox.SelectedText = "\r\n\r\n";
            }
            else if (startLineIndex > 0 && !string.IsNullOrEmpty(TextBox.Lines[startLineIndex - 1]))
                TextBox.SelectedText = "\r\n";
            TextBox.SelectedText = "--------\r\n\r\n";
            TextBox.Focus();
        }
    }
}
