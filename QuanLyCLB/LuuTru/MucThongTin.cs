using ReaLTaiizor.Controls;
using System.ComponentModel;

namespace QuanLyCLB.LuuTru
{
    public partial class MucThongTin : PoisonUserControl
    {
        private string infoName, infoValue;

        public MucThongTin()
        {
            InitializeComponent();
            InfoName = null;
            InfoValue = null;
        }

        public MucThongTin(string infoName, string infoValue)
        {
            InitializeComponent();
            InfoName = infoName;
            InfoValue = infoValue;
        }

        [DefaultValue(null)]
        public string InfoName
        {
            get { return infoName; }
            set { infoName = poisonLabel3.Text = value; }
        }

        [DefaultValue(null)]
        public string InfoValue
        {
            get { return infoValue; }
            set
            {
                infoValue = lFileName.Text = value;
                poisonToolTip1.SetToolTip(lFileName, value);
            }
        }
    }
}
