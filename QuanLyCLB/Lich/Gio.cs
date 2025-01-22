using ReaLTaiizor.Controls;

namespace QuanLyCLB.Lich
{
    public partial class Gio : PoisonUserControl
    {
        public int _value;

        public int Value
        {
            get { return _value; }
            set {
                _value = value;
                poisonLabel7.Text = $"{value}:00";
            }
        }

        public Gio()
        {
            InitializeComponent();
            Value = 0;
        }

        public Gio(int value)
        {
            InitializeComponent();
            Value = value;
        }
    }
}
