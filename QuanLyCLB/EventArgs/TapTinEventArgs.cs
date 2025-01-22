using QuanLyCLB.Models;
using System.Windows.Forms;

namespace QuanLyCLB.EventArgs
{
    public class TapTinEventArgs : System.EventArgs
    {
        public TapTinModel TapTinModel { get; }
        public ListViewItem Item { get; }
        public int Index { get; }

        public TapTinEventArgs(TapTinModel tapTin, ListViewItem item, int index)
        {
            TapTinModel = tapTin;
            Item = item;
            Index = index;
        }
    }
}
