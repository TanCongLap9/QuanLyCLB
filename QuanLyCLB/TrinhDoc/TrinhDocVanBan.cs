using QuanLyCLB.Commands.LuuTru;
using QuanLyCLB.LuuTru;
using QuanLyCLB.Models;
using ReaLTaiizor.Manager;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.TrinhDoc
{
    public partial class TrinhDocVanBan : TrinhDoc
    {
        public TrinhDocVanBan()
        {
            InitializeComponent();
        }

        public TrinhDocVanBan(PoisonStyleManager poisonStyleManager, ThongTinFile container, TapTinModel model) : base(poisonStyleManager, container, model)
        {
            InitializeComponent();
        }

        public override string ApplicationName { get { return "Text Viewer"; } }

        public override async Task Init()
        {
            try
            {
                await base.Init();
                MoTapTin = new ThongTinTapTin(Model, true).OnResult(model => Model = model);
                await MoTapTin.Execute(CancellationToken.None);
                string rawText = new StreamReader(Model.NoiDung).ReadToEnd();
                // Chuyển đổi kiểu xuống dòng
                textBox1.Text = Regex.Replace(rawText, "\r(?!\n)|(?<!\r)\n", "\r\n");
            }
            catch { this.Dispose(); }
        }
    }
}
