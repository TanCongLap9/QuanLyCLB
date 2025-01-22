using QuanLyCLB.Commands.LuuTru;
using QuanLyCLB.LuuTru;
using QuanLyCLB.Models;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Manager;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.TrinhDoc
{
    public partial class TrinhDoc : PoisonUserControl
    {
        protected ThongTinTapTin MoTapTin;
        protected TapTinModel Model;
        protected readonly PoisonStyleManager PoisonStyleManager;
        protected readonly ThongTinFile MetadataContainer;

        public TrinhDoc()
        {

        }

        public TrinhDoc(PoisonStyleManager poisonStyleManager, ThongTinFile container, TapTinModel model)
        {
            PoisonStyleManager = poisonStyleManager;
            MetadataContainer = container;
            Model = model;
        }

        public virtual string ApplicationName { get { return null; } }

        public virtual async Task Init()
        {
            
        }
    }
}
