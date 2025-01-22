using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using ReaLTaiizor.Controls;
using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using System.Windows.Forms;
using ReaLTaiizor.Manager;
using ReaLTaiizor.Colors;
using QuanLyCLB.Commands.DuongLinkCauLacBo;
using System;
using System.Threading;
using QuanLyCLB.EventArgs;

namespace QuanLyCLB.CauLacBo
{
    public partial class ThongTinCLB : PoisonUserControl
    {
        private List<DuongLinkCLBModel> CacLienKet;
        private bool loaded;

        public ThongTinCLB()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                InitializeComponent();
        }

        private void OnThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            ColorUtils.SetColor(this, e.Theme, e.Style);
            ColorUtils.SetColor(tMoTaClb, e.Theme);
            ColorUtils.SetColor(listView, e.Theme);
        }

        public async void Init(PoisonStyleManager poisonStyleManager, CauLacBoModel cauLacBo)
        {
            if (loaded) return;
            loaded = true;
            InitUtils.Init(poisonStyleManager, this, InitializeComponent);
            ColorUtils.SetColor(tMoTaClb, poisonStyleManager.Theme);
            ColorUtils.SetColor(listView, poisonStyleManager.Theme);
            Program.ThemeChanged += OnThemeChanged;

            CacLienKet = new List<DuongLinkCLBModel>();
            lTenClb.Text = cauLacBo.TenCLB;
            tMoTaClb.Text = cauLacBo.MoTa;

            listView.Items.Clear();
            try
            {
                await new DanhSachDuongLinkCLB(cauLacBo).OnNext(model2 =>
                {
                    CacLienKet.Add(model2);
                    listView.Items.Add(new ListViewItem(new string[] { model2.NenTang, model2.DuongLienKet }));
                }).Execute(CancellationToken.None);

                foreach (ColumnHeader column in listView.Columns)
                    column.Width = -1;
            }
            catch (Exception exc)
            {

            }
        }

        protected override void OnHandleDestroyed(System.EventArgs e)
        {
            base.OnHandleDestroyed(e);
            Program.ThemeChanged -= OnThemeChanged;
        }

        private void Control_Enter(object sender, System.EventArgs e)
        {
            lTenClb.Focus();
        }
    }
}
