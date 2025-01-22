using QuanLyCLB.Commands.DuongLinkCauLacBo;
using QuanLyCLB.Commands.LoaiLich;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Console
{
    public class LoaiLich
    {
        private readonly BangDieuKhien bdk;

        public LoaiLich(BangDieuKhien bangDieuKhien)
        {
            bdk = bangDieuKhien;
        }

        public async Task DanhSach()
        {
            bdk.Output(await new DanhSachLoaiLich().Execute(CancellationToken.None));
        }

        public async Task Xoa(string param)
        {
            Dictionary<string, object> dict = bdk.BuildDictionary(BangDieuKhien.ParameterRegex.Matches(param),
                new Dictionary<string, Type>
                {
                    ["MaLoaiLich"] = typeof(string)
                });
            await new XoaLoaiLich(dict).Execute(CancellationToken.None);
            bdk.Output(BangDieuKhien.Success);
        }

        public async Task Them(string param)
        {
            Dictionary<string, object> dict = bdk.BuildDictionary(BangDieuKhien.ParameterRegex.Matches(param),
                new Dictionary<string, Type>
                {
                    ["MaLoaiLich"] = typeof(string),
                    ["TenLoaiLich"] = typeof(string),
                    ["MaMau"] = typeof(int)
                });
            await new ThemLoaiLich(dict).Execute(CancellationToken.None);
            bdk.Output(BangDieuKhien.Success);
        }

        public async Task Sua(string param)
        {
            Dictionary<string, object> dict = bdk.BuildDictionary(BangDieuKhien.ParameterRegex.Matches(param),
                new Dictionary<string, Type>
                {
                    ["MaLoaiLich"] = typeof(string),
                    ["TenLoaiLich"] = typeof(string),
                    ["MaMau"] = typeof(int)
                }, false);
            await new SuaLoaiLich(dict).Execute(CancellationToken.None);
            bdk.Output(BangDieuKhien.Success);
        }
    }
}
