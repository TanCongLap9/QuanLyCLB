using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Manager;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace QuanLyCLB.DangKy
{
    public partial class CacAvatar : PoisonUserControl
    {
        private bool loaded;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image Image { get; set; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Stream Stream { get; set; } = new MemoryStream();

        public event EventHandler ImageSelected;

        public CacAvatar()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                InitializeComponent();
        }

        public void Init(PoisonStyleManager poisonStyleManager)
        {
            if (loaded) return;
            loaded = true;
            InitUtils.Init(poisonStyleManager, this, InitializeComponent);
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            if (sender == bTaiLen)
            {
                openFileDialog1.ShowDialog();
            }
            else if (sender is PictureBox)
            {
                PictureBox pb = (PictureBox)sender;
                Image = pb.Image;
                pb.Image.Save(Stream, pb.Image.RawFormat);
                ImageSelected?.Invoke(this, new System.EventArgs());
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                Image image = Image.FromFile(openFileDialog1.FileName);
                Image = ImageUtils.GetThumbnailImage(image, new Size(64, 64));
                Image.Save(Stream, ImageFormat.Png);
                ImageSelected?.Invoke(this, new System.EventArgs());
            }
            catch (Exception exc)
            {
                System.Console.WriteLine(exc);
            }
        }
    }
}
