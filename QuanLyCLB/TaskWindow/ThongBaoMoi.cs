using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;
using QuanLyCLB.Models;
using ReaLTaiizor.Forms;
using QuanLyCLB.Utils;

namespace QuanLyCLB.TaskWindow
{
    public partial class ThongBaoMoi : PoisonUserControl
    {
        private PoisonForm Form;
        public ThongBaoMoi()
        {
            InitializeComponent();
        }

        protected override void OnParentChanged(System.EventArgs e)
        {
            base.OnParentChanged(e);
            if (!(ParentForm is PoisonForm)) return;
            PoisonForm form = (PoisonForm)ParentForm;
            Form = form;
            poisonStyleManager1.Owner = form;
            ColorUtils.SetColor(form, poisonStyleManager1.Theme, poisonStyleManager1.Style);
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            if (sender == bXem && GiaoDienChinh.GiaoDienChinh.Instance != null)
            {
                GiaoDienChinh.GiaoDienChinh.Instance.SelectThongBaoTab();
                Form.Dispose();
            }
        }
    }
}
