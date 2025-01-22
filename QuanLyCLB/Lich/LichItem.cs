using QuanLyCLB.Models;
using QuanLyCLB.EventArgs;
using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using System;
using System.ComponentModel;
using System.Drawing;

namespace QuanLyCLB.Lich
{
    public partial class LichItem : PoisonUserControl
    {
        private LichModel model;
        public event EventHandler<LichEventArgs> ItemClick;

        public LichItem()
        {
            InitializeComponent();
            Model = null;
        }

        public LichItem(LichModel model)
        {
            InitializeComponent();
            Model = model;
        }

        [DefaultValue(null)]
        public LichModel Model
        {
            get { return model; }
            set {
                model = value;
                if (value == null) return;
                lChuDe.Text = Model.ChuDe;
                lThoiGian.Text = $"{Model.ThoiGianBatDau:hh':'mm} - {Model.ThoiGianKetThuc:hh':'mm}";
                lDiaDiem.Text = Model.DiaDiem;
                Color mauNen = Color.FromArgb((0xff << 24) + Model.MaMau);
                this.BackColor = mauNen;
                this.ForeColor = ColorUtils.TínhRaCáiMàuChữSaoChoNóTươngPhảnVớiCáiMàuNền(mauNen);
            }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ThuIndex { get; set; }

        private void Control_MouseEnter(object sender, System.EventArgs e)
        {
            poisonTile8.Focus();
        }

        private void Control_Click(object sender, System.EventArgs e)
        {
            ItemClick?.Invoke(sender, new LichEventArgs(Model));
        }
    }
}
