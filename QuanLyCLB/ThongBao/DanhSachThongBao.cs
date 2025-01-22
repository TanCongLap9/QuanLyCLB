using QuanLyCLB.EventArgs;
using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLB.ThongBao
{
    public partial class DanhSachThongBao : PoisonUserControl
    {
        private bool loaded;
        private PoisonStyleManager PoisonStyleManager;
        private readonly List<ThongBaoModel> CacThongBao = new List<ThongBaoModel>();

        public DanhSachThongBao()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                InitializeComponent();
        }

        private void OnThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            ColorUtils.SetColor(this, e.Theme, e.Style);
            ColorUtils.SetColor(listView1, e.Theme);
        }

        public async void Init(PoisonStyleManager poisonStyleManager)
        {
            if (!loaded)
            {
                loaded = true;
                InitUtils.Init(poisonStyleManager, this, InitializeComponent);
                PoisonStyleManager = poisonStyleManager;
                ColorUtils.SetColor(listView1, poisonStyleManager.Theme);
                Program.ThemeChanged += OnThemeChanged;
            }

            await Tai();
        }

        protected override void OnHandleDestroyed(System.EventArgs e)
        {
            base.OnHandleDestroyed(e);
            Program.ThemeChanged -= OnThemeChanged;
        }
        
        private async Task Tai()
        {
            try
            {
                CacThongBao.Clear();
                listView1.BeginUpdate();
                listView1.Items.Clear();
                await new Commands.ThongBao.DanhSachThongBao(GiaoDienChinh.GiaoDienChinh.NguoiDung)
                    .OnNext(model =>
                    {
                        CacThongBao.Add(model);
                        listView1.Items.Add(new ListViewItem(new string[] { model.TieuDe, model.ThoiGianTaoChuoi }));
                    })
                    .Execute(CancellationToken.None);
                lStatus.Visible = CacThongBao.Count == 0;
            }
            catch (Exception exc)
            {
                lStatus.Text = exc.Message;
                lStatus.Show();
            }
            finally
            {
                listView1.EndUpdate();
            }
        }

        private async void Button_Click(object sender, System.EventArgs e)
        {
            if (sender == bThongBaoMoi)
            {
                GuiThongBao guiThongBao = new GuiThongBao(PoisonStyleManager) { Dock = DockStyle.Fill };
                this.Controls.Add(guiThongBao);
                guiThongBao.BringToFront();
            }
            else if (sender == bTaiLai) await Tai();
        }

        private void listView1_ItemActivate(object sender, System.EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            XemThongBao xemThongBao = new XemThongBao(PoisonStyleManager, CacThongBao[listView1.SelectedIndices[0]]) { Dock = DockStyle.Fill };
            this.Controls.Add(xemThongBao);
            xemThongBao.BringToFront();
        }
    }
}
