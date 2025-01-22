using QuanLyCLB.Lich;
using QuanLyCLB.Models;

namespace QuanLyCLB.EventArgs
{
    public class SuaLichEventArgs : System.EventArgs
    {
        public LichModel OldModel { get; }
        public LichModel Model { get; }
        public HanhDongSuaLich HanhDongSuaLich { get; }
        public bool HasChanged { get; }
        public bool GuiThongBao { get; }

        public SuaLichEventArgs(LichModel oldModel, LichModel model, HanhDongSuaLich hanhDongSuaLich, bool hasChanged, bool guiThongBao)
        {
            OldModel = oldModel;
            Model = model;
            HanhDongSuaLich = hanhDongSuaLich;
            HasChanged = hasChanged;
            GuiThongBao = guiThongBao;
        }
    }
}
