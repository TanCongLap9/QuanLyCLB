using System.Windows.Forms;

namespace QuanLyCLB.Commands.SoanBaiViet
{
    public class ShiftEnter : Command
    {
        public ShiftEnter(TextBox textBox) : base(textBox) { }

        public override void Execute()
        {
            TextBox.SelectedText = "\r\n";
            TextBox.Focus();
        }
    }
}
