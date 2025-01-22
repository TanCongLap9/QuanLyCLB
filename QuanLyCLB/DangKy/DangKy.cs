using QuanLyCLB.Commands;
using QuanLyCLB.EventArgs;
using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Poison;
using ReaLTaiizor.Forms;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyCLB.DangKy
{
    public partial class DangKy : PoisonForm, IDangKyView
    {
        private readonly DangKyPresenter Presenter;

        public DangKy()
        {
            InitializeComponent();
            Presenter = new DangKyPresenter(this);
        }

        public NguoiDungModel Model
        {
            get
            {
                string salt = PasswordUtils.GetRandomSalt();
                return new NguoiDungModel()
                {
                    MaNguoiDung = IDGenerator.Generate(IDGenerator.IDType.NguoiDung),
                    Ho = tHo.Text.Trim(),
                    Lot = Regex.Replace(tLot.Text.Trim(), @"\s{2,}", " "),
                    Ten = tTen.Text.Trim(),
                    SDT = tSDT.Text.Trim(),
                    GioiTinh = rNu.Checked,
                    NgaySinh = dNgaySinh.Value,
                    Email = tEmail.Text.Trim(),
                    MSSV = tMSSV.Text.Trim(),
                    TenDangNhap = tTenDangNhap.Text.Trim(),
                    MaBaoMat = salt,
                    MatKhau = PasswordUtils.MaHoaTaiKhoan(tTenDangNhap.Text.Trim(), tMatKhau.Text, salt),
                    AnhDaiDien = cacAvatar1.Stream
                };
            }
        }

        private void OnThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            poisonStyleManager1.Theme = e.Theme;
            poisonStyleManager1.Style = e.Style;
            ColorUtils.SetColor(this, e.Theme, e.Style);
        }

        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);
            GiaoDienChinh.GiaoDienChinh.CacFormDangMo.Add(this);
            ColorUtils.SetColor(this, poisonStyleManager1.Theme, poisonStyleManager1.Style);
            cacAvatar1.Image = Resources.user_info_2_64;
            Resources.user_info_2_64.Save(cacAvatar1.Stream, Resources.user_info_2_64.RawFormat);
            Program.ThemeChanged += OnThemeChanged;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            GiaoDienChinh.GiaoDienChinh.CacFormDangMo.Remove(this);
            Program.ThemeChanged -= OnThemeChanged;
        }

        public bool TestInput()
        {
            TextValidator val = new TextValidator(lStatus, poisonTabControl1);
            // Not empty
            if (val
                .NotEmpty(tHo)
                .NotEmpty(tTen)
                .NotEmpty(tSDT)
                .NotEmpty(tEmail)
                .GoToIfInvalid(tabThongTin)
                .Invalid)
                return false;
            if (val
                .NotEmpty(tLopHoc)
                .NotEmpty(tMSSV)
                .GoToIfInvalid(tabHocVan)
                .Invalid)
                return false;
            if (val
                .NotEmpty(tTenDangNhap)
                .NotEmpty(tMatKhau)
                .NotEmpty(tXacNhanMatKhau)
                .GoToIfInvalid(tabTaiKhoan)
                .Invalid)
                return false;
            // Pattern
            if (val.Ho(tHo)
                .GoToIfInvalid(tabThongTin).Invalid)
                return false;
            if (val.Ten(tTen)
                .GoToIfInvalid(tabThongTin).Invalid)
                return false;
            if (val.SDT(tSDT).GoToIfInvalid(tabThongTin).Invalid)
                return false;
            if (val.Email(tEmail).GoToIfInvalid(tabThongTin).Invalid)
                return false;
            if (val.TenDangNhap(tTenDangNhap).GoToIfInvalid(tabTaiKhoan).Invalid)
                return false;
            if (val.MatKHau(tMatKhau).GoToIfInvalid(tabTaiKhoan).Invalid)
                return false;
            // Logic
            if (val.NgaySinh(dNgaySinh).GoToIfInvalid(tabThongTin).Invalid)
                return false;
            if (val.XacNhanMatKhau(tMatKhau, tXacNhanMatKhau).GoToIfInvalid(tabTaiKhoan).Invalid)
                return false;
            return true;
        }

        public void OnSignUpSuccess()
        {
            PoisonMessageBox.Show(this, Resources.DangKy_ThanhCong_NoiDung, Resources.DangKy_ThanhCong_TieuDe, MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        public void SetLoading(bool loading)
        {
            poisonTabControl1.Enabled = !loading;
        }

        public void OnSignUpFailed(Exception exc)
        {
            if (exc is MyFault)
            {
                MyFault myFault = (MyFault)exc;
                PoisonMessageBox.Show(Owner,
                    myFault.Message,
                    myFault.Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                PoisonMessageBox.Show(Owner,
                    string.Format(Resources.DangKy_Loi_NoiDung, exc.Message),
                    Resources.DangKy_Loi_TieuDe, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void bDangKy_Click(object sender, System.EventArgs e)
        {
            await Presenter.DangKy();
        }

        private void cDongY_CheckedChanged(object sender, System.EventArgs e)
        {
            bDangKy.Enabled = cDongY.Checked;
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            cacAvatar1.Visible = !cacAvatar1.Visible;
            cacAvatar1.Init(poisonStyleManager1);
        }

        private void cacAvatar1_ImageSelected(object sender, System.EventArgs e)
        {
            pbAvatar.Image = cacAvatar1.Image;
        }
    }
}
