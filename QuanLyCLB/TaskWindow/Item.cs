using QuanLyCLB.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLB.TaskWindow
{
    public class Item
    {
        private readonly ListViewItem ListViewItem;
        private Exception _loi;
        private TinhTrang _tinhTrang;

        public Item(ListViewItem item)
        {
            ListViewItem = item;
        }

        public Exception Loi
        {
            get { return _loi; }
            set
            {
                _loi = value;
                if (value != null)
                    TinhTrang = TinhTrang.Loi;
            }
        }

        public TinhTrang TinhTrang
        {
            get { return _tinhTrang; }
            set
            {
                _tinhTrang = value;
                switch (value)
                {
                    case TinhTrang.DangCho:
                        ListViewItem.SubItems[1].Text = LuuTruRes.TapTin_TaiLenTaiXuongNhieu_TinhTrang_DangCho;
                        ListViewItem.ImageKey = UploadMultipleWindow.DangCho;
                        break;
                    case TinhTrang.HoanThanh:
                        ListViewItem.SubItems[1].Text = LuuTruRes.TapTin_TaiLenTaiXuongNhieu_TinhTrang_HoanThanh;
                        ListViewItem.ImageKey = UploadMultipleWindow.HoanThanh;
                        break;
                    case TinhTrang.DangTaiLen:
                        ListViewItem.SubItems[1].Text = LuuTruRes.TapTin_TaiLenTaiXuongNhieu_TinhTrang_DangTaiLen;
                        ListViewItem.ImageKey = UploadMultipleWindow.DangTaiLen;
                        break;
                    case TinhTrang.DangTaiVe:
                        ListViewItem.SubItems[1].Text = LuuTruRes.TapTin_TaiLenTaiXuongNhieu_TinhTrang_DangTaiVe;
                        ListViewItem.ImageKey = UploadMultipleWindow.DangTaiVe;
                        break;
                    case TinhTrang.Loi:
                        ListViewItem.SubItems[1].Text = Loi is OperationCanceledException
                            ? LuuTruRes.TapTin_TaiLenTaiXuongNhieu_TinhTrang_Huy
                            : string.Format(LuuTruRes.TapTin_TaiLenTaiXuongNhieu_TinhTrang_Loi_1, Loi.Message);
                        ListViewItem.ImageKey = UploadMultipleWindow.Loi;
                        break;
                }
            }
        }
    }

}
