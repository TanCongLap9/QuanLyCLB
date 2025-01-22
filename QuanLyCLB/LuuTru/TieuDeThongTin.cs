using ReaLTaiizor.Controls;
using System.ComponentModel;

namespace QuanLyCLB.LuuTru
{
    public partial class TieuDeThongTin : PoisonUserControl
    {
        private string title;
        
        public TieuDeThongTin()
        {
            InitializeComponent();
            Title = null;
        }

        public TieuDeThongTin(string text)
        {
            InitializeComponent();
            Title = text;
        }

        [DefaultValue(null)]
        public string Title
        {
            get { return title; }
            set { title = poisonLabel29.Text = value; }
        }
    }
}
