using QuanLyCLB.Models;
using QuanLyCLB.TaskWindow;
using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using QuanLyCLB.Properties;
using System.Threading;
using QuanLyCLB.EventArgs;

namespace QuanLyCLB.GiaoDienChinh
{
    public partial class GiaoDienChinh : PoisonForm
    {
        private SqlDep Dep;
        public static GiaoDienChinh Instance;
        public static NguoiDungModel NguoiDung { get; private set; }
        public static List<Form> CacFormDangMo { get; } = new List<Form>();

        public GiaoDienChinh()
        {
            InitializeComponent();
        }
        
        public GiaoDienChinh(NguoiDungModel model)
        {
            InitializeComponent();
            NguoiDung = model;
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
            ColorUtils.SetColor(this, poisonStyleManager1.Theme, poisonStyleManager1.Style);
            Program.ThemeChanged += OnThemeChanged;
            Instance = this;
            try
            {

                IEnumerable<CauLacBoModel> cacCauLacBo = await new Commands.CauLacBo.DanhSachCauLacBo(NguoiDung).Execute(CancellationToken.None);
                Dep = new SqlDep(SqlUtils.ThongBao_SqlDependency, new Dictionary<string, object>
                {
                    ["CacMaCauLacBo"] = string.Join(" ", cacCauLacBo.Select(v => v.MaCLB)),
                    ["MaNguoiDung"] = NguoiDung.MaNguoiDung
                });
                Dep.OnChange += Dep_OnChange;
                Dep.Start();

                poisonTabControl1_Selected(
                    poisonTabControl1,
                    new TabControlEventArgs(
                        poisonTabControl1.SelectedTab,
                        poisonTabControl1.SelectedIndex,
                        TabControlAction.Selected
                    )
                );

                if (NguoiDung.MaQuyenHan != NguoiDungModel.QuyenHan_Admin)
                {
                    pQuanLy.Dispose();
                    tabQuanLy.Dispose();
                }
            }
            catch (Exception exc)
            {
                PoisonMessageBox.Show(this,
                    string.Format(Resources.GiaoDienChinh_Loi_NoiDung_1, exc.Message),
                    Resources.GiaoDienChinh_Loi_TieuDe,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                Close();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (CacFormDangMo.Count != 0)
            {
                PoisonMessageBox.Show(this,
                    Resources.GiaoDienChinh_FormDangMo_NoiDung,
                    Resources.GiaoDienChinh_FormDangMo_TieuDe,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            NguoiDung = null;
            Dep.Stop();
            Instance = null;
            ColorUtils.SetColor(this, poisonStyleManager1.Theme, poisonStyleManager1.Style);
            Program.ThemeChanged -= OnThemeChanged;
        }

        public void SelectCauLacBoTab()
        {
            poisonTabControl1.SelectTab(tabCLB);
        }

        public void SelectThongBaoTab()
        {
            poisonTabControl1.SelectTab(tabThongBao);
        }

        public void SelectTaiKhoanTab()
        {
            poisonTabControl1.SelectTab(tabTaiKhoan);
        }

        public void SelectUngDungTab()
        {
            poisonTabControl1.SelectTab(tabUngDung);
        }

        private void Dep_OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (e.Type == SqlNotificationType.Change && e.Source == SqlNotificationSource.Data && e.Info == SqlNotificationInfo.Insert)
                Invoke(new Action(() => TaskWindowUtils.Show(new ThongBaoMoi(), "Thông báo mới")));
        }

        private void poisonTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            iCLB.Visible = iQL.Visible = iThongBao.Visible = iTTTK.Visible = iTTUD.Visible = false;
            if (poisonTabControl1.SelectedTab == tabCLB)
            {
                dsCauLacBo1.Init(poisonStyleManager1, NguoiDung);
                iCLB.Visible = true;
            }
            else if (poisonTabControl1.SelectedTab == tabQuanLy)
            {
                bangDieuKhien1.Init(poisonStyleManager1);
                iQL.Visible = true;
            }
            else if (poisonTabControl1.SelectedTab == tabThongBao)
            {
                danhSachThongBao1.Init(poisonStyleManager1);
                iThongBao.Visible = true;
            }
            else if (poisonTabControl1.SelectedTab == tabTaiKhoan)
            {
                thongTinTaiKhoan1.Init(poisonStyleManager1);
                iTTTK.Visible = true;
            }
            else if (poisonTabControl1.SelectedTab == tabUngDung)
            {
                thongTinUngDung1.Init(poisonStyleManager1);
                iTTUD.Visible = true;
            }
        }

        private void MenuItem_Click(object sender, System.EventArgs e)
        {
            if (sender == lCLB)
                poisonTabControl1.SelectTab(tabCLB);
            else if (sender == lQL)
                poisonTabControl1.SelectTab(tabQuanLy);
            else if (sender == lTTTK)
                poisonTabControl1.SelectTab(tabTaiKhoan);
            else if (sender == lThongBao)
                poisonTabControl1.SelectTab(tabThongBao);
            else if (sender == lTTUD)
                poisonTabControl1.SelectTab(tabUngDung);
            else if (sender == bTuyChinh)
                new TuyChinh().Show();
            else if (sender == lDangXuat)
                this.Close();
        }
    }
}
