using System.Text;
using System.Windows.Forms;

namespace QuanLyCLB.Commands.SoanBaiViet
{
    public class Table : Command
    {
        private int Width, Height;
        public Table(TextBox textBox, int width, int height) : base(textBox)
        {
            Width = width;
            Height = height;
        }

        public override void Execute()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < Width; i++)
                sb.Append("|    ");
            sb.Append("|\r\n");
            for (int i = 0; i < Width; i++)
                sb.Append("|----");
            sb.Append("|\r\n");
            for (int i = 1; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                    sb.Append("|    ");
                sb.Append("|\r\n");
            }
            sb.Append("\r\n");
            TextBox.SelectedText = sb.ToString();
            TextBox.Focus();
        }
    }
}
