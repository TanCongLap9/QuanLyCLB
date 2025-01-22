using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLB
{
    public partial class CoverPictureBox : UserControl
    {
        private CoverPictureBoxSizeMode _sizeMode;

        public CoverPictureBox()
        {
            InitializeComponent();
            SizeMode = CoverPictureBoxSizeMode.Normal;
        }

        [DefaultValue(CoverPictureBoxSizeMode.Normal)]
        public CoverPictureBoxSizeMode SizeMode
        {
            get { return _sizeMode; }
            set { _sizeMode = value; Invalidate(); }
        }

        [DefaultValue(null)]
        public string ImageLocation
        {
            get { return pictureBox1.ImageLocation; }
            set { pictureBox1.ImageLocation = value; }
        }

        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);
            if (pictureBox1 == null || pictureBox1.Image == null) return;
            double pictureAspectRatio = pictureBox1.Image.Width / (double)pictureBox1.Image.Height;
            double controlAspectRatio = this.Width / (double)this.Height;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            switch (this.SizeMode)
            {
                case CoverPictureBoxSizeMode.Normal:
                case CoverPictureBoxSizeMode.StretchImage:
                case CoverPictureBoxSizeMode.AutoSize:
                case CoverPictureBoxSizeMode.CenterImage:
                case CoverPictureBoxSizeMode.Zoom:
                    pictureBox1.Size = this.Size;
                    pictureBox1.SizeMode = (PictureBoxSizeMode)(int)this.SizeMode;
                    break;
                case CoverPictureBoxSizeMode.PreserveWidth:
                    pictureBox1.Size = new Size(this.Width, (int)(this.Width / pictureAspectRatio));
                    break;
                case CoverPictureBoxSizeMode.PreserveHeight:
                    pictureBox1.Size = new Size((int)(this.Height * pictureAspectRatio), this.Height);
                    break;
                case CoverPictureBoxSizeMode.Cover:
                    if (controlAspectRatio > pictureAspectRatio)
                        pictureBox1.Size = new Size(this.Width, (int)(this.Width / pictureAspectRatio));
                    else
                        pictureBox1.Size = new Size((int)(this.Height * pictureAspectRatio), this.Height);
                    break;
            }
            pictureBox1.Location = new Point((this.Width - pictureBox1.Width) / 2, (this.Height - pictureBox1.Height) / 2);
        }

        [DefaultValue(null)]
        public Image Image
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }
    }

    public enum CoverPictureBoxSizeMode
    {
        Normal,
        StretchImage,
        AutoSize,
        CenterImage,
        Zoom,
        /// <summary>
        /// Matches picture width with control width while keeping aspect ratio.
        /// </summary>
        PreserveWidth,
        /// <summary>
        /// Matches picture height with control height while keeping aspect ratio.
        /// </summary>
        PreserveHeight,
        /// <summary>
        /// Matches either picture width/height with control width/height so that it fills the control while keeping aspect ratio.
        /// </summary>
        Cover
    }
}
