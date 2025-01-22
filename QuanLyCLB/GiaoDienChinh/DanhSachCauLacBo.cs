using System.Collections.Generic;
using System.ComponentModel;
using ReaLTaiizor.Controls;
using QuanLyCLB.Utils;
using QuanLyCLB.Models;
using ReaLTaiizor.Manager;
using System.Windows.Forms;
using System.Threading;
using System;
using QuanLyCLB.Properties;
using QuanLyCLB.EventArgs;

namespace QuanLyCLB.GiaoDienChinh
{
    public partial class DanhSachCauLacBo : PoisonUserControl
    {
        private bool loaded;
        private readonly List<CauLacBoModel> models = new List<CauLacBoModel>();
        private PoisonStyleManager PoisonStyleManager;

        public DanhSachCauLacBo()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                InitializeComponent();
        }

        private void OnThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            ColorUtils.SetColor(this, e.Theme, e.Style);
            ColorUtils.SetColor(listView1, e.Theme);
        }

        public async void Init(PoisonStyleManager poisonStyleManager, NguoiDungModel nguoiDung)
        {
            if (loaded) return;
            loaded = true;
            InitUtils.Init(poisonStyleManager, this, InitializeComponent);
            PoisonStyleManager = poisonStyleManager;
            ColorUtils.SetColor(listView1, poisonStyleManager.Theme);
            Program.ThemeChanged += OnThemeChanged;

            imageList1.Images.Clear();
            listView1.Items.Clear();
            try
            {
                await new Commands.CauLacBo.DanhSachCauLacBo(nguoiDung).OnNext(model =>
                {
                    imageList1.Images.Add(model.MaCLB, ImageUtils.GetCauLacBoImage(model, imageList1.ImageSize));
                    models.Add(model);
                    listView1.Items.Add(model.TenCLB, model.MaCLB);
                }).Execute(CancellationToken.None);
            }
            catch (Exception exc)
            {
                lStatus.BringToFront();
                lStatus.Text = string.Format(Resources.DanhSachCauLacBo_Loi_1, exc.Message);
                lStatus.Show();
            }
        }

        protected override void OnHandleDestroyed(System.EventArgs e)
        {
            base.OnHandleDestroyed(e);
            Program.ThemeChanged -= OnThemeChanged;
        }

        private void listView1_ItemActivate(object sender, System.EventArgs e)
        {
            CauLacBo.CauLacBo cauLacBo = new CauLacBo.CauLacBo(PoisonStyleManager, models[listView1.SelectedIndices[0]]) { Dock = DockStyle.Fill };
            this.Controls.Add(cauLacBo);
            cauLacBo.BringToFront();
        }
    }
}
