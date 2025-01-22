using QuanLyCLB.BaiViet;
using QuanLyCLB.Commands.BaiViet;
using QuanLyCLB.EventArgs;
using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Poison;
using ReaLTaiizor.Forms;
using System;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyCLB
{
    public partial class XemBaiViet : PoisonForm
    {
        private Loader Loader;
        private BaiVietModel BaiViet;

        public XemBaiViet()
        {
            InitializeComponent();
        }

        public XemBaiViet(BaiVietModel baiViet)
        {
            InitializeComponent();
            BaiViet = baiViet;
        }

        private void OnThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            poisonStyleManager1.Theme = e.Theme;
            poisonStyleManager1.Style = e.Style;
            ColorUtils.SetColor(this, e.Theme, e.Style);
        }

        protected override async void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);
            GiaoDienChinh.GiaoDienChinh.CacFormDangMo.Add(this);
            ColorUtils.SetColor(this, poisonStyleManager1.Theme, poisonStyleManager1.Style);
            Program.ThemeChanged += OnThemeChanged;

            try
            {
                BaiViet = await new ThongTinBaiViet(BaiViet.MaBaiViet).Execute(CancellationToken.None);
                Text = BaiViet.TieuDe;
                Loader = new Loader(chromiumWebBrowser1, BaiViet);
                chromiumWebBrowser1_IsBrowserInitializedChanged(null, null);
            }
            catch (Exception exc)
            {
                PoisonMessageBox.Show(this,
                    string.Format(BaiVietRes.XemBaiViet_Loi_NoiDung_1, exc.Message),
                    BaiVietRes.XemBaiViet_Loi_TieuDe,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            GiaoDienChinh.GiaoDienChinh.CacFormDangMo.Remove(this);
            Program.ThemeChanged -= OnThemeChanged;
        }

        private void chromiumWebBrowser1_IsBrowserInitializedChanged(object sender, System.EventArgs e)
        {
            if (chromiumWebBrowser1.IsBrowserInitialized && Loader != null)
                Loader.Preview();
        }
    }
}
