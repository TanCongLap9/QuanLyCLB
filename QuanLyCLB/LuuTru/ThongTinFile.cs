using QuanLyCLB.Models;
using ReaLTaiizor.Controls;
using System.ComponentModel;

namespace QuanLyCLB.LuuTru
{
    public partial class ThongTinFile : PoisonUserControl
    {
        private TapTinModel model;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TapTinModel Model
        {
            get { return model; }
            set
            {
                model = value;
                if (Model == null)
                {
                    iTenFile.Visible = iKieuTapTin.Visible = iDungLuong.Visible =
                        iThoiGianSuaDoi.Visible = iThoiGianTao.Visible =
                        iThoiGianTruyCap.Visible = false;
                    return;
                }
                iTenFile.Visible = iKieuTapTin.Visible = iDungLuong.Visible =
                    iThoiGianSuaDoi.Visible = iThoiGianTao.Visible =
                    iThoiGianTruyCap.Visible = true;
                iTenFile.InfoValue = Model.TenTapTin;
                iKieuTapTin.InfoValue = Model.MimeType;
                iDungLuong.InfoValue = DanhSachTapTin.HumanizeBytes(Model.DungLuong);
                iThoiGianSuaDoi.InfoValue = Model.ThoiGianSuaDoi.ToString("G");
                iThoiGianTao.InfoValue = Model.ThoiGianTao.ToString("G");
                iThoiGianTruyCap.InfoValue = Model.ThoiGianTruyCap.ToString("G");
            }
        }

        public ThongTinFile()
        {
            InitializeComponent();
        }

        public ThongTinFile(TapTinModel model)
        {
            InitializeComponent();
            Model = model;
        }

        public void Add(string title)
        {
            flowLayoutPanel1.Controls.Add(new TieuDeThongTin(title));
        }

        public void Add(string infoName, string infoValue)
        {
            flowLayoutPanel1.Controls.Add(new MucThongTin(infoName, infoValue));
        }

        public void Add(MucThongTin mucThongTin)
        {
            flowLayoutPanel1.Controls.Add(mucThongTin);
        }

        public void Add(TieuDeThongTin tieuDeThongTin)
        {
            flowLayoutPanel1.Controls.Add(tieuDeThongTin);
        }
    }
}
