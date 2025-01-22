using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCLB.Lich
{
    public partial class CacThu : PoisonUserControl
    {
        private Size _gioSize;
        private DateTime _date;

        [DefaultValue(typeof(Size), "60, 72")]
        public Size GioSize
        {
            get { return _gioSize; }
            set
            {
                _gioSize = value;
                UpdateCacThu();
            }
        }

        public Size LichSize
        {
            get { return new Size((int)((this.Width - GioSize.Width) / 7.0), GioSize.Height); }
        }
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = DateUtils.GetMonday(value);
                UpdateCacThu();
            }
        }

        public CacThu()
        {
            InitializeComponent();
            GioSize = new Size(60, 72);
        }

        public void UpdateCacThu()
        {
            string[] thus = { "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7", "Chủ nhật" };
            Control[] cs = { thu2, thu3, thu4, thu5, thu6, thu7, chuNhat };
            poisonTile7.Width = GioSize.Width;

            for (int i = 0; i < cs.Length; i++)
            {
                Control c = cs[i];
                c.Text = thus[i] + Environment.NewLine + Date.AddDays(i).ToString("dd/MM");
                c.Left = GioSize.Width + LichSize.Width * i;
                c.Width = LichSize.Width;
            }
        }

        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);
            UpdateCacThu();
        }

        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);
            UpdateCacThu();
        }
    }
}
