using QuanLyCLB.Commands;
using QuanLyCLB.Commands.CauLacBo;
using QuanLyCLB.EventArgs;
using QuanLyCLB.Properties;
using QuanLyCLB.Utils;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Poison;
using ReaLTaiizor.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCLB.Console
{
    public partial class BangDieuKhien : PoisonUserControl
    {
        private bool loaded;
        public const string Success = "Lệnh thực thi thành công.";
        private CauLacBo clb;
        private NguoiDung nd;
        private DuongLinkCauLacBo clbdl;
        private LoaiLich ll;
        private Lich l;
        private ThanhVien tv;
        public static readonly Regex ParameterRegex = new Regex(@"(?'name'\w+)\s*=\s*(?:""(?'value'.*)""|(?'value'\S*))");

        public BangDieuKhien()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                InitializeComponent();
        }

        private void OnThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            ColorUtils.SetColor(this, e.Theme, e.Style);
            ColorUtils.SetColor(tOutput, e.Theme);
        }

        public void Init(PoisonStyleManager poisonStyleManager)
        {
            if (loaded) return;
            loaded = true;
            InitUtils.Init(poisonStyleManager, this, InitializeComponent);
            ColorUtils.SetColor(tOutput, poisonStyleManager.Theme);
            Program.ThemeChanged += OnThemeChanged;

            pMaBaoMat.BringToFront();
            dgvOutput.SelectionMode = DataGridViewSelectionMode.CellSelect;
            clb = new CauLacBo(this);
            nd = new NguoiDung(this);
            clbdl = new DuongLinkCauLacBo(this);
            l = new Lich(this);
            ll = new LoaiLich(this);
            tv = new ThanhVien(this);
        }

        protected override void OnHandleDestroyed(System.EventArgs e)
        {
            base.OnHandleDestroyed(e);
            Program.ThemeChanged -= OnThemeChanged;
        }

        private void Help(string thucThe)
        {
            List<HelpItem> help = new List<HelpItem>
            {
                new HelpItem("help", "help", "Danh sách các thực thể", "help"),
                new HelpItem("help", "help <thực thể>", "Danh sách các lệnh cho thực thể", "help clb")
            };

            List<HelpItem> clb = new List<HelpItem>
            {
                new HelpItem("clb", "clb:", "Danh sách câu lạc bộ", "clb:"),
                new HelpItem("clb+", "clb+ <MaCLB> <TenCLB> <MoTa>", "Thêm câu lạc bộ", "clb+ MaCLB=8sDaA84CLB TenCLB=\"Câu lạc bộ Tiếng Anh\" MoTa=\"Học tiếng Anh\""),
                new HelpItem("clb*", "clb* <MaCLB> [TenCLB] [MoTa]", "Sửa đổi câu lạc bộ", "clb* MaCLB=8sDaA84CLB TenCLB=\"Câu lạc bộ Tiếng Trung\""),
                new HelpItem("clb-", "clb- <MaCLB>", "Xoá câu lạc bộ", "clb- MaCLB=8sDaA84CLB"),
                new HelpItem("clb?", "clb? [MaCLB] [TenCLB] [MoTa]", "Tìm kiếm câu lạc bộ", "clb? MoTa=\"sân khấu\""),
            };

            List<HelpItem> ng = new List<HelpItem>
            {
                new HelpItem("ng+", "ng+ <MaNguoiDung> <Ho> <Lot> <Ten> <SDT> <GioiTinh> <NgaySinh> <Email> <MSSV> <TenDangNhap> <MatKhau> <MaBaoMat>", "Thêm người dùng"),
                new HelpItem("ng*", "ng* <MaNguoiDung> [Ho] [Lot] [Ten] [SDT] [GioiTinh] [NgaySinh] [Email] [MSSV] [TenDangNhap] [MatKhau] [MaBaoMat]", "Sửa đổi người dùng"),
                new HelpItem("ng-", "ng- <MaNguoiDung>", "Xoá người dùng"),
                new HelpItem("ng?", "ng? [MaNguoiDung] [Ho] [Lot] [Ten] [SDT] [GioiTinh] [NgaySinh] [Email] [MSSV] [TenDangNhap]", "Tìm kiếm người dùng", "ng? Ten=a GioiTinh=1"),
            };
            
            List<HelpItem> clbdl = new List<HelpItem>
            {
                new HelpItem("clbdl:", "clbdl: [MaCLB]", "Danh sách đường link câu lạc bộ"),
                new HelpItem("clbdl+", "clbdl+ <MaCLB> <NenTang> <DuongLienKet>", "Thêm đường link câu lạc bộ"),
                new HelpItem("clbdl*", "clbdl* <MaCLB> <MaLienKet> [NenTang] [DuongLienKet]", "Sửa đổi đường link câu lạc bộ"),
                new HelpItem("clbdl-", "clbdl- <MaCLB> <MaLienKet>", "Xoá đường link câu lạc bộ"),
            };
            
            List<HelpItem> l = new List<HelpItem>
            {
                new HelpItem("l:", "l: <MaCLB>", "Danh sách lịch"),
                new HelpItem("l+", "l+ <MaLich> <MaLoaiLich> <ChuDe> <DiaDiem> <LapLai> <NgayBatDau> <NgayKetThuc> <ThoiGianBatDau> <ThoiGianKetThuc> <NoiDung>", "Thêm lịch"),
                new HelpItem("l*", "l* <MaLich> [MaLoaiLich] [ChuDe] [DiaDiem] [LapLai] [NgayBatDau] [NgayKetThuc] [ThoiGianBatDau] [ThoiGianKetThuc] [NoiDung]", "Sửa đổi lịch"),
                new HelpItem("l-", "l- <MaLich>", "Xoá lịch"),
            };
            
            List<HelpItem> ll = new List<HelpItem>
            {
                new HelpItem("ll:", "ll:", "Danh sách loại lịch"),
                new HelpItem("ll+", "ll+ <MaLoaiLich> <TenLoaiLich> <MaMau>", "Thêm loại lịch"),
                new HelpItem("ll*", "ll* <MaLoaiLich> [TenLoaiLich] [MaMau]", "Sửa đổi loại lịch"),
                new HelpItem("ll-", "ll- <MaLoaiLich>", "Xoá loại lịch"),
            };
            
            List<HelpItem> tv = new List<HelpItem>
            {
                new HelpItem("tv:", "tv: <MaCLB>", "Danh sách thành viên", "tv: maclb=8sDaA84CLB"),
                new HelpItem("tv+", "tv+ <MaNguoiDung> <MaCLB> <ChucVu>", "Thêm thành viên"),
                new HelpItem("tv*", "tv* <MaNguoiDung> <MaCLB> [ChucVu]", "Sửa đổi thành viên"),
                new HelpItem("tv-", "tv- <MaNguoiDung> <MaCLB>", "Xoá thành viên"),
            };

            string general = @"Dưới đây là các thực thể có thể chạy lệnh:
help
clb: Câu lạc bộ
clbdl: Đường link câu lạc bộ
ng: Người dùng
l: Lịch
ll: Loại lịch
tv: Thành viên

Nhập 'help <thực thể>' để xem các lệnh cho thực thể đó.";

            if (thucThe != null)
            {
                if ("help".StartsWith(thucThe))
                    Output(help);
                else if ("clb".StartsWith(thucThe))
                    Output(clb);
                else if ("clbdl".StartsWith(thucThe))
                    Output(clbdl);
                else if ("ng".StartsWith(thucThe))
                    Output(ng);
                else if ("l".StartsWith(thucThe))
                    Output(l);
                else if ("ll".StartsWith(thucThe))
                    Output(ll);
                else if ("tv".StartsWith(thucThe))
                    Output(tv);
                else Output($"Thực thể '{thucThe}' không tồn tại.");
            }
            else Output(general);
            /*
                quyen+
                quyen-
                quyen:
                */
        }

        private async Task ParseCommand(string command)
        {
            Match m;
            try
            {
                if ((m = Regex.Match(command, @"^help")).Success)
                    Help(command == "help" ? null : command.Remove(0, "help".Length).Trim());

                else if ((m = Regex.Match(command, @"^clb:")).Success)
                    await clb.DanhSach();
                else if ((m = Regex.Match(command, @"^clb\+")).Success)
                    await clb.Them(command.Substring(m.Length));
                else if ((m = Regex.Match(command, @"^clb\*")).Success)
                    await clb.Sua(command.Substring(m.Length));
                else if ((m = Regex.Match(command, @"^clb-")).Success)
                    await clb.Xoa(command.Substring(m.Length));
                else if ((m = Regex.Match(command, @"^clb\?")).Success)
                    await clb.TimKiem(command.Substring(m.Length));

                else if ((m = Regex.Match(command, @"^ng\+")).Success)
                    await nd.Them(command.Substring(m.Length));
                else if ((m = Regex.Match(command, @"^ng\*")).Success)
                    await nd.Sua(command.Substring(m.Length));
                else if ((m = Regex.Match(command, @"^ng-")).Success)
                    await nd.Xoa(command.Substring(m.Length));
                else if ((m = Regex.Match(command, @"^ng\?")).Success)
                    await nd.TimKiem(command.Substring(m.Length));

                else if ((m = Regex.Match(command, @"^clbdl:")).Success)
                    await clbdl.DanhSach(command.Substring(m.Length));
                else if ((m = Regex.Match(command, @"^clbdl\+")).Success)
                    await clbdl.Them(command.Substring(m.Length));
                else if ((m = Regex.Match(command, @"^clbdl\*")).Success)
                    await clbdl.Sua(command.Substring(m.Length));
                else if ((m = Regex.Match(command, @"^clbdl-")).Success)
                    await clbdl.Xoa(command.Substring(m.Length));
                
                else if ((m = Regex.Match(command, @"^l:")).Success)
                    await l.DanhSach(command.Substring(m.Length));
                else if ((m = Regex.Match(command, @"^l\+")).Success)
                    await l.Them(command.Substring(m.Length));
                else if ((m = Regex.Match(command, @"^l\*")).Success)
                    await l.Sua(command.Substring(m.Length));
                else if ((m = Regex.Match(command, @"^l-")).Success)
                    await l.Xoa(command.Substring(m.Length));
                
                else if ((m = Regex.Match(command, @"^ll:")).Success)
                    await ll.DanhSach();
                else if ((m = Regex.Match(command, @"^ll\+")).Success)
                    await ll.Them(command.Substring(m.Length));
                else if ((m = Regex.Match(command, @"^ll\*")).Success)
                    await ll.Sua(command.Substring(m.Length));
                else if ((m = Regex.Match(command, @"^ll-")).Success)
                    await ll.Xoa(command.Substring(m.Length));
                
                else if ((m = Regex.Match(command, @"^tv:")).Success)
                    await tv.DanhSach(command.Substring(m.Length));
                else if ((m = Regex.Match(command, @"^tv\+")).Success)
                    await tv.Them(command.Substring(m.Length));
                else if ((m = Regex.Match(command, @"^tv\*")).Success)
                    await tv.Sua(command.Substring(m.Length));
                else if ((m = Regex.Match(command, @"^tv-")).Success)
                    await tv.Xoa(command.Substring(m.Length));

                else throw new MyFault("Lệnh không tồn tại: " + command);
            }
            catch (MyFault exc)
            {
                Output(exc.Message);
            }
            catch (Exception exc)
            {
                Output(exc.ToString());
            }
        }

        public void Output(string str)
        {
            tOutput.Show();
            tOutput.Text = str;
            dgvOutput.Hide();
        }

        public void Output(object obj)
        {
            dgvOutput.DataSource = obj;
            dgvOutput.Show();
            dgvOutput.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvOutput.AutoResizeColumns();
            tOutput.Hide();
        }

        public Dictionary<string, object> BuildDictionary(MatchCollection matches, Dictionary<string, Type> types, bool requireAll = true)
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            foreach (Match match in matches)
            {
                string name = match.Groups["name"].Value;
                // Không phân biệt hoa thường
                foreach (string typeName in types.Keys)
                    if (name.Equals(typeName, StringComparison.InvariantCultureIgnoreCase))
                    {
                        name = typeName;
                        break;
                    }
                string value = match.Groups["value"].Value;
                parameters.Add(name, value);
                if (types.ContainsKey(name))
                {
                    if (types[name] == typeof(int))
                        dictionary.Add(name, int.Parse(value));
                    else if (types[name] == typeof(long))
                        dictionary.Add(name, long.Parse(value));
                    else if (types[name] == typeof(string))
                    {
                        object value2;
                        if (value.Equals("null", StringComparison.InvariantCultureIgnoreCase))
                            value2 = DBNull.Value;
                        else value2 = value;
                        dictionary.Add(name, value2);
                    }
                    else if (types[name] == typeof(bool))
                        dictionary.Add(name, value == "true" || value == "1");
                    else if (types[name] == typeof(Guid))
                        dictionary.Add(name, Guid.Parse(value));
                    else if (types[name] == typeof(DateTime))
                        dictionary.Add(name, DateTime.Parse(value));
                    else if (types[name].IsEnum)
                        dictionary.Add(name, Enum.Parse(types[name], value));
                    else throw new MyFault("Kiểu dữ liệu không hỗ trợ: " + types[name].Name);
                }
                else throw new MyFault("Tham số bị thừa: " + types[name].Name);
            }
            if (requireAll) foreach (string parameterName in types.Keys)
            {
                if (!parameters.Keys.Contains(parameterName))
                    throw new MyFault("Tham số bị thiếu: " + parameterName);
            }
            return dictionary;
        }

        private void poisonTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    Task _ = ParseCommand(tCommand.Text);
                    tCommand.Select(0, tCommand.Text.Length);
                    e.SuppressKeyPress = true;
                    break;
            }
        }

        private void tMaBaoMat_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    if (PasswordUtils.MaHoaMaBaoMatQuanLy(tMaBaoMat.Text) == Settings.Default.MaBaoMatQuanLy)
                    {
                        pMaBaoMat.Hide();
                        pQuanLy.Show();
                    }
                    else
                    {
                        lStatus.Style = ColorStyle.Red;
                        lStatus.Text = "Mã bảo mật không đúng.";
                    }
                    tMaBaoMat.Clear();
                    e.SuppressKeyPress = true;
                    break;
            }
        }
    }
}
