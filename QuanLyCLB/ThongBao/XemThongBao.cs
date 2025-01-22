using QuanLyCLB.Commands.ThongBao;
using QuanLyCLB.EventArgs;
using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Manager;
using System;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyCLB.ThongBao
{
    public partial class XemThongBao : PoisonUserControl
    {
        private ThongBaoModel ThongBao;
        private readonly PoisonStyleManager PoisonStyleManager;

        public XemThongBao()
        {
            InitializeComponent();
        }

        public XemThongBao(PoisonStyleManager poisonStyleManager, ThongBaoModel thongBao)
        {
            ThongBao = thongBao;
            PoisonStyleManager = poisonStyleManager;
            InitializeComponent();
        }

        private void OnThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            ColorUtils.SetColor(this, e.Theme, e.Style);
            ColorUtils.SetColor(tTieuDe, e.Theme);
            ColorUtils.SetColor(tNoiDung, e.Theme);
        }

        protected override async void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode) return;
            PoisonStyleManager.Update();
            ColorUtils.SetColor(tTieuDe, PoisonStyleManager.Theme);
            ColorUtils.SetColor(tNoiDung, PoisonStyleManager.Theme);
            Program.ThemeChanged += OnThemeChanged;

            try
            {
                ThongBaoModel thongBao = await new ThongTinThongBao(ThongBao.MaThongBao).Execute(CancellationToken.None);
                poisonLabel1.Text = string.Format(BaiVietRes.XemBaiViet_Boi_2, thongBao.HoTen, thongBao.ThoiGianTaoChuoi);
                tTieuDe.Text = thongBao.TieuDe;
                tNoiDung.Text = thongBao.NoiDung;
            }
            catch (Exception exc)
            {
                PoisonMessageBox.Show(this,
                    string.Format(Resources.XemThongBao_Loi_NoiDung_1, exc.Message),
                    Resources.XemThongBao_Loi_TieuDe,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Dispose();
            }
        }

        protected override void OnHandleDestroyed(System.EventArgs e)
        {
            base.OnHandleDestroyed(e);
            Program.ThemeChanged -= OnThemeChanged;
        }

        private void Control_Click(object sender, System.EventArgs e)
        {
            if (sender == bExit) Dispose();
        }

        private void Control_Enter(object sender, System.EventArgs e)
        {
            poisonLabel1.Focus();
        }
    }
}
