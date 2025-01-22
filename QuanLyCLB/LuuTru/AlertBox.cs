using ReaLTaiizor.Controls;

namespace QuanLyCLB.LuuTru
{
    public partial class AlertBox : PoisonUserControl
    {
        public const int DefaultTime = 3000;

        public AlertBox()
        {
            InitializeComponent();
        }

        public void Alert(string text, int ms = DefaultTime)
        {
            lAlert.Text = text;
            this.Show();
            timer1.Stop();
            timer1.Interval = ms;
            timer1.Start();
        }

        public void Alert(string text, params object[] objs)
        {
            lAlert.Text = string.Format(text, objs);
            this.Show();
            timer1.Stop();
            timer1.Interval = DefaultTime;
            timer1.Start();
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            this.Hide();
            timer1.Stop();
        }

        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);
            if (Parent == null) return;
            this.Left = (Parent.Width - this.Width) / 2;
        }
    }
}
