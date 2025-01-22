using QuanLyCLB.BaiViet;
using QuanLyCLB.Commands.ThanhVien;
using QuanLyCLB.EventArgs;
using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Manager;
using System;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyCLB.CauLacBo
{
    public partial class CauLacBo : PoisonUserControl
    {
        private CauLacBoModel CauLacBoModel;
        private ThanhVienModel ThanhVien;
        private readonly PoisonStyleManager PoisonStyleManager;

        public CauLacBo()
        {
            InitializeComponent();
        }

        public CauLacBo(PoisonStyleManager poisonStyleManager, CauLacBoModel model)
        {
            CauLacBoModel = model;
            PoisonStyleManager = poisonStyleManager;
            InitializeComponent();
        }

        private void OnThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            ColorUtils.SetColor(this, e.Theme, e.Style);
        }

        protected override async void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode) return;
            Program.ThemeChanged += OnThemeChanged;
            try
            {
                ThanhVien = await new ThongTinThanhVien(CauLacBoModel, GiaoDienChinh.GiaoDienChinh.NguoiDung)
                    .Execute(CancellationToken.None);
                lTenCLB.Text = CauLacBoModel.TenCLB;
                poisonTabControl1_Selected(poisonTabControl1,
                    new TabControlEventArgs(
                        poisonTabControl1.SelectedTab,
                        poisonTabControl1.SelectedIndex,
                        TabControlAction.Selected
                    )
                );
            }
            catch (Exception exc)
            {
                PoisonMessageBox.Show(this,
                    string.Format(Resources.CauLacBo_Loi_NoiDung_1, exc.Message),
                    Resources.CauLacBo_Loi_TieuDe,
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

        private void poisonTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            /*if (e.TabPage == tabBangDieuKhien)
                bangDieuKhien1.Init(Model.MaCLB);*/
            if (e.TabPage == tabBaiViet)
                danhSachBaiViet1.Init(PoisonStyleManager, ThanhVien, CauLacBoModel);
            else if (e.TabPage == tabThongTin)
                thongTinCLB1.Init(PoisonStyleManager, CauLacBoModel);
            else if (e.TabPage == tabLich)
                quanLyLich1.Init(PoisonStyleManager, ThanhVien, CauLacBoModel);
            else if (e.TabPage == tabThanhVien)
                thanhVien1.Init(PoisonStyleManager, ThanhVien, CauLacBoModel);
            else if (e.TabPage == tabLuuTru)
                luuTru1.Init(PoisonStyleManager, ThanhVien, CauLacBoModel);
        }

        private void bLayoutOrientation_Click(object sender, System.EventArgs e)
        {
            Dispose();
        }

        private void dsBaiViet1_BaiVietMoi(object sender, System.EventArgs e)
        {
            new SoanBaiViet(CauLacBoModel).Show();
        }
    }
}
