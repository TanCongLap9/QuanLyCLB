using QuanLyCLB.EventArgs;
using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Poison;
using ReaLTaiizor.Forms;
using System;
using System.Windows.Forms;

namespace QuanLyCLB.DangNhap
{
    public partial class DangNhap : PoisonForm, IDangNhapView
    {
        private readonly DangNhapPresenter Presenter;

        public DangNhapModel Model
        {
            get
            {
                return new DangNhapModel()
                {
                    TenDangNhap = tUser.Text,
                    MatKhau = tPass.Text
                };
            }
        }

        public DangNhap()
        {
            InitializeComponent();
            Presenter = new DangNhapPresenter(this);
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
            ColorUtils.SetColor(this, poisonStyleManager1.Theme, poisonStyleManager1.Style);
            Program.ThemeChanged += OnThemeChanged;

            bRemember.Checked = Settings.Default.NhoTenDangNhap;
            if (Settings.Default.NhoTenDangNhap)
            {
                tUser.Text = Settings.Default.TenDangNhap;
                tPass.Select();
            }

            // AutoLogin();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Program.ThemeChanged -= OnThemeChanged;
        }

        public bool TestNhap()
        {
            return new TextValidator(lStatus)
                .NotEmpty(tUser)
                .NotEmpty(tPass)
                .Result;
        }

        private void AutoLogin()
        {
            tUser.Text = "tk1";
            tPass.Text = "Finland";
            bDangNhap.PerformClick();
        }

        public void SetLoading(bool loading)
        {
            tUser.Enabled =
                tPass.Enabled =
                bRemember.Enabled =
                lDangKy.Enabled =
                bDangNhap.Enabled =
                bSettings.Enabled = !loading;
            spinner.Visible = loading;
        }

        public void SetError(string error)
        {
            if (error == null)
                lStatus.Hide();
            else
            {
                lStatus.Text = error;
                lStatus.Show();
            }
        }

        public void GiaoDienChinh(NguoiDungModel nguoiDung)
        {
            Hide();
            new GiaoDienChinh.GiaoDienChinh(nguoiDung).ShowDialog();
            FocusMe();
            Show();
        }

        private async void Control_Click(object sender, System.EventArgs e)
        {
            if (sender == bSettings)
                new TuyChinh().ShowDialog();
            else if (sender == bRemember)
            {
                Settings.Default.NhoTenDangNhap = bRemember.Checked;
                Settings.Default.Save();
            }
            else if (sender == lDangKy)
                new DangKy.DangKy().ShowDialog();
            else if (sender == bDangNhap || sender == bLogin)
                await Presenter.DangNhap();
        }

        public void TaiKhoanChuaDuyet()
        {
            PoisonMessageBox.Show(this,
                Resources.DangNhap_TaiKhoanChuaDuyet_NoiDung,
                Resources.DangNhap_TaiKhoanChuaDuyet_TieuDe,
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information);
        }

        public void TaiKhoanTuChoi()
        {
            PoisonMessageBox.Show(this,
                Resources.DangNhap_TaiKhoanTuChoi_NoiDung,
                Resources.DangNhap_TaiKhoanTuChoi_TieuDe,
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Error);
        }
    }
}
