using QuanLyCLB.Commands.LuuTru;
using QuanLyCLB.LuuTru;
using QuanLyCLB.Models;
using ReaLTaiizor.Manager;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.TrinhDoc
{
    public partial class TrinhDuyet : TrinhDoc
    {
        private bool hasData;

        public TrinhDuyet()
        {
            InitializeComponent();
        }

        public TrinhDuyet(PoisonStyleManager poisonStyleManager, ThongTinFile container, TapTinModel model) : base(poisonStyleManager, container, model)
        {
            InitializeComponent();
        }

        public override string ApplicationName { get { return "Chromium Embedded Framework"; } }

        public override async Task Init()
        {
            try
            {
                await base.Init();
                hasData = true;
                chromiumWebBrowser1_IsBrowserInitializedChanged(chromiumWebBrowser1, new System.EventArgs());
            }
            catch { this.Dispose(); }
        }

        private async void chromiumWebBrowser1_IsBrowserInitializedChanged(object sender, System.EventArgs e)
        {
            if (!chromiumWebBrowser1.IsBrowserInitialized || !hasData) return;
            MoTapTin = new ThongTinTapTin(Model, true).OnResult(model => Model = model);
            await MoTapTin.Execute(CancellationToken.None);

            try
            {
                HandlerFactories.LuuTruHandlerFactory.Model = Model;
                chromiumWebBrowser1.Load(HandlerFactories.LuuTruFullPath);
            }
            catch { this.Dispose(); }
        }
    }
}
