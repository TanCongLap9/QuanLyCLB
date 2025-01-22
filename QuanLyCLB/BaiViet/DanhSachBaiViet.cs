using QuanLyCLB.EventArgs;
using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLB.BaiViet
{
    public partial class DanhSachBaiViet : PoisonUserControl
    {
        private bool loaded;
        private CauLacBoModel CauLacBo;
        private ThanhVienModel ThanhVien;
        private readonly List<BaiVietModel> cacBaiViet = new List<BaiVietModel>();
        public event EventHandler BaiVietMoi;

        public DanhSachBaiViet()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                InitializeComponent();
        }

        private void OnThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            ColorUtils.SetColor(this, e.Theme, e.Style);
            ColorUtils.SetColor(listView1, e.Theme);
        }

        public async void Init(PoisonStyleManager poisonStyleManager, ThanhVienModel thanhVien, CauLacBoModel cauLacBo)
        {
            if (loaded) return;
            loaded = true;
            InitUtils.Init(poisonStyleManager, this, InitializeComponent);
            CauLacBo = cauLacBo;
            ThanhVien = thanhVien;
            ColorUtils.SetColor(listView1, Theme);
            Program.ThemeChanged += OnThemeChanged;

            if (ThanhVien.ChucVu != ChucVu.PhoNhom && ThanhVien.ChucVu != ChucVu.TruongNhom &&
                GiaoDienChinh.GiaoDienChinh.NguoiDung.MaQuyenHan != NguoiDungModel.QuyenHan_Admin)
                bBaiVietMoi.Hide();
            await Tai();
        }

        protected override void OnHandleDestroyed(System.EventArgs e)
        {
            base.OnHandleDestroyed(e);
            Program.ThemeChanged -= OnThemeChanged;
        }

        private async Task Tai()
        {
            listView1.BeginUpdate();
            cacBaiViet.Clear();
            listView1.Items.Clear();
            try
            {
                await new Commands.BaiViet.DanhSachBaiViet(CauLacBo).OnNext(model =>
                {
                    cacBaiViet.Add(model);
                    listView1.Items.Add(new ListViewItem(new string[] { model.TieuDe, model.NgayTaoChuoi }));
                }).Execute(CancellationToken.None);
                listView1.EndUpdate();
                lStatus.Text = BaiVietRes.DanhSachBaiViet_Trong;
                lStatus.Visible = cacBaiViet.Count == 0;
            }
            catch (Exception exc)
            {
                lStatus.Text = string.Format(BaiVietRes.DanhSachBaiViet_Loi_1, exc.Message);
                lStatus.Show();
            }
        }

        private async void Button_Click(object sender, System.EventArgs e)
        {
            if (sender == bBaiVietMoi)
                BaiVietMoi?.Invoke(this, e);
            else if (sender == bTaiLai) await Tai();
        }

        private void listView1_ItemActivate(object sender, System.EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0) return;
            new XemBaiViet(cacBaiViet[listView1.SelectedIndices[0]]).Show();
        }
    }
}
