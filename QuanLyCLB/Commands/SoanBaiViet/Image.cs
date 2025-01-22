using System.Windows.Forms;

namespace QuanLyCLB.Commands.SoanBaiViet
{
    public class Image : Command
    {
        public const string src = "https://cdn-icons-png.freepik.com/256/9776/9776918.png?semt=ais_hybrid";
        public Image(TextBox textBox) : base(textBox) { }

        public override void Execute()
        {
            TextBox.SelectedText = $@"<img src='{src}' width='128' height='128' alt='Mô tả về hình ảnh'>";
            TextBox.Focus();
        }
    }
}
