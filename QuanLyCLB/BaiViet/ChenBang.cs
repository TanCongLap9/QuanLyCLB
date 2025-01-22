using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLB.BaiViet
{
    public partial class ChenBang : PoisonUserControl
    {
        public Size TableSize { get; private set; }
        public new event EventHandler Click;
        private string text;
        private readonly Brush UnselectedBrush = new SolidBrush(Color.FromArgb(0xff, 0xc4, 0x25));
        private readonly Brush SelectedBrush = new SolidBrush(Color.FromArgb(0x00, 0xb1, 0x59));

        public new bool Visible
        {
            get { return base.Visible; }
            set
            {
                base.Visible = value;
                if (!value) return;
                poisonLabel1.Text = text;
                TableSize = Size.Empty;
                flowLayoutPanel1.Refresh();
            }
        }

        public ChenBang()
        {
            InitializeComponent();
            text = poisonLabel1.Text;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = flowLayoutPanel1.CreateGraphics();
            for (int y = 0; y < 12; y++)
                for (int x = 0; x < 12; x++)
                    g.FillRectangle(x < TableSize.Width && y < TableSize.Height ? SelectedBrush : UnselectedBrush,
                        new Rectangle(x * 16, y * 16, 14, 14));
        }

        private void flowLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            for (int y = 0; y < 12; y++)
                for (int x = 0; x < 12; x++)
                    if (new Rectangle(x * 16, y * 16, 14, 14).Contains(e.Location))
                    {
                        TableSize = new Size(x + 1, y + 1);
                        poisonLabel1.Text = string.Format("{0}x{1}", TableSize.Width, TableSize.Height);
                        Invalidate(false);
                        Update();
                        return;
                    }
        }

        private void flowLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            for (int y = 0; y < 12; y++)
                for (int x = 0; x < 12; x++)
                    if (new Rectangle(x * 16, y * 16, 14, 14).Contains(e.Location))
                    {
                        TableSize = new Size(x + 1, y + 1);
                        Hide();
                        Click?.Invoke(this, e);
                        return;
                    }
        }
    }
}
