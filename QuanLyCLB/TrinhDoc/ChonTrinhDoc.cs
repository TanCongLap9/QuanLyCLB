using QuanLyCLB.EventArgs;
using QuanLyCLB.Utils;
using ReaLTaiizor.Enum.Poison;
using ReaLTaiizor.Forms;
using System.Windows.Forms;

namespace QuanLyCLB.TrinhDoc
{
    public partial class ChonTrinhDoc : PoisonForm
    {
        public LoaiTrinhDoc LoaiTrinhDoc { get; set; }

        public ChonTrinhDoc()
        {
            InitializeComponent();
        }

        private void OnThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            poisonStyleManager1.Theme = e.Theme;
            poisonStyleManager1.Style = e.Style;
            ColorUtils.SetColor(this, e.Theme, e.Style);
        }

        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);
            GiaoDienChinh.GiaoDienChinh.CacFormDangMo.Add(this);
            ColorUtils.SetColor(this, poisonStyleManager1.Theme, poisonStyleManager1.Style);
            Program.ThemeChanged += OnThemeChanged;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            GiaoDienChinh.GiaoDienChinh.CacFormDangMo.Remove(this);
            Program.ThemeChanged -= OnThemeChanged;
        }

        private void Control_Click(object sender, System.EventArgs e)
        {
            if (sender == bImage)
                LoaiTrinhDoc = LoaiTrinhDoc.HinhAnh;
            else if (sender == bText)
                LoaiTrinhDoc = LoaiTrinhDoc.VanBan;
            else if (sender == bDocument)
                LoaiTrinhDoc = LoaiTrinhDoc.TrinhDuyet;
            else if (sender == bVideo)
                LoaiTrinhDoc = LoaiTrinhDoc.Video;
        }
    }
}
