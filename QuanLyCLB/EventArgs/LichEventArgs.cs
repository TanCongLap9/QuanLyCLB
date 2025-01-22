using QuanLyCLB.Models;

namespace QuanLyCLB.EventArgs
{
    public class LichEventArgs : System.EventArgs
    {
        public LichModel Model { get; }
        public LichEventArgs(LichModel model)
        {
            Model = model;
        }
    }
}
