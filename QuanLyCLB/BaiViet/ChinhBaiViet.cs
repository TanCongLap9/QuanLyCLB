using System.Windows.Forms;
using ReaLTaiizor.Controls;
using QuanLyCLB.Properties;
using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System.Threading;
using System;
using QuanLyCLB.Commands.BaiViet;

namespace QuanLyCLB.BaiViet
{
    public partial class ChinhBaiViet : PoisonUserControl
    {
        private string noiDung;
        private string tieuDe;
        private CauLacBoModel cauLacBo;
        private NguoiDungModel nguoiDung;

        public event EventHandler GuiThanhCong;

        public ChinhBaiViet()
        {
            InitializeComponent();
        }

        public new void Show(string tieuDe, string noiDung, CauLacBoModel cauLacBo, NguoiDungModel nguoiDung)
        {
            this.tieuDe = tieuDe;
            this.noiDung = noiDung;
            this.cauLacBo = cauLacBo;
            this.nguoiDung = nguoiDung;
            tTieuDe.Text = tieuDe;
            tCauLacBo.Text = cauLacBo.TenCLB;
            tTacGia.Text = GiaoDienChinh.GiaoDienChinh.NguoiDung.HoTen;
            base.Show();
        }

        public void Update(string tieuDe, string noiDung)
        {
            this.tieuDe = tieuDe;
            this.noiDung = noiDung;
            tTieuDe.Text = tieuDe;
        }

        private async void Button_Click(object sender, System.EventArgs e)
        {
            if (sender == bTaiLen)
            {
                if (PoisonMessageBox.Show(this,
                    string.Format(BaiVietRes.SoanBaiViet_Gui_XacNhan_NoiDung_1, cauLacBo.TenCLB),
                    BaiVietRes.SoanBaiViet_Gui_XacNhanGui_TieuDe,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) != DialogResult.Yes) return;
                try
                {
                    await new ThemBaiViet(new BaiVietModel
                    {
                        MaBaiViet = IDGenerator.Generate(IDGenerator.IDType.BaiViet),
                        MaTacGia = nguoiDung.MaNguoiDung,
                        MaCLB = cauLacBo.MaCLB,
                        ThoiGianTao = DateTime.Now,
                        CacNhan = tCacNhan.Text,
                        TieuDe = tieuDe,
                        NoiDung = noiDung
                    }).Execute(CancellationToken.None);
                    PoisonMessageBox.Show(this,
                        string.Format(BaiVietRes.SoanBaiViet_Gui_HoanThanh_NoiDung_2, tTieuDe.Text, cauLacBo.TenCLB),
                        BaiVietRes.SoanBaiViet_Gui_HoanThanh_TieuDe,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    GuiThanhCong?.Invoke(this, new System.EventArgs());
                }
                catch (Exception exc)
                {
                    PoisonMessageBox.Show(this,
                        string.Format(BaiVietRes.SoanBaiViet_Gui_Loi_NoiDung_1, exc.Message),
                        BaiVietRes.SoanBaiViet_Gui_Loi_TieuDe,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else if (sender == bHuy)
                Hide();
        }
    }
}
