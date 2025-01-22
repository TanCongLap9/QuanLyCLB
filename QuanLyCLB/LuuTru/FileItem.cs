using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using QuanLyCLB.TrinhDoc;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Input;

namespace QuanLyCLB.LuuTru
{
    public partial class FileItem : UserControl
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TapTinModel Model { get; set; }

        public FileItem()
        {
            InitializeComponent();
        }

        public FileItem(TapTinModel model, ContextMenuStrip contextMenuStrip, ToolTip toolTip)
        {
            InitializeComponent();
            Model = model;
            ContextMenuStrip = contextMenuStrip;
            toolTip.SetToolTip(poisonLabel1, model.TenTapTin);
            poisonLabel1.Text = Model.TenTapTin;
            try
            {
                if (CacDinhDangTapTinDuocHoTroBoiTrinhDoc.HinhAnh.Contains(Path.GetExtension(Model.TenTapTin.ToLower())))
                    using (Image img = Image.FromStream(Model.NoiDung))
                    {
                        Image.GetThumbnailImageAbort abort = new Image.GetThumbnailImageAbort(() => false);
                        double pictureAspectRatio = img.Width / (double)img.Height;
                        double controlAspectRatio = this.Width / (double)this.Height;
                        pictureBox4.Image = img.GetThumbnailImage((int)(pictureBox4.Height * pictureAspectRatio), pictureBox4.Height, abort, IntPtr.Zero);
                    }
                else FallbackImage();
            }
            catch
            {
                FallbackImage();
            }
        }

        public new event EventHandler DoubleClick;
        public new event EventHandler Click;
        public event ToolStripItemClickedEventHandler ContextItemClick;

        public void FallbackImage()
        {
            string phanMoRong = Path.GetExtension(Model.TenTapTin);
            if (CacDinhDangTapTinDuocHoTroBoiTrinhDoc.HinhAnh.Contains(phanMoRong))
                pictureBox4.Image = Resources.image_x_generic;
            else if (CacDinhDangTapTinDuocHoTroBoiTrinhDoc.TruyenThong.Contains(phanMoRong))
                pictureBox4.Image = Resources.video_x_generic;
            else if (CacDinhDangTapTinDuocHoTroBoiTrinhDoc.VanBan.Contains(phanMoRong))
                pictureBox4.Image = Resources.text_x_generic;
            else if (CacDinhDangTapTinDuocHoTroBoiTrinhDoc.TrinhDuyet.Contains(phanMoRong))
                pictureBox4.Image = Resources.chromium_2;
            else
                pictureBox4.Image = Resources.file;
        }

        [DefaultValue(false)]
        public bool Checked
        {
            get { return poisonCheckBox1.Checked; }
            set { poisonCheckBox1.Checked = value; }
        }

        private void File_Click(object sender, System.EventArgs e)
        {
            if (Keyboard.Modifiers.HasFlag(System.Windows.Input.ModifierKeys.Control))
                Checked = true;
            else
            {
                foreach (Control c in this.Parent.Controls)
                    if (c is FileItem)
                        ((FileItem)c).Checked = false;
                Checked = true;
            }
            Click?.Invoke(this, e);
        }

        private void File_DoubleClick(object sender, System.EventArgs e)
        {
            DoubleClick?.Invoke(this, e);
        }

        private void poisonCheckBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            Checked = poisonCheckBox1.Checked;
        }

        private void poisonContextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ContextItemClick?.Invoke(sender, e);
        }

        private void FileItem_Load(object sender, System.EventArgs e)
        {
        }
    }
}
