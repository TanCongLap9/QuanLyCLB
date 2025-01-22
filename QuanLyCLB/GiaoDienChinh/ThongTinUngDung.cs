using QuanLyCLB.EventArgs;
using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLB.GiaoDienChinh
{
    public partial class ThongTinUngDung : PoisonUserControl
    {
        private bool loaded;

        public ThongTinUngDung()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                InitializeComponent();
        }

        private void OnThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            ColorUtils.SetColor(this, e.Theme, e.Style);
        }

        public void Init(PoisonStyleManager poisonStyleManager)
        {
            if (loaded) return;
            loaded = true;
            InitUtils.Init(poisonStyleManager, this, InitializeComponent);
            Program.ThemeChanged += OnThemeChanged;

            lPhienBan.Text = Application.ProductVersion;
        }

        protected override void OnHandleDestroyed(System.EventArgs e)
        {
            base.OnHandleDestroyed(e);
            Program.ThemeChanged -= OnThemeChanged;

        }
    }
}
