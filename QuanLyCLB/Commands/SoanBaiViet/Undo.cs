using QuanLyCLB.BaiViet;
using System.Windows.Forms;

namespace QuanLyCLB.Commands.SoanBaiViet
{
    public class Undo : Command
    {
        private readonly TextBoxHistory History;
        public Undo(TextBox textBox, TextBoxHistory history) : base(textBox)
        {
            History = history;
        }

        public override void Execute()
        {
            TextBoxHistory.HistoryEntry undoText = History.Undo();
            if (undoText != null)
            {
                TextBox.Select(0, TextBox.TextLength);
                TextBox.SelectedText = undoText.Text;
                TextBox.Select(undoText.SelectionStart, undoText.SelectionLength);
            }
        }
    }
}
