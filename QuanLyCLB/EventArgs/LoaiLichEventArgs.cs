using QuanLyCLB.Lich;
using System.Windows.Forms;

namespace QuanLyCLB.EventArgs
{
    public class LoaiLichEventArgs : MouseEventArgs
    {
        public LoaiLichItem Item { get; }

        public LoaiLichEventArgs(LoaiLichItem item, MouseButtons button, int clicks, int x, int y, int delta) : base(button, clicks, x, y, delta)
        {
            Item = item;
        }

        public LoaiLichEventArgs(MouseEventArgs e, LoaiLichItem item) : base(e.Button, e.Clicks, e.X, e.Y, e.Delta)
        {
            Item = item;
        }
    }
}
