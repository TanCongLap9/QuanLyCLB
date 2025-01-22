using System.Windows.Forms;

namespace QuanLyCLB.Commands.SoanBaiViet
{
    public class Link : Command
    {
        public Link(TextBox textBox) : base(textBox) { }

        public override void Execute()
        {
            TextBox.SelectedText = "[Ví dụ](https://example.com)";
            TextBox.Focus();
        }
    }
}
