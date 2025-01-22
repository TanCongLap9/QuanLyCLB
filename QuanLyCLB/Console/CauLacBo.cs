using QuanLyCLB.Commands.CauLacBo;
using QuanLyCLB.Models;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Console
{
    public class CauLacBo
    {
        private readonly BangDieuKhien bdk;

        public CauLacBo(BangDieuKhien bangDieuKhien)
        {
            bdk = bangDieuKhien;
        }

        public async Task DanhSach()
        {
            IEnumerable<CauLacBoModel> table = await new DanhSachCauLacBo().Execute(CancellationToken.None);
            bdk.Output(table);
        }

        public async Task Them(string param)
        {
            Dictionary<string, object> dict = bdk.BuildDictionary(BangDieuKhien.ParameterRegex.Matches(param),
                new Dictionary<string, Type>
                {
                    ["MaCLB"] = typeof(string),
                    ["TenCLB"] = typeof(string),
                    ["MoTa"] = typeof(string)
                });
            await new ThemCauLacBo(dict).Execute(CancellationToken.None);
            bdk.Output(BangDieuKhien.Success);
        }

        public async Task Sua(string param)
        {
            Dictionary<string, object> dict = bdk.BuildDictionary(BangDieuKhien.ParameterRegex.Matches(param),
                new Dictionary<string, Type>
                {
                    ["MaCLB"] = typeof(string),
                    ["TenCLB"] = typeof(string),
                    ["MoTa"] = typeof(string)
                }, false);
            await new SuaCauLacBo(dict).Execute(CancellationToken.None);
            bdk.Output(BangDieuKhien.Success);
        }

        public async Task TimKiem(string param)
        {
            Dictionary<string, object> dict = bdk.BuildDictionary(BangDieuKhien.ParameterRegex.Matches(param),
                new Dictionary<string, Type>
                {
                    ["MaCLB"] = typeof(string),
                    ["TenCLB"] = typeof(string),
                    ["MoTa"] = typeof(string)
                }, false);
            bdk.Output(await new TimKiemCauLacBo(dict).Execute(CancellationToken.None));
        }

        public async Task Xoa(string param)
        {
            Dictionary<string, object> dict = bdk.BuildDictionary(BangDieuKhien.ParameterRegex.Matches(param),
                new Dictionary<string, Type>
                {
                    ["MaCLB"] = typeof(string)
                });
            await new XoaCauLacBo(dict).Execute(CancellationToken.None);
            bdk.Output(BangDieuKhien.Success);
        }
    }
}
