using QuanLyCLB.BaiViet;
using System.Windows.Forms;

namespace QuanLyCLB.Commands.SoanBaiViet
{
    public class Redo : Command
    {
        private readonly TextBoxHistory History;
        public Redo(TextBox textBox, TextBoxHistory history) : base(textBox)
        {
            History = history;
        }

        public override void Execute()
        {
            TextBoxHistory.HistoryEntry redoText = History.Redo();
            if (redoText != null)
            {
                TextBox.Select(0, TextBox.TextLength);
                TextBox.SelectedText = redoText.Text;
                TextBox.Select(redoText.SelectionStart, redoText.SelectionLength);
            }
        }
    }
}
