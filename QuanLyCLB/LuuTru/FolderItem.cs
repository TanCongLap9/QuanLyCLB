using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using QuanLyCLB.EventArgs;
using QuanLyCLB.Utils;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace QuanLyCLB.LuuTru
{
    public partial class FolderItem : UserControl
    {
        private bool open;

        public new event EventHandler<ThuMucEventArgs> Click;

        public FolderItem()
        {
            InitializeComponent();
            Open = false;
        }

        public FolderItem(ThuMucModel model, ContextMenuStrip contextMenuStrip, ToolTip toolTip, int index)
        {
            InitializeComponent();
            Open = false;
            ContextMenuStrip = contextMenuStrip;
            Model = model;
            Index = index;
            poisonTile1.Text = Model.TenThuMuc;
            poisonTile1.TileCount = Model.SoLuongFile;
            this.BackColor = Model.MaMau;
            this.ForeColor = ColorUtils.TínhRaCáiMàuChữSaoChoNóTươngPhảnVớiCáiMàuNền(Model.MaMau);
            pictureBox1.Visible = Model.ThuMucGoc;
            toolTip.SetToolTip(this, model.TenThuMuc);
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Index { get; set; }

        [DefaultValue(null)]
        public ThuMucModel Model { get; set; }

        [DefaultValue(false)]
        public bool Open
        {
            get { return open; }
            set
            {
                open = value;
                poisonTile1.TileImage = value ? LuuTruRes.folder_open_3 : LuuTruRes.folder_641;
                poisonTile1.Invalidate();
            }
        }

        private void poisonTile1_Click(object sender, System.EventArgs e)
        {
            Click?.Invoke(this, new ThuMucEventArgs(Model, this, Index));
        }
    }
}
