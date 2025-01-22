using QuanLyCLB.Commands.ThanhVien;
using QuanLyCLB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuanLyCLB.Console
{
    public class ThanhVien
    {
        private readonly BangDieuKhien bdk;

        public ThanhVien(BangDieuKhien bangDieuKhien)
        {
            bdk = bangDieuKhien;
        }

        public async Task DanhSach(string param)
        {
            Dictionary<string, object> dict = bdk.BuildDictionary(BangDieuKhien.ParameterRegex.Matches(param),
                new Dictionary<string, Type>
                {
                    ["MaCLB"] = typeof(string)
                });
            bdk.Output(await new DanhSachThanhVien(dict).Execute(CancellationToken.None));
        }

        public async Task Xoa(string param)
        {
            Dictionary<string, object> dict = bdk.BuildDictionary(BangDieuKhien.ParameterRegex.Matches(param),
                new Dictionary<string, Type>
                {
                    ["MaNguoiDung"] = typeof(string),
                    ["MaCLB"] = typeof(string)
                });
            await new XoaThanhVien(dict).Execute(CancellationToken.None);
            bdk.Output(BangDieuKhien.Success);
        }

        public async Task Them(string param)
        {
            Dictionary<string, object> dict = bdk.BuildDictionary(BangDieuKhien.ParameterRegex.Matches(param),
                new Dictionary<string, Type>
                {
                    ["MaNguoiDung"] = typeof(string),
                    ["MaCLB"] = typeof(string),
                    ["ChucVu"] = typeof(ChucVu)
                });
            await new ThemThanhVien(dict).Execute(CancellationToken.None);
            bdk.Output(BangDieuKhien.Success);
        }

        public async Task Sua(string param)
        {
            Dictionary<string, object> dict = bdk.BuildDictionary(BangDieuKhien.ParameterRegex.Matches(param),
                new Dictionary<string, Type>
                {
                    ["MaNguoiDung"] = typeof(string),
                    ["MaCLB"] = typeof(string),
                    ["ChucVu"] = typeof(ChucVu)
                }, false);
            await new SuaThanhVien(dict).Execute(CancellationToken.None);
            bdk.Output(BangDieuKhien.Success);
        }
    }
}
