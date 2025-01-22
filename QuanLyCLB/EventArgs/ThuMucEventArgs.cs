using QuanLyCLB.LuuTru;
using QuanLyCLB.Models;

namespace QuanLyCLB.EventArgs
{
    public class ThuMucEventArgs : System.EventArgs
    {
        public ThuMucModel Model { get; }
        public FolderItem Item { get; }
        public int Index { get; }

        public ThuMucEventArgs(ThuMucModel thuMuc, FolderItem item, int index)
        {
            Model = thuMuc;
            Item = item;
            Index = index;
        }
    }
}
