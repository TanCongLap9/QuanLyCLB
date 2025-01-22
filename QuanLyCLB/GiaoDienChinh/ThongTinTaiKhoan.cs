using QuanLyCLB.EventArgs;
using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;

namespace QuanLyCLB.GiaoDienChinh
{
    public partial class ThongTinTaiKhoan : PoisonUserControl
    {
        private bool loaded;

        public ThongTinTaiKhoan()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                InitializeComponent();
        }

        private void OnThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            ColorUtils.SetColor(this, e.Theme, e.Style);
        }

        public async void Init(PoisonStyleManager poisonStyleManager)
        {
            if (loaded) return;
            loaded = true;
            InitUtils.Init(poisonStyleManager, this, InitializeComponent);
            Program.ThemeChanged += OnThemeChanged;

            try
            {
                NguoiDungModel model = await new Commands.NguoiDung.ThongTinNguoiDung(GiaoDienChinh.NguoiDung.MaNguoiDung)
                    .Execute(CancellationToken.None);
                pAnhDaiDien.Image = ImageUtils.GetNguoiDungImage(model, pAnhDaiDien.Size);
                lHoTen.Text = model.HoTen;
                lEmail.Text = model.Email;
                lGioiTinh.Text = model.GioiTinhChuoi;
                lNgaySinh.Text = model.NgaySinhChuoi;
                lSdt.Text = model.SDT;
                lMssv.Text = model.MSSV;
                lTenQuyenHan.Text = model.TenQuyenHan;
                lNgayTao.Text = model.NgayTaoChuoi;
            }
            catch (Exception exc)
            {
                lStatus.BringToFront();
                lStatus.Text = string.Format(Resources.ThongTinTaiKhoan_Loi_1, exc.Message);
                lStatus.Show();
            }
        }

        protected override void OnHandleDestroyed(System.EventArgs e)
        {
            base.OnHandleDestroyed(e);
            Program.ThemeChanged -= OnThemeChanged;
        }
    }
}
