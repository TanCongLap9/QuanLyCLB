using QuanLyCLB.Commands.DuongLinkCauLacBo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Console
{
    public class DuongLinkCauLacBo
    {
        private readonly BangDieuKhien bdk;

        public DuongLinkCauLacBo(BangDieuKhien bangDieuKhien)
        {
            bdk = bangDieuKhien;
        }

        public async Task DanhSach(string param)
        {
            Dictionary<string, object> dict = bdk.BuildDictionary(BangDieuKhien.ParameterRegex.Matches(param),
                new Dictionary<string, Type>
                {
                    ["MaCLB"] = typeof(string)
                }, false);
            bdk.Output(await new DanhSachDuongLinkCLB(dict).Execute(CancellationToken.None));
        }

        public async Task Xoa(string param)
        {
            Dictionary<string, object> dict = bdk.BuildDictionary(BangDieuKhien.ParameterRegex.Matches(param),
                new Dictionary<string, Type>
                {
                    ["MaCLB"] = typeof(string),
                    ["MaLienKet"] = typeof(int)
                });
            await new XoaDuongLinkCLB(dict).Execute(CancellationToken.None);
            bdk.Output(BangDieuKhien.Success);
        }

        public async Task Them(string param)
        {
            Dictionary<string, object> dict = bdk.BuildDictionary(BangDieuKhien.ParameterRegex.Matches(param),
                new Dictionary<string, Type>
                {
                    ["MaCLB"] = typeof(string),
                    ["NenTang"] = typeof(string),
                    ["DuongLienKet"] = typeof(string)
                });
            await new ThemDuongLinkCLB(dict).Execute(CancellationToken.None);
            bdk.Output(BangDieuKhien.Success);
        }

        public async Task Sua(string param)
        {
            Dictionary<string, object> dict = bdk.BuildDictionary(BangDieuKhien.ParameterRegex.Matches(param),
                new Dictionary<string, Type>
                {
                    ["MaCLB"] = typeof(string),
                    ["MaLienKet"] = typeof(int),
                    ["NenTang"] = typeof(string),
                    ["DuongLienKet"] = typeof(string)
                }, false);
            await new SuaDuongLinkCLB(dict).Execute(CancellationToken.None);
            bdk.Output(BangDieuKhien.Success);
        }
    }
}
