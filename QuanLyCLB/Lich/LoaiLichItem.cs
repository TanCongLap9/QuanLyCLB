using QuanLyCLB.Models;
using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using System.Drawing;

namespace QuanLyCLB.Lich
{
    public partial class LoaiLichItem : PoisonTile
    {
        private LoaiLichModel _model;

        public LoaiLichModel Model
        {
            get { return _model; }
            set
            {
                _model = value;
                if (value == null) return;
                this.Text = value.TenLoaiLich;
                Color mau = Color.FromArgb((0xff << 24) + value.MaMau);
                this.BackColor = mau;
                this.ForeColor = ColorUtils.TínhRaCáiMàuChữSaoChoNóTươngPhảnVớiCáiMàuNền(mau);
                this.Tag = value;
            }
        }

        public LoaiLichItem()
        {
            InitializeComponent();
        }

        public LoaiLichItem(LoaiLichModel model)
        {
            InitializeComponent();
            Model = model;
        }
    }
}
