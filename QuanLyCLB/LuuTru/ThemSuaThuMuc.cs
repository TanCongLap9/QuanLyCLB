using QuanLyCLB.Models;
using QuanLyCLB.Properties;
using ReaLTaiizor.Controls;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyCLB.LuuTru
{
    public partial class ThemSuaThuMuc : PoisonUserControl
    {
        private ThuMucModel model;
        private bool them;
        public event EventHandler Ok;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ThuMucModel Model
        {
            get { return model; }
            set
            {
                model = value;
                if (value == null) return;
                poisonTextBox2.Text = value.TenThuMuc;
                colorDialog1.Color = value.MaMau;
                OnColorUpdated();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Them
        {
            get { return them; }
            set
            {
                them = value;
                lTitle.Text = value
                    ? LuuTruRes.ThuMuc_Them_TieuDe
                    : LuuTruRes.ThuMuc_Sua_TieuDe;
            }
        }

        public ThemSuaThuMuc()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            base.Show();
            poisonTextBox2.Select();
        }

        private void bOk_Click(object sender, System.EventArgs e)
        {
            lLoi.Hide();
            if (string.IsNullOrWhiteSpace(poisonTextBox2.Text))
            {
                poisonTextBox2.WithError = true;
                poisonTextBox2.Focus();
                lLoi.Text = LuuTruRes.ThuMuc_ThemSua_LoiKhongTen;
                lLoi.Show();
                return;
            }
            else if (Regex.IsMatch(poisonTextBox2.Text, @"\\|/|:|\*|\?|""|<|>|\|"))
            {
                poisonTextBox2.WithError = true;
                poisonTextBox2.Focus();
                lLoi.Text = LuuTruRes.ThuMuc_ThemSua_LoiTenChuaKyHieu;
                lLoi.Show();
                return;
            }
            Hide();
            Ok?.Invoke(this, e);
        }

        private void bHuy_Click(object sender, System.EventArgs e)
        {
            lLoi.Hide();
            Hide();
        }

        private void panel1_Click(object sender, System.EventArgs e)
        {
            pColor.BackgroundImage = null;
            if (colorDialog1.ShowDialog() != DialogResult.OK) return;
            OnColorUpdated();
        }

        private void OnColorUpdated()
        {
            Model.MaMau = pColor.BackColor = colorDialog1.Color;
            lMaMau.Text = "#" + (colorDialog1.Color.ToArgb() & 0xffffff).ToString("x6");
        }


        private void panel1_MouseEnter(object sender, System.EventArgs e)
        {
            pColor.BackgroundImage = Resources.color_picker;
        }

        private void panel1_MouseLeave(object sender, System.EventArgs e)
        {
            pColor.BackgroundImage = null;
        }

        private void poisonTextBox2_TextChanged(object sender, System.EventArgs e)
        {
            Model.TenThuMuc = poisonTextBox2.Text;
        }
    }
}
